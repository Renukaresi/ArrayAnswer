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
             Console.WriteLine("FindXmorethanOnceinA: "+FindXmorethanOnceinA());           
        }
         public static bool FindXmorethanOnceinA()
        {
            Console.WriteLine("MorethanOnceNum: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            bool flag = true;
            int[] len = new int[] { 1, 9, 9, 1, 2, 9 };
            int i = 0;
            while(i <len.Length)
            {
                if(len[i]==a)
                count++;
                if(count>1)
                {
                    return flag;
                }
                i++;
            }
           return false;
        }
    }
}