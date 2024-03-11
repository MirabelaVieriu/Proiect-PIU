using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            Pom myPom = new Pom();

            Console.Write("Introduceti tipul de pom: ");
            myPom.tip = Console.ReadLine();
            Console.WriteLine($"Tipul introdus este:{myPom.tip}");


            Console.Write("Introduceti cantitatea de fructe:");
            
            if (int.TryParse(Console.ReadLine(), out myPom.cantitate_fructe))
            {
                Console.WriteLine($"Cantitatea de fructe introdusa este: {myPom.cantitate_fructe}");
            }
            else
            {
                Console.WriteLine("Va rugam sa introduceti o valoare valida pentru cantitatea de fructe.");
            }

            Console.Write("Introduceti anul plantarii:");
            if(int.TryParse(Console.ReadLine(), out myPom.anul_plantarii))
            {
                Console.WriteLine($"Anul plantari este:{myPom.anul_plantarii}");
            }
            else 
            {
                Console.WriteLine("Va rugam sa introduceti o valoare valida pentru anul plantarii.");
            }



            Console.ReadKey();

         }
        
    }
}
