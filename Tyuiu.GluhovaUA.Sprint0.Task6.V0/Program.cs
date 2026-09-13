using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.GluhovaUA.Sprint0.Task6.V0
{
    class Progras
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("" = "" + DataService.AdditionArray(arraynums));
            Console.WriteLine("" = "" + DataService.SubtractionArray(arraynums));
            Console.WriteLine("" = "" + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();

        }
    }
}