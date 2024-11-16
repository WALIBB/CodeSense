namespace CodeSense
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            AppTitle = new Label();
            Tagline = new Label();
            pictureBox1 = new PictureBox();
            StartButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // AppTitle
            // 
            AppTitle.AutoSize = true;
            AppTitle.Font = new Font("Segoe UI Black", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            AppTitle.Location = new Point(268, 18);
            AppTitle.Name = "AppTitle";
            AppTitle.Size = new Size(224, 52);
            AppTitle.TabIndex = 0;
            AppTitle.Text = "CodeSense";
            // 
            // Tagline
            // 
            Tagline.AutoSize = true;
            Tagline.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Tagline.Location = new Point(182, 70);
            Tagline.Name = "Tagline";
            Tagline.Size = new Size(404, 38);
            Tagline.TabIndex = 1;
            Tagline.Text = "Your Programming Detective";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1022330;
            pictureBox1.Location = new Point(295, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Red;
            StartButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            StartButton.ForeColor = Color.Orange;
            StartButton.Location = new Point(285, 360);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(197, 67);
            StartButton.TabIndex = 3;
            StartButton.Text = "Get Started";
            StartButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Programming_1024__1_;
            pictureBox2.Location = new Point(-13, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 136);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.R__12_;
            pictureBox3.Location = new Point(665, 235);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 155);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(616, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(153, 122);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 496);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(StartButton);
            Controls.Add(Tagline);
            Controls.Add(AppTitle);
            Controls.Add(pictureBox1);
            Name = "HomePage";
            Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AppTitle;
        private Label Tagline;
        private PictureBox pictureBox1;
        private Button StartButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
