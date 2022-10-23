using System;
using System.IO;
using System.Text;
namespace IncludeHelp
{
    class Test
    {
        static void Main(string[] args)
        {
            double a = 123456.789;
            int b = 0;
            b = (int)a;
            Console.WriteLine("value of a: {0}", a);
            Console.WriteLine("value of b: {0}", b);
            Console.ReadLine();
        }
    }
}