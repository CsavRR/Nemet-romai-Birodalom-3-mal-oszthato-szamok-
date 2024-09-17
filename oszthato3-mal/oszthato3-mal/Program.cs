using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oszthato3_mal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 21; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + ": A szám osztható 3-mal");
                }
                else
                {
                    Console.WriteLine(i + ": A szám nem osztható 3-mal");
                }
            
            }
            Console.WriteLine("Megnyitottam a tanirodában a kódot. ÁÁÁÁÁÁ");
            Console.ReadKey();

           
        
        }
    }
}
