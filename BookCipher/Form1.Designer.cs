namespace BookCipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBookCipher = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.lblBookCipher = new System.Windows.Forms.Label();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pdf Files|*.pdf|Text|*.txt";
            this.openFileDialog1.Title = "Zgjedh PDF fajllin";
            // 
            // txtBookCipher
            // 
            this.txtBookCipher.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtBookCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCipher.ForeColor = System.Drawing.Color.White;
            this.txtBookCipher.Location = new System.Drawing.Point(17, 49);
            this.txtBookCipher.Name = "txtBookCipher";
            this.txtBookCipher.ReadOnly = true;
            this.txtBookCipher.Size = new System.Drawing.Size(857, 30);
            this.txtBookCipher.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(880, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zgjedh pdf / txt fajllin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlainText
            // 
            this.txtPlainText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlainText.ForeColor = System.Drawing.Color.White;
            this.txtPlainText.Location = new System.Drawing.Point(17, 135);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(1084, 70);
            this.txtPlainText.TabIndex = 2;
            this.txtPlainText.TextChanged += new System.EventHandler(this.txtPlainText_TextChanged);
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtEncryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedText.ForeColor = System.Drawing.Color.Lime;
            this.txtEncryptedText.Location = new System.Drawing.Point(17, 292);
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(1084, 30);
            this.txtEncryptedText.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.DimGray;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Lavender;
            this.btnEncrypt.Location = new System.Drawing.Point(880, 219);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(221, 34);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Enkripto";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainText.ForeColor = System.Drawing.Color.Lavender;
            this.lblPlainText.Location = new System.Drawing.Point(17, 107);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(99, 25);
            this.lblPlainText.TabIndex = 6;
            this.lblPlainText.Text = "Plain Text";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.DimGray;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.Lavender;
            this.btnDecrypt.Location = new System.Drawing.Point(880, 334);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(221, 34);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Dekripto";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtDecryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptedText.ForeColor = System.Drawing.Color.White;
            this.txtDecryptedText.Location = new System.Drawing.Point(17, 408);
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(1084, 30);
            this.txtDecryptedText.TabIndex = 8;
            // 
            // lblBookCipher
            // 
            this.lblBookCipher.AutoSize = true;
            this.lblBookCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCipher.ForeColor = System.Drawing.Color.Lavender;
            this.lblBookCipher.Location = new System.Drawing.Point(17, 21);
            this.lblBookCipher.Name = "lblBookCipher";
            this.lblBookCipher.Size = new System.Drawing.Size(388, 25);
            this.lblBookCipher.TabIndex = 10;
            this.lblBookCipher.Text = "PDF / Text fajlli për enkriptim të Plain Text-it";
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptedText.ForeColor = System.Drawing.Color.Lavender;
            this.lblEncryptedText.Location = new System.Drawing.Point(17, 255);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(285, 25);
            this.lblEncryptedText.TabIndex = 11;
            this.lblEncryptedText.Text = "Text-i i Enkriptuar (Cipher Text)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(17, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Text-i i Dekriptuar (Decrypted Text)";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Lavender;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(880, 476);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(221, 34);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Dalja";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1123, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEncryptedText);
            this.Controls.Add(this.lblBookCipher);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDecryptedText);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblPlainText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncryptedText);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBookCipher);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Enkriptimi dhe dekriptimi me metoden Book Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBookCipher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBookCipher;
        private System.Windows.Forms.Label lblEncryptedText;
        private System.Windows.Forms.Label label1;
    }
}

