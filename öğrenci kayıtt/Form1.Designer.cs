namespace öğrenci_kayıtt
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
            this.label1 = new System.Windows.Forms.Label();
            this.kadi = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı adı";
            // 
            // kadi
            // 
            this.kadi.Location = new System.Drawing.Point(95, 36);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(100, 22);
            this.kadi.TabIndex = 1;
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(106, 131);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(75, 23);
            this.giris.TabIndex = 2;
            this.giris.Text = "giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "şifre";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(95, 84);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(100, 22);
            this.sifre.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 376);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.kadi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifre;
    }
}

