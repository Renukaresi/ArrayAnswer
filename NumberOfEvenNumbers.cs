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
             Console.WriteLine("NumberOfEvenNumber: " + NumberOfEvenNumbers());
        }
 public static int NumberOfEvenNumbers()
        {
            int[] num = new int[] { 1, 3, 1, 8 };
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
