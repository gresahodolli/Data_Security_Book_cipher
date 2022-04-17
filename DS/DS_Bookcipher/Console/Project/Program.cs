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

       

        
    }
}