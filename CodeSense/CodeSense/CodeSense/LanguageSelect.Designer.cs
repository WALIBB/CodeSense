using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace CodeSense
{
    partial class LanguageSelect
    {
        private System.ComponentModel.IContainer components = null;
        private Label ProgramLang;
        private Label label1;
        private PictureBox pythonpic;
        private PictureBox Cspic;
        private Label label2;
        private Label label4;
        private Button Csselect;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Pythonselect;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageSelect));
            ProgramLang = new Label();
            label1 = new Label();
            pythonpic = new PictureBox();
            Cspic = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            Csselect = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Pythonselect = new Button();
            LangBack = new Button();
            Cpppic = new PictureBox();
            label3 = new Label();
            Cppbutton = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pythonpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cspic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cpppic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // ProgramLang
            // 
            ProgramLang.Anchor = AnchorStyles.None;
            ProgramLang.BorderStyle = BorderStyle.Fixed3D;
            ProgramLang.Font = new Font("Impact", 30.8F, FontStyle.Italic);
            ProgramLang.Location = new Point(373, 32);
            ProgramLang.Name = "ProgramLang";
            ProgramLang.Size = new Size(589, 60);
            ProgramLang.TabIndex = 0;
            ProgramLang.Text = "PROGRAMMING LANGUAGES";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(431, 92);
            label1.Name = "label1";
            label1.Size = new Size(457, 41);
            label1.TabIndex = 1;
            label1.Text = "Select a Programming Language";
            // 
            // pythonpic
            // 
            pythonpic.Anchor = AnchorStyles.None;
            pythonpic.BorderStyle = BorderStyle.Fixed3D;
            pythonpic.Image = Properties.Resources.pythonlogo;
            pythonpic.Location = new Point(250, 153);
            pythonpic.Name = "pythonpic";
            pythonpic.Size = new Size(253, 225);
            pythonpic.SizeMode = PictureBoxSizeMode.Zoom;
            pythonpic.TabIndex = 2;
            pythonpic.TabStop = false;
            // 
            // Cspic
            // 
            Cspic.Anchor = AnchorStyles.None;
            Cspic.BorderStyle = BorderStyle.Fixed3D;
            Cspic.Image = (Image)resources.GetObject("Cspic.Image");
            Cspic.Location = new Point(828, 153);
            Cspic.Name = "Cspic";
            Cspic.Size = new Size(253, 225);
            Cspic.SizeMode = PictureBoxSizeMode.Zoom;
            Cspic.TabIndex = 4;
            Cspic.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Cooper Black", 18F);
            label2.Location = new Point(303, 381);
            label2.Name = "label2";
            label2.Size = new Size(133, 50);
            label2.TabIndex = 6;
            label2.Text = "Python";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Cooper Black", 18F);
            label4.Location = new Point(924, 381);
            label4.Name = "label4";
            label4.Size = new Size(73, 40);
            label4.TabIndex = 8;
            label4.Text = "C#";
            // 
            // Csselect
            // 
            Csselect.Anchor = AnchorStyles.None;
            Csselect.BackColor = SystemColors.ActiveCaption;
            Csselect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Csselect.Location = new Point(869, 422);
            Csselect.Name = "Csselect";
            Csselect.Size = new Size(182, 63);
            Csselect.TabIndex = 12;
            Csselect.Text = "Select";
            Csselect.UseVisualStyleBackColor = false;
            Csselect.Click += Csselect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.coding_png_111;
            pictureBox1.Location = new Point(1069, 433);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources._76818;
            pictureBox2.Location = new Point(12, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 249);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Pythonselect
            // 
            Pythonselect.Anchor = AnchorStyles.None;
            Pythonselect.BackColor = SystemColors.ActiveCaption;
            Pythonselect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pythonselect.Location = new Point(280, 424);
            Pythonselect.Name = "Pythonselect";
            Pythonselect.Size = new Size(182, 62);
            Pythonselect.TabIndex = 15;
            Pythonselect.Text = "Select";
            Pythonselect.UseVisualStyleBackColor = false;
            Pythonselect.Click += Pythonselect_Click;
            // 
            // LangBack
            // 
            LangBack.Anchor = AnchorStyles.None;
            LangBack.BackColor = SystemColors.ActiveCaption;
            LangBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LangBack.Location = new Point(12, 12);
            LangBack.Name = "LangBack";
            LangBack.Size = new Size(102, 43);
            LangBack.TabIndex = 16;
            LangBack.Text = "Back";
            LangBack.UseVisualStyleBackColor = false;
            LangBack.Click += LangBack_Click;
            // 
            // Cpppic
            // 
            Cpppic.Anchor = AnchorStyles.None;
            Cpppic.BorderStyle = BorderStyle.Fixed3D;
            Cpppic.Image = (Image)resources.GetObject("Cpppic.Image");
            Cpppic.Location = new Point(529, 153);
            Cpppic.Name = "Cpppic";
            Cpppic.Size = new Size(253, 225);
            Cpppic.SizeMode = PictureBoxSizeMode.Zoom;
            Cpppic.TabIndex = 17;
            Cpppic.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Cooper Black", 18F);
            label3.Location = new Point(612, 381);
            label3.Name = "label3";
            label3.Size = new Size(89, 36);
            label3.TabIndex = 18;
            label3.Text = "C++";
            // 
            // Cppbutton
            // 
            Cppbutton.Anchor = AnchorStyles.None;
            Cppbutton.BackColor = SystemColors.ActiveCaption;
            Cppbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cppbutton.Location = new Point(554, 423);
            Cppbutton.Name = "Cppbutton";
            Cppbutton.Size = new Size(182, 63);
            Cppbutton.TabIndex = 19;
            Cppbutton.Text = "Select";
            Cppbutton.UseVisualStyleBackColor = false;
            Cppbutton.Click += Cppselect_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(538, 537);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(228, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1099, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(228, 144);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // LanguageSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1298, 710);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(Cppbutton);
            Controls.Add(label3);
            Controls.Add(Cpppic);
            Controls.Add(LangBack);
            Controls.Add(Pythonselect);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Csselect);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Cspic);
            Controls.Add(pythonpic);
            Controls.Add(label1);
            Controls.Add(ProgramLang);
            Name = "LanguageSelect";
            Text = "Language Select";
            ((System.ComponentModel.ISupportInitialize)pythonpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cspic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cpppic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LangBack;
        private PictureBox Cpppic;
        private Label label3;
        private Button Cppbutton;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}


