using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
{
    class Program
    {

        static void MyReverse(int[] Array)
        {

            int L = Array.Length -1;
            int f = 0;
            for (int i = 0; i < Array.Length; i++)
            {

                if (L >= Array.Length/2)
                {
                    f = Array[L];
                    Array[L] = Array[i];
                    Array[i] = f;
                    L--;
                    Console.Write(Array[i] + " ");
                }
                else
                {
                    Console.Write(Array[i] + " ");
                }

            }
                      
        }



        static void Main(string[] args)
        {
           Console.Write("Enter number of array: ");
            int l = Convert.ToInt32(Console.ReadLine());


            int[] Mass = new int[l];
            Random rand = new Random();
            for (int i = 0; i < Mass.Length; i++)
            {
               Mass[i] = rand.Next(100);
                Console.Write(Mass[i] + " ");
            }
            Console.WriteLine();


            MyReverse(Mass);

            Console.ReadKey();

        }
    }
}
