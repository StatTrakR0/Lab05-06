using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Printer1;

namespace Lab05_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = PrinterPropertis.PrinterInit();
            printer.outPrinter();
            Console.ReadKey();
        }
    }
}
