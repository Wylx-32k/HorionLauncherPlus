using System.Diagnostics;
using System.Net;

namespace HL_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int maxWidth = 280;
            double duration = 3000;

            var sw = Stopwatch.StartNew();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 16;

            timer.Tick += (s, e2) =>
            {
                double t = sw.Elapsed.TotalMilliseconds / duration;
                if (t >= 1)
                {
                    LBWhite.Width = maxWidth;
                    timer.Stop();
                    return;
                }

                double eased = 1 - Math.Pow(1 - t, 3);
                LBWhite.Width = (int)(eased * maxWidth);

                if (t > 0.33 && t < 0.35)
                {
                    if (!CheckForInternetConnection())
                    {
                        MessageBox.Show("This application requires internet, please re-launch when connected.");
                        Application.Exit();
                    }
                }

                if (t > 0.66 && t < 0.68)
                {

                    if (CheckForInternetConnection())
                    {

                    }
                    else { Application.Exit(); }
                }

                if (t > 0.9 && t < 0.92)
                {
                    if (CheckForInternetConnection())
                    {

                    }
                    else { Application.Exit(); }
                }
            };

            timer.Start();
        }

        //too lazy to code ty stack overflow
        private static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
