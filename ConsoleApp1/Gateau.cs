using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gateau
    {
        public float poids = 1;
        public string type = "Monstre";
        private string Saveur;

        public int[,] Grille = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        public Gateau(float poids, string saveur) {
            Saveur = saveur;
            var toto = Grille[1,1];
            Console.WriteLine("toto 1:" + toto);
            toto = Grille[0, 0];
            Console.WriteLine("toto 2:" + toto);
        }

        public void Manger()
        {
            this.poids = 0;
        }
        public string getSaveur()
        {
            return this.Saveur;
        }
        public void setSaveur(string sav)
        {
            this.Saveur=sav;
        }
    }

}
