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

            ConversorNumeroIndoArabico conversorIndoArabico = new ConversorNumeroIndoArabico();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(conversorIndoArabico.ConversorNumeroIndoArabicoPrimario(7000));
            Console.ResetColor();

            ConverterNumeroRomano conversorRomano = new ConverterNumeroRomano();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(conversorRomano.ConverterNumeroRomanoSecundario());
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}

