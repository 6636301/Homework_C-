using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of array: ");
            int l = Convert.ToInt32(Console.ReadLine());
                    

            int[] Mass = new int[l];
            Random rand = new Random();
            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = rand.Next(100);
                Console.WriteLine(Mass[i]);
            }
            Console.WriteLine();
         
            for (int i = 0; i < Mass.Length; i++)
            {
                if (Mass[i] % 2 != 0)
                {
                    Console.Write(Mass[i] + " ");
                }
            }
             
            Console.ReadKey();

            //branch_test
        }
    }
}
