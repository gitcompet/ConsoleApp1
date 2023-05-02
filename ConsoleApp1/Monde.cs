using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Monde
    {

        public int[] Grille1D = new int[30];

        //        public int[int[]] Grille2Dp = new int[];

        //        public int[,] Grille2D = new int[1, 1];
        public int[,] Grille2D = new int[30,27];

        public int[][] Grille2Dj = new int[30][];
        
        static Monde()
        {
            //             Grille1D[1] = 1;
            //            var toto = Grille1D[1] ;
            //Console.WriteLine(toto);
            //Grille2Dj[1][] = 1;
            //            var toto = Grille2D[1,1] ;
            //Console.WriteLine(toto);
        }
    }


}
