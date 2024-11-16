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
            ((System.ComponentModel.ISupportInitialize)pythonpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cspic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ProgramLang
            // 
            ProgramLang.BorderStyle = BorderStyle.Fixed3D;
            ProgramLang.Font = new Font("Impact", 22.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ProgramLang.Location = new Point(171, 32);
            ProgramLang.Name = "ProgramLang";
            ProgramLang.Size = new Size(445, 60);
            ProgramLang.TabIndex = 0;
            ProgramLang.Text = "PROGRAMMING LANGUAGES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 92);
            label1.Name = "label1";
            label1.Size = new Size(381, 35);
            label1.TabIndex = 1;
            label1.Text = "Select a Programming Language";
            // 
            // pythonpic
            // 
            pythonpic.BorderStyle = BorderStyle.Fixed3D;
            pythonpic.Image = Properties.Resources.pythonlogo;
            pythonpic.Location = new Point(205, 153);
            pythonpic.Name = "pythonpic";
            pythonpic.Size = new Size(150, 160);
            pythonpic.SizeMode = PictureBoxSizeMode.Zoom;
            pythonpic.TabIndex = 2;
            pythonpic.TabStop = false;
            // 
            // Cspic
            // 
            Cspic.BorderStyle = BorderStyle.Fixed3D;
            Cspic.Image = (Image)resources.GetObject("Cspic.Image");
            Cspic.Location = new Point(426, 153);
            Cspic.Name = "Cspic";
            Cspic.Size = new Size(150, 160);
            Cspic.SizeMode = PictureBoxSizeMode.Zoom;
            Cspic.TabIndex = 4;
            Cspic.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Cooper Black", 13F);
            label2.Location = new Point(229, 316);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 6;
            label2.Text = "Python";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Cooper Black", 13F);
            label4.Location = new Point(484, 316);
            label4.Name = "label4";
            label4.Size = new Size(43, 27);
            label4.TabIndex = 8;
            label4.Text = "C#";
            // 
            // Csselect
            // 
            Csselect.BackColor = SystemColors.ActiveCaption;
            Csselect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Csselect.Location = new Point(437, 346);
            Csselect.Name = "Csselect";
            Csselect.Size = new Size(130, 39);
            Csselect.TabIndex = 12;
            Csselect.Text = "Select";
            Csselect.UseVisualStyleBackColor = false;
            Csselect.Click += Csselect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coding_png_111;
            pictureBox1.Location = new Point(656, 329);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._76818;
            pictureBox2.Location = new Point(12, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Pythonselect
            // 
            Pythonselect.BackColor = SystemColors.ActiveCaption;
            Pythonselect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pythonselect.Location = new Point(215, 346);
            Pythonselect.Name = "Pythonselect";
            Pythonselect.Size = new Size(130, 39);
            Pythonselect.TabIndex = 15;
            Pythonselect.Text = "Select";
            Pythonselect.UseVisualStyleBackColor = false;
            Pythonselect.Click += Pythonselect_Click;
            // 
            // LangBack
            // 
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
            // LanguageSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 499);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LangBack;
    }
}


