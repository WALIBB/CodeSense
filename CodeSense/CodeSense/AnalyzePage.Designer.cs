using System.Security.Policy;
using System.Windows.Forms;

namespace CodeSense
{
    partial class AnalyzePage
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLanguage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzePage));
            lblLanguage = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            DetectButton = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            FinalResult = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            AnalyzeBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLanguage.Location = new Point(282, 50);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(0, 32);
            lblLanguage.TabIndex = 0;
            lblLanguage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 41);
            label1.TabIndex = 1;
            label1.Text = "ENTER A STATEMENT:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(173, 90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 42);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // DetectButton
            // 
            DetectButton.BackColor = Color.Red;
            DetectButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetectButton.ForeColor = Color.FromArgb(255, 255, 128);
            DetectButton.Location = new Point(238, 138);
            DetectButton.Name = "DetectButton";
            DetectButton.Size = new Size(178, 40);
            DetectButton.TabIndex = 3;
            DetectButton.Text = "Detect";
            DetectButton.UseVisualStyleBackColor = false;
            DetectButton.Click += DetectButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._13557___Tester_512;
            pictureBox1.Location = new Point(219, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 181);
            label2.Name = "label2";
            label2.Size = new Size(113, 41);
            label2.TabIndex = 5;
            label2.Text = "Result:";
            // 
            // FinalResult
            // 
            FinalResult.AutoSize = true;
            FinalResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            FinalResult.Location = new Point(219, 222);
            FinalResult.Name = "FinalResult";
            FinalResult.Size = new Size(0, 32);
            FinalResult.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(555, 196);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-10, 196);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 179);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // AnalyzeBack
            // 
            AnalyzeBack.BackColor = SystemColors.ActiveCaption;
            AnalyzeBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnalyzeBack.Location = new Point(12, 12);
            AnalyzeBack.Name = "AnalyzeBack";
            AnalyzeBack.Size = new Size(100, 38);
            AnalyzeBack.TabIndex = 9;
            AnalyzeBack.Text = "Back";
            AnalyzeBack.UseVisualStyleBackColor = false;
            AnalyzeBack.Click += AnalyzeBack_Click;
            // 
            // AnalyzePage
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(699, 471);
            Controls.Add(AnalyzeBack);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(FinalResult);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(DetectButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblLanguage);
            Name = "AnalyzePage";
            Text = "Analyze Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox textBox1;
        private Button DetectButton;
        private PictureBox pictureBox1;
        private Label label2;
        private Label FinalResult;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button AnalyzeBack;
    }
}

