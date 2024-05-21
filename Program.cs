using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a forma que deseja: ");
            string forma = Console.ReadLine();

            switch (forma)
            {
                case "quadrado":
                    quadrado();
                    break;
                case "retangulo":
                    retangulo();
                    break;
                case "trapezio":
                    trapezio();
                    break;
                case "losango":
                    losango();
                    break;
            }
            Console.ReadKey();
        }

        static void quadrado()
        {
            Console.WriteLine("Informe o valor da base da forma: ");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura da forma: ");
            double alt = double.Parse(Console.ReadLine());
            double area = bas * alt; 
        }

        static void retangulo()
        {
            Console.WriteLine("Informe o valor da base da forma: ");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura da forma: ");
            double alt = double.Parse(Console.ReadLine());
            double area = bas * alt;
        }

        static void trapezio()
        {
            Console.WriteLine("Informe o valor da base da forma: ");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura da forma: ");
            double alt = double.Parse(Console.ReadLine());
            double area = bas * alt;
        }

        static void losango()
        {
            Console.WriteLine("Informe o valor da base da forma: ");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura da forma: ");
            double alt = double.Parse(Console.ReadLine());
            double area = bas * alt;
        }

        
    }

}
