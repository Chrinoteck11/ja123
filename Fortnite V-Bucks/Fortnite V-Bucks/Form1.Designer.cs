namespace Fortnite_V_Bucks
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_password = new System.Windows.Forms.TextBox();
            this.rtb_v_bucks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_mail
            // 
            this.rtb_mail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_mail.Location = new System.Drawing.Point(274, 61);
            this.rtb_mail.Name = "rtb_mail";
            this.rtb_mail.Size = new System.Drawing.Size(232, 20);
            this.rtb_mail.TabIndex = 0;
            this.rtb_mail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rtb_password
            // 
            this.rtb_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_password.Location = new System.Drawing.Point(274, 171);
            this.rtb_password.Name = "rtb_password";
            this.rtb_password.Size = new System.Drawing.Size(232, 20);
            this.rtb_password.TabIndex = 3;
            this.rtb_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rtb_v_bucks
            // 
            this.rtb_v_bucks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_v_bucks.Location = new System.Drawing.Point(274, 261);
            this.rtb_v_bucks.Name = "rtb_v_bucks";
            this.rtb_v_bucks.Size = new System.Drawing.Size(232, 20);
            this.rtb_v_bucks.TabIndex = 4;
            this.rtb_v_bucks.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "V-Bucks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get Your V-Bucks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_v_bucks);
            this.Controls.Add(this.rtb_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_mail);
            this.Name = "Form1";
            this.Text = "Free V-Bucls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rtb_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rtb_password;
        private System.Windows.Forms.TextBox rtb_v_bucks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

