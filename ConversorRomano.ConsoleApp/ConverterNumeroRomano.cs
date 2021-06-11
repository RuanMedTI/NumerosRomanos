using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorRomano.ConsoleApp
{
    public class ConverterNumeroRomano
    {
        
        public int ConverterNumeroRomanoSecundario()
        {

            string[] romano = { "V̄ĪĪ" }; 

            Dictionary<string, int > numeraisRomanos = new Dictionary<string, int>();

            numeraisRomanos.Add("X̄", 10000);
            numeraisRomanos.Add("ĪX̄", 9000);
            numeraisRomanos.Add("V̄ĪĪĪ", 8000);
            numeraisRomanos.Add("V̄ĪĪ", 7000);
            numeraisRomanos.Add("V̄Ī", 6000);
            numeraisRomanos.Add("V̄", 5000);
            numeraisRomanos.Add("M", 1000);
            numeraisRomanos.Add("C", 100);
            numeraisRomanos.Add("L", 50);
            numeraisRomanos.Add("X", 10);
            numeraisRomanos.Add("V", 5);
            numeraisRomanos.Add("I", 1);
            numeraisRomanos.Add("m", 1000);
            numeraisRomanos.Add("c", 100);
            numeraisRomanos.Add("l", 50);
            numeraisRomanos.Add("x", 10);
            numeraisRomanos.Add("v", 5);
            numeraisRomanos.Add("i", 1);

            int arabico = 0;

            for (int i = 0; i < romano.Count(); i++)
            {
                
                if (!numeraisRomanos.ContainsKey(romano[i]))
                    return 0;

                if (i == romano.Count() - 1)
                {
                    arabico += numeraisRomanos[romano[i]];
                }
                else
                {
                    if (numeraisRomanos[romano[i + 1]] > numeraisRomanos[romano[i]]) arabico -= numeraisRomanos[romano[i]];
                    else arabico += numeraisRomanos[romano[i]];
                }
            }
            return arabico;
        }
    }
}
