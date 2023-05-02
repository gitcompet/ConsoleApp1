using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ConsoleApp1
{
    internal class Controle
    {
        public Controle() { }
        public void Start()
        {
            Console.WriteLine("Hello Pac World");
        
            Gateau cake = new Gateau(2, "Point");

            Gateau cake2 = new Gateau(3, "Pac");
            Console.WriteLine("cake2.Saveur 1:" + cake2.getSaveur());
            Console.WriteLine("cake.Saveur 1:" + cake.getSaveur());
                    Console.WriteLine("cake.poids 1:" + cake.poids);
            cake.setSaveur("Monstre");
            cake.Manger();
            //		Console.WriteLine(saveur);
            Console.WriteLine("cake.Saveur 2:"  + cake.getSaveur());
            Console.WriteLine("cake.poids 2:" + cake.poids);

            Monde monde = new Monde();
            Console.WriteLine("monde :" + monde);
        }
    }
}
