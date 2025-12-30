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
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 44);
            label1.TabIndex = 0;
            label1.Text = "Horion Launcher";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Italic);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(0, 35);
            label2.Name = "label2";
            label2.Size = new Size(300, 31);
            label2.TabIndex = 1;
            label2.Text = "With version history!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(10, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 1);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Open Sans", 8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 120);
            label3.Name = "label3";
            label3.Size = new Size(300, 30);
            label3.TabIndex = 3;
            label3.Text = "You can find the source code here.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(300, 150);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}
