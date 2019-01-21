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
             console.WriteLine("FindX: " + FindX());
                   
        }
        public static bool FindX()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int[] len = new int[] {6,3,5,0,1,9} ;
            bool flag = true;
            //Console.WriteLine("Enter num: ");
            for(int i=0;i<len.Length;i++)
            {
               // len[i] = Convert.ToInt32(Console.ReadLine());
               if (len[i] == x)
                {
                    return flag;
                    //break;
                }
            }
            return false;
        }
    }
}