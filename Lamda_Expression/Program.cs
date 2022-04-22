using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //addition using lambda Expressions

            Func<int, int> Addition = Add => Add + Add;

            Console.WriteLine(Addition(9));
        }
    }
}
