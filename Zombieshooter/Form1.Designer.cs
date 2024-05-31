namespace Zombieshooter
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
            picShotgun = new PictureBox();
            picRevolver = new PictureBox();
            pictureBox4 = new PictureBox();
            timerMove = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            timerSpawn = new System.Windows.Forms.Timer(components);
            buttonStart = new Button();
            labelScore = new Label();
            labelYouDied = new Label();
            ((System.ComponentModel.ISupportInitialize)picShotgun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRevolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // picShotgun
            // 
            picShotgun.BackColor = Color.Transparent;
            picShotgun.Image = Properties.Resources.sawedoff;
            picShotgun.Location = new Point(162, 180);
            picShotgun.Margin = new Padding(4);
            picShotgun.Name = "picShotgun";
            picShotgun.Size = new Size(549, 138);
            picShotgun.SizeMode = PictureBoxSizeMode.Zoom;
            picShotgun.TabIndex = 1;
            picShotgun.TabStop = false;
            picShotgun.Click += picShotgun_Click;
            // 
            // picRevolver
            // 
            picRevolver.BackColor = Color.Transparent;
            picRevolver.Image = Properties.Resources.revolver;
            picRevolver.Location = new Point(238, -4);
            picRevolver.Margin = new Padding(4);
            picRevolver.Name = "picRevolver";
            picRevolver.Size = new Size(302, 146);
            picRevolver.SizeMode = PictureBoxSizeMode.Zoom;
            picRevolver.TabIndex = 2;
            picRevolver.TabStop = false;
            picRevolver.Click += picRevolver_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.zombie;
            pictureBox4.Location = new Point(1454, 15);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(374, 476);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // timerMove
            // 
            timerMove.Tick += timerMove_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1454, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 33);
            label1.TabIndex = 4;
            label1.Text = "HP: 328";
            label1.Visible = false;
            // 
            // timerSpawn
            // 
            timerSpawn.Interval = 5000;
            timerSpawn.Tick += timerSpawn_Tick;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Black;
            buttonStart.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(4, 365);
            buttonStart.Margin = new Padding(4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(274, 45);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start shootin'";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.ForeColor = Color.White;
            labelScore.Location = new Point(319, 371);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(133, 33);
            labelScore.TabIndex = 6;
            labelScore.Text = "SCORE: 0";
            // 
            // labelYouDied
            // 
            labelYouDied.AutoSize = true;
            labelYouDied.BackColor = Color.Transparent;
            labelYouDied.Font = new Font("Showcard Gothic", 70F, FontStyle.Bold, GraphicsUnit.Point);
            labelYouDied.ForeColor = Color.Firebrick;
            labelYouDied.Location = new Point(560, 119);
            labelYouDied.Name = "labelYouDied";
            labelYouDied.Size = new Size(793, 173);
            labelYouDied.TabIndex = 7;
            labelYouDied.Text = "YOU DIED!";
            labelYouDied.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.dualwield3;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1818, 425);
            Controls.Add(labelYouDied);
            Controls.Add(labelScore);
            Controls.Add(buttonStart);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(picRevolver);
            Controls.Add(picShotgun);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picShotgun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRevolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picShotgun;
        private PictureBox picRevolver;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timerMove;
        private Label label1;
        private System.Windows.Forms.Timer timerSpawn;
        private Button buttonStart;
        private Label labelScore;
        private Label labelYouDied;
    }
}