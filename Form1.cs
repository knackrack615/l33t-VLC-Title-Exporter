using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace l33t_VLC_Title_Exporter
{
    public partial class Form1 : Form
    {
        Boolean started = false;
        string newstring;
        string prevstring;
        public Form1()
        {
            InitializeComponent();
            console.Text += "l33t VLC Title Exporter Started! \n";
        }

        private void check_interval_slider_Scroll(object sender, EventArgs e)
        {
            interval_box.Text = check_interval_slider.Value + "   ms";
        }

        private void save_inverval_Click(object sender, EventArgs e)
        {
            console.Text += "Interval changed to " + check_interval_slider.Value + "\n";
            check_interval.Interval = check_interval_slider.Value;
            console.Text += "File path changed to " + filepath.Text + "\n";
        }

        private void start_Click(object sender, EventArgs e)
        {
            if(started) {
                l33t_stop();
            }
            else
            {
                l33t_start();
            }
        }

        public bool get_title()
        {
            try
            {
                Process[] procs = Process.GetProcessesByName("vlc");
                if (procs.Length != 1)
                {
                    console.Text += "VLC Is not running! \n";
                    File.WriteAllText(filepath.Text, "No song is currently playing");
                    l33t_stop();
                    return false;
                }
                Process proc = procs[0];
                if (proc.MainWindowTitle.Contains("-"))
                {
                    newstring = Regex.Replace(proc.MainWindowTitle, ".mp3[\\s\\S]*$", "");
                    if(prevstring != newstring)
                    {
                        console.Text += "The title is: " + newstring + "\n";
                        File.WriteAllText(filepath.Text, newstring);
                        prevstring = newstring;
                    }
                    
                }
                else
                {
                    newstring = "No song is currently playing";
                    check_interval.Interval = 1500;
                    check_interval_slider.Value = 1500;
                    if (prevstring != newstring)
                    {
                        console.Text += "VLC Is running but no song is playing! \n";
                        File.WriteAllText(filepath.Text, "No song is currently playing");
                        prevstring = newstring;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                console.Text += "VLC got rekt! \n";
                File.WriteAllText(filepath.Text, "VLC Crashed");
                l33t_stop();
                return false;
            }
        }

        private void check_interval_Tick(object sender, EventArgs e)
        {
            if(started)
            {
                get_title();
            }
        }

        private void l33t_stop()
        {
            check_interval.Stop();
            started = false;
            start.Text = "Start";
        }

        private void l33t_start()
        {
            check_interval.Start();
            started = true;
            start.Text = "Stop";
        }

        private void console_TextChanged(object sender, EventArgs e)
        {
            console.SelectionStart = console.Text.Length;
            console.ScrollToCaret();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            console.Text += "Exiting... \n";
            File.WriteAllText(filepath.Text, "");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filepath.Text, "");
            console.Text += "Reseting file \n";
            prevstring = "";
        }
    }
}
