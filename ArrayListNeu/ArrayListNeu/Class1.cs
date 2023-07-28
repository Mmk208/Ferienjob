using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNeu
{
    class OneArrayList
    {
        object[] ArrayOne;
        object[] temp;
        public OneArrayList()
        {
            ArrayOne = new object[10];
        }
        public OneArrayList(int Groesse)
        {
            ArrayOne = new object[Groesse];
        }

        public int LengthReturn() {
            return ArrayOne.Length;
        }
        
        public void Add(object Number)
        {
            InIndexInsert(Number, CountTheIndex());
            

        }

        public void ReadThat()
        {
            for (int i = 0; i < ArrayOne.Length; i++) {
                Console.WriteLine(ArrayOne[i]);
            }
        }
        
        public void InIndexInsert(object Number, int index) {
            if (index > ArrayOne.Length-1)
            {
                temp = new object[ArrayOne.Length];
                ArrayOne.CopyTo(temp, 0);
                ArrayOne = new object[ArrayOne.Length + ArrayOne.Length / 2];
                temp.CopyTo(ArrayOne, 0);
                temp = new object[1];
                //int ArrO = ArrayOne[i];
                //ArrO += 5;
                //ArrayOne[index] = ArrO;

            }
            for (int i = index; i < ArrayOne.Length; i++)
            {
                if (Convert.ToInt32(ArrayOne[i]) == 0)
                {
                    ArrayOne[i] = Number;
                    break;

                }

                

            }

        }

        public void DeleteMethod(int index)
        { 
            ArrayOne[index] = 0;
            NumbersAfterTheDeleted();
        }

        public int CountTheIndex()
        {
            int counter = 0;
            for (int i = 0; i < ArrayOne.Length; i++)
            {
                if (ArrayOne[i] != null)
                {
                    counter++;
                }
                
            }
            //Console.WriteLine("The Number of the Full Indexes: " + counter);
            return counter;
        }

        public void NumbersAfterTheDeleted()
        {
            for (int i = 0; i < ArrayOne.Length; i++) {
                if (Convert.ToInt32(ArrayOne[i]) == 0 && i < ArrayOne.Length - 1)
                {
                    ArrayOne[i] = ArrayOne[i + 1];
                    ArrayOne[i + 1] = 0;
                }
            }
        }
        public object getIndex(int intIndex)
        {
            if(intIndex > ArrayOne.Length - 1)
            {
                return null;
            }
            else
            {
                return ArrayOne[intIndex];
            }
            
        }

        
        
        

    }

}

