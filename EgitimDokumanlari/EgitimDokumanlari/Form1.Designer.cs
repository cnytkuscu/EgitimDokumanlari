namespace EgitimDokumanlari
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
            btnTopla = new Button();
            btnCarp = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(12, 70);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(75, 23);
            btnTopla.TabIndex = 0;
            btnTopla.Text = "Topla";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // btnCarp
            // 
            btnCarp.Location = new Point(93, 70);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(75, 23);
            btnCarp.TabIndex = 1;
            btnCarp.Text = "Carp";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += btnCarp_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 106);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCarp);
            Controls.Add(btnTopla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTopla;
        private Button btnCarp;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}