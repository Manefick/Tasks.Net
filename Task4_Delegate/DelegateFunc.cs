using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Delegate
{
    class DelegateFunc
    {
        public static void SortArray(int [] array, Sort sort)
        {
            int temp;
            for(int i = 0; i < array.Length-1; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if(sort(array[i],array[j]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (int k in array)
                Console.Write(k + " ");
        }
        public delegate bool Sort(int x, int y);

        public static bool Asc(int x, int y)
        {
            if (x > y)
                return true;
            else
                return false;
        }
        public static bool Desc(int x, int y)
        {
            if (x < y)
                return true;
            else
                return false;
        }
    }
}
