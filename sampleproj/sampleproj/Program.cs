using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testlib;

namespace sampleproj
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1 c = new Class1();
             int a,b;
             a = 10;
             b = 5;
             int sum = a + b;
             c.writeLogger(Convert.ToString(sum));
             Console.ReadLine();
        }
    }
}
