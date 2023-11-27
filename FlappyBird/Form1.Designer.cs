namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            floor = new PictureBox();
            player = new PictureBox();
            lblPoint = new Label();
            pipeDown = new PictureBox();
            pipeUp = new PictureBox();
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)floor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeUp).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // floor
            // 
            floor.Location = new Point(-6, 342);
            floor.Name = "floor";
            floor.Size = new Size(1380, 39);
            floor.TabIndex = 3;
            floor.TabStop = false;
            // 
            // player
            // 
            player.BackgroundImage = (Image)resources.GetObject("player.BackgroundImage");
            player.BackgroundImageLayout = ImageLayout.Stretch;
            player.Location = new Point(95, 191);
            player.Name = "player";
            player.Size = new Size(51, 44);
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPoint.ForeColor = Color.FromArgb(0, 0, 192);
            lblPoint.Location = new Point(12, 9);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(35, 41);
            lblPoint.TabIndex = 5;
            lblPoint.Text = "0";
            // 
            // pipeDown
            // 
            pipeDown.Image = (Image)resources.GetObject("pipeDown.Image");
            pipeDown.Location = new Point(759, 216);
            pipeDown.Name = "pipeDown";
            pipeDown.Size = new Size(74, 308);
            pipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeDown.TabIndex = 6;
            pipeDown.TabStop = false;
            // 
            // pipeUp
            // 
            pipeUp.Image = (Image)resources.GetObject("pipeUp.Image");
            pipeUp.Location = new Point(759, -139);
            pipeUp.Name = "pipeUp";
            pipeUp.Size = new Size(74, 241);
            pipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeUp.TabIndex = 7;
            pipeUp.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 192, 0);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(159, 117);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(152, 68);
            btnStart.TabIndex = 8;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 346);
            Controls.Add(lblPoint);
            Controls.Add(btnStart);
            Controls.Add(pipeUp);
            Controls.Add(pipeDown);
            Controls.Add(player);
            Controls.Add(floor);
            KeyPreview = true;
            Name = "Form1";
            Text = "Flappy Bird";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)floor).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeUp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox floor;
        private PictureBox player;
        private Label lblPoint;
        private PictureBox pipeDown;
        private PictureBox pipeUp;
        private Button btnStart;
    }
}