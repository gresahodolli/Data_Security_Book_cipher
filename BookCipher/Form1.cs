using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;



namespace BookCipher
{
    public partial class Form1 : Form
    {
        private string bookCipherPDFFileName { get; set; }
        private string plainTexti { get; set; }
        private string EncryptedTexti { get; set; }
        private string DecryptedTexti { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.SecureData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBookCipher.Text = openFileDialog1.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GetText(string filePath)
        {
            string ext = System.IO.Path.GetExtension(filePath);

            if (ext.ToLower() == ".pdf")
            {
                var sb = new StringBuilder();
                try
                {
                    using (PdfReader reader = new PdfReader(filePath))
                    {
                        string prevPage = "";
                        for (int page = 1; page <= reader.NumberOfPages; page++)
                        {
                            ITextExtractionStrategy its = new SimpleTextExtractionStrategy();
                            var s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                            if (prevPage != s) 
                                sb.Append(s);
                            prevPage = s;
                        }
                        reader.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ju lutem zgjedhni fajllin per enkriptim.", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return sb.ToString();
            }

            else
            {
                string txt = File.ReadAllText(filePath);
                return txt;
            }
        }
        private string Encrypt(string plaintext, string book)
        {
            string[] wordArray = book.Split(new[] { Environment.NewLine, " " }, StringSplitOptions.None);
            string[] plainTextArray = plaintext.Split(new[] { Environment.NewLine, " " }, StringSplitOptions.None);
            string cipherText = "";
            try
            {
                for (int i = 0; i < plainTextArray.Length; i++)
                {
                    string word = plainTextArray[i];
                    int index = Array.IndexOf(wordArray, word);
                    if (index < 0)
                    {
                        throw new Exception();
                    }
                    cipherText += index + 1;
                    cipherText += " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ky tekst nuk mund të enkriptohet!\nJu lutem provoni një tekst tjetër.", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return cipherText.TrimEnd();
        }
        private string Decrypt(string ciphertext, string book)
        {
            int[] indexes = ciphertext
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n) - 1)
                .ToArray();

            string plaintext = "";
            string[] wordArray = book.Split(new[] { Environment.NewLine, " " }, StringSplitOptions.None);
            foreach (int index in indexes)
            {
                plaintext += wordArray[index] + " ";
            }

            return plaintext.TrimEnd();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {   
             if (String.IsNullOrEmpty(txtBookCipher.Text.TrimEnd()))
            {
                MessageBox.Show("Duhet të zgjedhni fajllin për enkriptim", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (String.IsNullOrEmpty(txtPlainText.Text.TrimEnd()))
            {
                MessageBox.Show("Ju lutem shënoni plaintext-in për enkriptim!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            plainTexti = txtPlainText.Text.TrimEnd();
            bookCipherPDFFileName = txtBookCipher.Text.TrimEnd();
            EncryptedTexti = Encrypt(plainTexti, GetText(bookCipherPDFFileName));
            txtEncryptedText.Text = EncryptedTexti;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {   
            if (String.IsNullOrEmpty(txtBookCipher.Text.TrimEnd()))
            {
                MessageBox.Show("Duhet të zgjedhni fajllin për enkriptim", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (String.IsNullOrEmpty(txtEncryptedText.Text.TrimEnd()))
            {
                MessageBox.Show("Nuk ekziston text-i i enkriptuar!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bookCipherPDFFileName = txtBookCipher.Text.TrimEnd();
            EncryptedTexti = txtEncryptedText.Text.TrimEnd();
            DecryptedTexti = Decrypt(EncryptedTexti, GetText(bookCipherPDFFileName));
            txtDecryptedText.Text = DecryptedTexti;
        }

        private void txtPlainText_TextChanged(object sender, EventArgs e)
        {
            txtEncryptedText.Text = "";
            txtDecryptedText.Text = "";
        }
    }
}
