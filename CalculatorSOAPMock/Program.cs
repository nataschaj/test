using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSOAPMock.CalculatorReference;
using WcfMock;

namespace CalculatorSOAPMock
{
    class Program
    {

        //private const int PORT = 9999;
        static void Main(string[] args)
        {

            //ClientCalc client = new ClientCalc(PORT);
            //client.Start();

            //Console.ReadLine();

            //var calc = new Service1();

            var calc = new CalculatorReference.Service1Client();

            Console.WriteLine($"Volumen er: " + calc.GetVolume(10, 10, 5));
            Console.WriteLine($"Den sidste side er: " + calc.GetSide(25, 1, 4));

            Console.ReadLine();

        }
    }
}
