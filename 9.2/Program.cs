using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
{
    class Program
    {

        static void SubArray(int[] Array, int index, int count) //массив,число с индексом откуда начинать и сколько вывести
        {
            int[] Array_index = new int[count];
            int j = 0;
            
            for (int i = index; i < index+count; i++)
            {
               Array_index[j] = Array[i];

                Console.Write(Array_index[j] + " ");

                j++;



            }



        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of array: ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enetr index number: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Lenght of Array: ");
            int Len = Convert.ToInt32(Console.ReadLine());


            int[] Mass = new int[l];
            Random rand = new Random();
            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = rand.Next(100);
                Console.Write(Mass[i] + " ");
            }
            Console.WriteLine();

            SubArray(Mass,index,Len);


            Console.ReadKey();

        }
    }
}
