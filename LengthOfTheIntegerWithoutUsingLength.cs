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
             Console.WriteLine("LengthOfIntegerWithoutUsingLength: " + LengthOfIntegerWithoutUsingLength());
                   
        }
        public static int LengthOfIntegerWithoutUsingLength()
        {
            int count = 0;
            int[] len = new int[] {1,2,3,4,5,6};
           // Console.WriteLine("Enter num: ");
            foreach(var i in len)
            {
               // len[i] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            return count;
        }
    }
}