using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorRomano.ConsoleApp
{
    public class ConversorNumeroIndoArabico
    {
        public string ConversorNumeroIndoArabicoPrimario(int numero)
        {

            int[] Valores = { 10000, 9000, 8000, 7000, 6000, 5000, 4000, 3000,
                1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] Romanos = { "X̄", "ĪX̄", "V̄ĪĪĪ", "V̄ĪĪ", "V̄Ī", "V̄", "ĪV̄", "MMM", 
                "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            int NumeroNormal = numero;
            string Resultado = "";
            int i = 0;
            while (NumeroNormal > 0)
            {
                while (NumeroNormal >= Valores[i])
                {
                    Resultado = Resultado + Romanos[i];
                    NumeroNormal = NumeroNormal - Valores[i];
                }
                i++;

                if (Resultado == "IIII" || Resultado == "XXXX" || Resultado == "CCCC" || Resultado == "MMMM")
                    Console.WriteLine("Com exceção de V, L e D, os outros numerais " +
                        "podem se repetir no máximo três vezes");

            }
            return Resultado;
        }
    }
}
