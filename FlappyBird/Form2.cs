using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form2 : Form
    {
        int userPoint = 0;
        int speed = 15;
        int minHeight = 0;
        public Form2()
        {
            InitializeComponent();

            var r = new Random();
            int rastgele = r.Next(50, 80);
            minHeight = player.Height + player.Height;

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.W)
            {
                player.Top -= 40;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pipeup.Left -= speed;
            pipeDown.Left -= speed;

            if (pipeDown.Right < 0 && pipeup.Right < 0)
            {
                pipeDown.Left = this.Width + new Random().Next(50, 190); pipeup.Left = this.Width + new Random().Next(30, 150);

                pipeDown.Top = new Random().Next(this.Height / 2 - 100, this.Height - 100); 
                pipeup.Top = new Random().Next(-320, -100);

                userPoint += 10;
                lblPoint.Text=userPoint.ToString();

                if (userPoint%20==0)
                {
                    speed += 5;
                }
            }

            int realGap = pipeDown.Top - pipeup.Bottom;
            if (realGap<minHeight)
            {
                pipeDown.Top += minHeight - realGap;

            }


            if (player.Bottom<this.Height)
            {
                player.Top += 10;
            }
            if (player.Bounds.IntersectsWith(pipeDown.Bounds)||player.Bounds.IntersectsWith(pipeup.Bounds))
            {
                timer1.Stop();
                
                MessageBox.Show("Öldün");
                btnStart.Visible = true; ;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            timer1.Start();
            pipeDown.Left = pipeup.Left = 645;
        }
    }
}
