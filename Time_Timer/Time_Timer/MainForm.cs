using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Time_Timer
{
    public partial class Time_Timer : Form
    {
        PictureBox pic_origin = new PictureBox();
        int leftTime = 0;

        public Time_Timer()
        {
            InitializeComponent();

            pic_origin.Image = Properties.Resources.시계;
            pic_origin.SizeMode = PictureBoxSizeMode.StretchImage;
            TopMost = true;
        }

        private void pic_clock_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double x1 = 0, y1 = pic_clock.Width;
                double x2 = -(pic_clock.Height / 2 - e.Y), y2 = e.X + pic_clock.Width / 2;

                double Degree = 180 * (Math.Atan2(y2 - y1, x2 - x1) / Math.PI + 1);
                leftTime = (int)Degree * 10;    //Second

                pic_clock.Refresh();
                Graphics graphics = pic_clock.CreateGraphics();
                SolidBrush solidBrush = new SolidBrush(Color.Red);
                graphics.FillPie(solidBrush, new Rectangle(4, 4, 292, 292), -90, -(float)Degree);

                int nHour = Convert.ToInt32(Math.Truncate(leftTime / 3600.0));
                int nMin = Convert.ToInt32(Math.Truncate(leftTime / 60.0));
                if (nMin == 60)
                    nMin = 0;
                int nSec = Convert.ToInt32(leftTime % 60);
                label1.Text = nHour + " : " + nMin + " : " + nSec;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Time Over
            if (leftTime == 0)
            {
                timer1.Enabled = false;
                //Alarm
                SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath + "\\Alarm.wav");
                soundPlayer.Play();
                return;
            }
            else
            {
                leftTime -= 1;

                pic_clock.Refresh();
                Graphics graphics = pic_clock.CreateGraphics();
                SolidBrush solidBrush = new SolidBrush(Color.Red);
                graphics.FillPie(solidBrush, new Rectangle(4, 4, 292, 292), -90, -(leftTime / 10));

                int nHour = Convert.ToInt32(Math.Truncate(leftTime / 3600.0));
                int nMin = Convert.ToInt32(Math.Truncate(leftTime / 60.0));
                if (nMin == 60)
                    nMin = 0;
                int nSec = Convert.ToInt32(leftTime % 60);
                label1.Text = nHour + " : " + nMin + " : " + nSec;
            }
        }

        private void pic_clock_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
