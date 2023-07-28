using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayListNeu
{
    class Buecher
    {
        string autor;
        string titel;
        long isbn;
        int pages;
        int YearOfPublication;
        string genre;

        public Buecher(string Autor, string Titel, long ISBN, int PagesNumber, int PublicationYear, string Genre)
        {
             autor = Autor;
             titel = Titel;
             isbn = ISBN;
             pages = PagesNumber;
             YearOfPublication = PublicationYear;
             genre = Genre;
        }

        public Buecher()
        {

        }

        public string MakeToString()
        {
            string isbn1 = isbn.ToString();
            string pages1 = pages.ToString();
            string YearOfPublication1 = YearOfPublication.ToString();
            //StreamWriter sr = new StreamWriter(@"C:\Users\16000801\Desktop\Ferienjob\C#\ArrayListNeu\ArrayListNeu\TextFile1.txt", append: true);
            //sr.WriteLine("Autor: " + autor + ", Titel: " + titel + ", ISBN: " + isbn1 + ", Pages: " + pages1 + ", Year of Publication: " + YearOfPublication1 + ", Genre: " + genre);
            return "Autor: " + autor + ",Titel: " + titel + ",ISBN: " + isbn1 + ",Pages: " + pages1 + ",Year of Publication: " + YearOfPublication1 + ",Genre: " + genre;
        }

        //public void TakeTheInformation()
        //{
        //    Console.WriteLine("Write The Autor, Titel, ISBN, Pages number, Year of publication and Genre: ");
        //    Console.WriteLine("Autor: ");
        //    autor = Console.ReadLine();
        //    Console.WriteLine("Titel: ");
        //    titel = Console.ReadLine();
        //    Console.WriteLine("ISBN: ");
        //    isbn = Convert.ToInt64(Console.ReadLine());
        //    Console.WriteLine("Pages Number: ");
        //    pages = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Year of publication: ");
        //    YearOfPublication = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Genre: ");
        //    genre = Console.ReadLine();

        //}

        public void PuttingIntoTheTxtFile(string strPath)
        {
            //@"C:\Users\16000801\Desktop\Ferienjob\C#\ArrayListNeu\ArrayListNeu\TextFile1.txt"
            using (StreamWriter sw = new StreamWriter(strPath, append: true))
            {
                sw.WriteLine(MakeToString());
            }
        
        }

    }
}
