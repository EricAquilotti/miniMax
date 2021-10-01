using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 3, 8, -12, 20, -3 };

            int min = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine(min);

            Console.ReadKey();
        }
    }
}
