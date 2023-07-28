using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayListNeu
{
    class Program
    {
        static string[] SplitString;
        static void Main(string[] args)
        {
            
            ////Console.WriteLine("Write a Number");
            ////Console.ReadLine();
            //OneArrayList Arr = new OneArrayList();
            ////Console.WriteLine("Length of the Array: " + Arr.LengthReturn());
            ////Arr.Add(5);        // 0
            ////Console.WriteLine("Length of the Array: " + Arr.LengthReturn());
            ////Arr.Add(425);
            ////Arr.Add(85285);
            ////Arr.Add(15);
            ////Arr.InIndexInsert(23, 12);
            //////Arr.DeleteMethod(3);
            ////Arr.CountTheIndex();
            ////Arr.ReadThat();
            ////StK.PushIntoTheStack(39);
            ////Console.WriteLine(StK.PullOutTheStack());
            //////StK.ClearTheStack();
            ////Console.WriteLine(StK.PeekTheStack());
            ////StK.ShowTheNumber();
            //StK.CountTheElements();
            //Arr.BuchAnzeige();
            //sr.Close();
            //while (true)
            //{
            //Buecher b = new Buecher();
            //b.TakeTheInformation();
            //b.PuttingIntoTheTxtFile(@"C: \Users\16000801\Desktop\Ferienjob\C#\ArrayListNeu\ArrayListNeu\TextFile1.txt");
            //    Buecher b = new Buecher("J.KRowling", "Harry Potter", 3551551677, 334, 1997, "Science-Fiction");
            //    b.MakeToString();
            //}

            
            OneArrayList help = readFile();
            StackName StK = new StackName();
            for (int i = 0; i < help.CountTheIndex(); i++)
            {
                SplitString = help.getIndex(i).ToString().Split(',');

                for (int j = 0; j < SplitString.Length; j++)
                {
                    SplitString[j] = SplitString[j].Substring(SplitString[j].IndexOf(':') + 2);
                }
                StK.PushIntoTheStack(new Buecher(SplitString[0], SplitString[1], Convert.ToInt64(SplitString[2]), Convert.ToInt32(SplitString[3]), Convert.ToInt32(SplitString[4]), SplitString[5]));
               
            }
            for (int i = 0; i < SplitString.Length; i++)
            {
                Console.WriteLine(SplitString[i]);
            }
            //Buecher b = new Buecher(SplitString[0], SplitString[1], Convert.ToInt64(SplitString[2]), Convert.ToInt32(SplitString[3]), Convert.ToInt32(SplitString[4]), SplitString[5]);
            help.ReadThat();
            
            Console.ReadLine();
            

        }
        static OneArrayList readFile()
        {
            OneArrayList FileValues;
            FileValues = new OneArrayList();

            using (StreamReader sr = new StreamReader(@"C:\Users\16000801\Desktop\Ferienjob\C#\ArrayListNeu\ArrayListNeu\TextFile1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    FileValues.Add(sr.ReadLine());
                    
                }        
            }
            return FileValues;
        }

    }
}
