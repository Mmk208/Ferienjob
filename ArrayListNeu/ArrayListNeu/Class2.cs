using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNeu
{
    class StackName
    {
        // Implementieren SIe die Klasse Stack mit den Methoden push, pull, clear, anzahl elemente im stack und peek!
        // passen sie die Klasse Stack und arrayList so an, dass neben ints auch andere datentypen bzw objekte eingefügt werden können!

        object[] StKName;

        public StackName()
        {
            StKName = new object[10];
        }

        public void PushIntoTheStack(object Num)
        {
            for (int i = 0; i < StKName.Length; i++)
            {
                if (StKName[i] == null)
                {
                    StKName[i] = Num;
                    break;
                    
                }
            }
        }

        public void ShowTheNumber()
        {
            for (int i = 0; i < StKName.Length; i++)
            {
                Console.WriteLine(StKName[i]);
            }
        }

        public object PullOutTheStack()
        {
            object lastObject = 0;
            for (int i = StKName.Length - 1; i >= 0; i--)
            {
                if (StKName[i] != null)
                { 
                    lastObject = StKName[i];
                    StKName[i] = null;                    
                    return lastObject;


                }

            }
            return null;

        }

        public void ClearTheStack()
        {
            //for (int i = 0; i < StKName.Length; i++)
            //{
            //    StKName[i] = 0;

            //}
            StKName = new object[10];
        }

        public void CountTheElements()
        {
            int counter = 0;
            for (int i = 0; i < StKName.Length; i++)
            {
                counter++;
                
            }
            Console.WriteLine("The Elements: " + counter);
        }

        public object PeekTheStack()
        {
            object lastNumber = 0;
            for (int i = StKName.Length - 1; i >= 0; i--)
            {
                if (StKName[i] != null)
                {
                    lastNumber = StKName[i];
                    return lastNumber;

                }
            }
            return null;
        }

    }
}
