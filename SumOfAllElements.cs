using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Array_Questions
{
    class Program
    {
           static void Main(string[] args)
        {
                Console.WriteLine("SumOfElements: " + SumOfElements());
        }
         public static int SumOfElements()
        {
            int[] num = new int[] { 12, 11, 13 };
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            return sum;
        }
    }
}