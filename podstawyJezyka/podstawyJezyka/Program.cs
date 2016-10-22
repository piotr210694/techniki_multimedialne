using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class Program
    {
        static void Main(string[] args)
        {
            _1_HelloWorld hello = new _1_HelloWorld();
            _2_ConsoleWriteLine write = new _2_ConsoleWriteLine();
            //_3_readFromConsole readFCons = new _3_readFromConsole();
            _5_loopFor lf = new _5_loopFor();

            Console.ReadKey();
        }
    }
}
