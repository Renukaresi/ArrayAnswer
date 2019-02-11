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
                     Console.WriteLine("Mean: " + Mean());
        }
        public static int Mean()
        {
            int[] num = new int[] { 2, 1, 3 };
            int mean = 0, count = 0;
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
                count++;
                mean = sum / count;
            }
            return mean;
        }
    }
}

