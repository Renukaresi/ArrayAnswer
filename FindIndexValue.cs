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
          Console.WriteLine("FindA: " + FindIndexofValue());             
        }
         public static int FindIndexofValue()
        {
            Console.WriteLine("Find Index: ");
            int a= Convert.ToInt32(Console.ReadLine());
            int flag = 1;
            int[] len = new int[] {7,5,9,3,4,6};
            int i = 0;
               while(i<len.Length)
            {
                if(len[i]==a)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}