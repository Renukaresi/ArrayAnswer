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
               Console.WriteLine("SmallestNumber: " + SmallestNumbers());
        }
 public static int SmallestNumbers()
        {
            int[] num = new int[] { 5, 1, 7, 2 };

            int j;
            j = num[0];
            int small = j;
            for (int i = 0; i < num.Length; i++)
            {
                //for(int j=0;j<num.Length;j++)
                //{ 
                if (num[i] < small)
                {
                    small = num[i];

                }
                //}                  
            }
            return small;
        }
    }
}