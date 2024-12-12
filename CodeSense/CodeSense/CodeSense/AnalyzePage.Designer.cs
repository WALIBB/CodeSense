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
            result = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            AppTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            label1.Location = new Point(477, 12);
            label1.Name = "label1";
            label1.Size = new Size(329, 41);
            label1.TabIndex = 1;
            label1.Text = "ENTER A STATEMENT:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(326, 83);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(632, 90);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // DetectButton
            // 
            DetectButton.BackColor = Color.Red;
            DetectButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetectButton.ForeColor = Color.FromArgb(255, 255, 128);
            DetectButton.Location = new Point(551, 190);
            DetectButton.Name = "DetectButton";
            DetectButton.Size = new Size(188, 49);
            DetectButton.TabIndex = 3;
            DetectButton.Text = "Detect";
            DetectButton.UseVisualStyleBackColor = false;
            DetectButton.Click += DetectButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._13557___Tester_512;
            pictureBox1.Location = new Point(505, 310);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(590, 242);
            label2.Name = "label2";
            label2.Size = new Size(113, 41);
            label2.TabIndex = 5;
            label2.Text = "Result:";
            label2.Click += label2_Click;
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
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1081, 383);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 259);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(229, 268);
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
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(299, 231);
            result.Name = "result";
            result.Size = new Size(0, 20);
            result.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.code_icon_png_51;
            pictureBox4.Location = new Point(152, 383);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(220, 227);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1044, 41);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(227, 255);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // AppTitle
            // 
            AppTitle.AutoSize = true;
            AppTitle.BackColor = Color.Transparent;
            AppTitle.Font = new Font("Segoe UI Black", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            AppTitle.Location = new Point(551, 649);
            AppTitle.Name = "AppTitle";
            AppTitle.Size = new Size(224, 52);
            AppTitle.TabIndex = 13;
            AppTitle.Text = "CodeSense";
            // 
            // AnalyzePage
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1298, 710);
            Controls.Add(AppTitle);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(result);
            Controls.Add(AnalyzeBack);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(FinalResult);
            Controls.Add(label2);
            Controls.Add(DetectButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblLanguage);
            Controls.Add(pictureBox1);
            Name = "AnalyzePage";
            Text = "Analyze Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Label result;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label AppTitle;
    }
}

