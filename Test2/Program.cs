using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            char c;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; c = "A"; j <= i;j++;c++)
                    {
                        Console.Write(c + "");
                    }
                     Console.WriteLine();
            }
        }
    }
}
