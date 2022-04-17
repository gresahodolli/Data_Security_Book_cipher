using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;

namespace BookCipher
{   
    class Program
    {
        //Fajlli
        static readonly string textFile = @"C:\Users\OnLine\Desktop\Libri\pjesa1.txt";

        public static string readFile(string textFile)
        {
            if(File.Exists(textFile))
            {
                string txt = File.ReadAllText(textFile);
                return txt;
            }
            return "Fajlli nuk ekziston\n";
        }

        static readonly string PDFFile = @"C:\Users\OnLine\Desktop\Libri\libri.pdf";

       public static string GetText(string filePath)
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
                        if (prevPage != s) sb.Append(s);
                        prevPage = s;
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return sb.ToString();
        }
static string Encrypt(string plaintext, string book)
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
            catch (Exception)
            {
                throw new Exception("Nuk mund te enkriptohet ky mesazh.\nProvoni nje tjeter!");
            }
            return cipherText.TrimEnd();
        }
        static string Decrypt(string ciphertext, string book)
        {
            int[] indexes = ciphertext
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n) - 1)
                .ToArray();

            string plaintext = "";
            string[] wordArray = book.Split(' ');
            foreach (int index in indexes)
            {
                plaintext += wordArray[index] + " ";
            }

            return plaintext.TrimEnd();
        }
        
    }
}
