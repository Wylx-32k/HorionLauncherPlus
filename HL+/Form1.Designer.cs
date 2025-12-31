namespace HL_
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
            label1 = new Label();
            LBGray = new Panel();
            LBWhite = new Panel();
            Splash = new Label();
            label2 = new Label();
            LBGray.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 21);
            label1.Name = "label1";
            label1.Size = new Size(300, 44);
            label1.TabIndex = 0;
            label1.Text = "Horion Launcher";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBGray
            // 
            LBGray.BackColor = Color.FromArgb(30, 30, 30);
            LBGray.Controls.Add(LBWhite);
            LBGray.Location = new Point(10, 101);
            LBGray.Name = "LBGray";
            LBGray.Size = new Size(280, 2);
            LBGray.TabIndex = 2;
            // 
            // LBWhite
            // 
            LBWhite.BackColor = Color.FromArgb(199, 199, 199);
            LBWhite.ForeColor = SystemColors.Control;
            LBWhite.Location = new Point(0, 0);
            LBWhite.Name = "LBWhite";
            LBWhite.Size = new Size(10, 2);
            LBWhite.TabIndex = 3;
            // 
            // Splash
            // 
            Splash.Font = new Font("Open Sans", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Splash.ForeColor = Color.White;
            Splash.Location = new Point(0, 100);
            Splash.Name = "Splash";
            Splash.Size = new Size(300, 22);
            Splash.TabIndex = 3;
            Splash.Text = "Source code publicly available on GitHub!";
            Splash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Italic);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(0, 65);
            label2.Name = "label2";
            label2.Size = new Size(300, 31);
            label2.TabIndex = 1;
            label2.Text = "v1.0b";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 25);
            ClientSize = new Size(300, 128);
            Controls.Add(LBGray);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Splash);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            LBGray.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel LBGray;
        private Label Splash;
        private Panel LBWhite;
        private Label label2;
    }
}
