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
            Console.WriteLine("the number of times X is found in A: " + ThenumberoftimesXisfoundinA());
        }
        public static int ThenumberoftimesXisfoundinA()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] len = new int[] { 1, 4, 9, 1, 9, 1 };
            int i = 0;
            while (i < len.Length)
            {
                if (len[i] == a)
                {
                    count++;
                }

                i++;
            }
            return count;
        }
    }
}