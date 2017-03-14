namespace Chapter_9_Problem_6
{
    partial class Form1
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
            this.password1 = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.password2 = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(95, 67);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(100, 20);
            this.password1.TabIndex = 0;
            this.password1.TextChanged += new System.EventHandler(this.Password1_TextChanged);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(197, 226);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(107, 98);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(95, 132);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(100, 20);
            this.password2.TabIndex = 3;
            this.password2.TextChanged += new System.EventHandler(this.Password2_TextChanged);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(107, 158);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 4;
            this.Check.Text = "Submit";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.password1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label label1;
    }
}

