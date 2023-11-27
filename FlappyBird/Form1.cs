namespace FlappyBird
{
    public partial class Form1 : Form
    {
        //oyuncu puaný
        int playerPoint = 0;
        int speed = 10;
        int minGap = 0;
        public Form1()
        {
            InitializeComponent();

            minGap = player.Height * 2;

        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            pipeDown.Left -= speed;
            pipeUp.Left -= speed;

            if (pipeDown.Right < 0)
            {
                var left = new Random().Next(this.Width + 100, this.Width + 200);
                var top = new Random().Next(this.Height / 2 - this.Height / 6, this.Height - 80);
                pipeDown.Left = left;
                pipeDown.Top = top;

                playerPoint += 10;
                lblPoint.Text = playerPoint.ToString();
                System.Media.SystemSounds.Beep.Play();
            }
            if (pipeUp.Right < 0)
            {
                var left = new Random().Next(this.Width + 100, this.Width + 200);
                var bottom = new Random().Next(50, this.Height / 2 + this.Height / 6);
                pipeUp.Top = bottom - pipeUp.Height;
                pipeUp.Left = left;
            }


            int realGap = pipeDown.Top - pipeUp.Bottom;

            if (realGap < minGap)
            {
                pipeUp.Top -= (minGap - realGap);
            }

            if (player.Bottom > 40)
            {
                player.Top += 6;
            }



            if (player.Bounds.IntersectsWith(pipeUp.Bounds) || player.Bounds.IntersectsWith(pipeDown.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitti!");
                btnStart.Visible = true;
                
            }

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                var nextY = player.Top - 18;
                if (nextY > 0)
                {
                    player.Top -= 18;
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            timer1.Start();
            playerPoint = 0;
            lblPoint.Text = "0";
            pipeDown.Left = pipeUp.Left = 750;
            player.Location = new Point(95, 191);
        }
    }
}