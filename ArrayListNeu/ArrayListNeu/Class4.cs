using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNeu
{
    class StreamDing
    {
        public StreamDing()
        {
            Buecher b = new Buecher("J.KRowling", "Harry Potter", 3551551677, 334, 1997, "Science-Fiction");
            StreamWriter sr = new StreamWriter(@"C:\Users\16000801\Desktop\Ferienjob\C#\ArrayListNeu\ArrayListNeu\TextFile1.txt");
            sr.WriteLine(b.MakeToString());
        }
            
            


    }
}
