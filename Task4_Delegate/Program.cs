using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите массив целых чисел через запятую");
            //int[] myArray = Console.ReadLine().Split(',').Select(n=>int.Parse(n)).ToArray<int>();
            Random n = new Random();
            int[] myArray = new int[10];
            for(int i = 0; i<10;i++)
            {
                myArray[i] = n.Next(1, 100);
            }

            Console.WriteLine("Введите цифру 1 если хотите отсортировать масив по возростанию, цифру 2 -по убыванию");
            int choise = int.Parse(Console.ReadLine());
            if(choise ==1)
                DelegateFunc.SortArray(myArray, new DelegateFunc.Sort(DelegateFunc.Asc));
            else if(choise==2)
                DelegateFunc.SortArray(myArray, new DelegateFunc.Sort(DelegateFunc.Desc));
            else
                Console.WriteLine("Вы нажали не правильную цыфруб попробуйте еще раз");


            Console.ReadLine();
        }
        
    }
}
