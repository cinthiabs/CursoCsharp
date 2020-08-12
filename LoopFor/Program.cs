using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i=0;i<num.Length;i++)
            {
                num[i] = 0;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Valor de num na pos {0}: {1} ", i, num[i]);
            }
            Console.Read();
        }
        
    }
}
