using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorRomano.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor Números Romanos");
            ConversorNumeroIndoArabico conversor = new ConversorNumeroIndoArabico();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(conversor.ConversorNumeroIndoArabicoPrimario(1 + 1));
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}

