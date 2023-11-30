namespace FlappyBird
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            player = new PictureBox();
            pipeDown = new PictureBox();
            pipeup = new PictureBox();
            lblPoint = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackgroundImage = (Image)resources.GetObject("player.BackgroundImage");
            player.BackgroundImageLayout = ImageLayout.Stretch;
            player.Location = new Point(44, 225);
            player.Name = "player";
            player.Size = new Size(71, 59);
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // pipeDown
            // 
            pipeDown.BackgroundImage = (Image)resources.GetObject("pipeDown.BackgroundImage");
            pipeDown.BackgroundImageLayout = ImageLayout.Stretch;
            pipeDown.Location = new Point(645, 225);
            pipeDown.Name = "pipeDown";
            pipeDown.Size = new Size(94, 374);
            pipeDown.TabIndex = 1;
            pipeDown.TabStop = false;
            // 
            // pipeup
            // 
            pipeup.BackgroundImage = (Image)resources.GetObject("pipeup.BackgroundImage");
            pipeup.BackgroundImageLayout = ImageLayout.Stretch;
            pipeup.Location = new Point(645, -323);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(94, 374);
            pipeup.TabIndex = 2;
            pipeup.TabStop = false;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.BackColor = Color.Blue;
            lblPoint.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPoint.ForeColor = Color.White;
            lblPoint.Location = new Point(27, 10);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(35, 41);
            lblPoint.TabIndex = 3;
            lblPoint.Text = "0";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 192, 0);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(294, 164);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 61);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(lblPoint);
            Controls.Add(pipeup);
            Controls.Add(pipeDown);
            Controls.Add(player);
            KeyPreview = true;
            Name = "Form2";
            Text = "Form2";
            KeyUp += Form2_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox pipeDown;
        private PictureBox pipeup;
        private Label lblPoint;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
    }
}