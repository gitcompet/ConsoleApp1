// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//System.Diagnostics.Debug.WriteLine("!!!!!!!!!!! ===> Hello, World! <=== !!!!!!!!!!!");

using System;
using System.Runtime.CompilerServices;
using ConsoleApp1;

public class Program {
    //    this.saveur = "vanille" ;
    //	this.poids=1,0;
    //	this.saveur="vanille";	


    static void  Main(string[] args)
    {
        Console.WriteLine("Hello Pac World");
        
        Gateau cake = new Gateau(2 , "Point" );
        
        Gateau cake2 = new Gateau(3, "Pac");
        Console.WriteLine("cake2.Saveur 1:" + cake2.Saveur);
        Console.WriteLine("cake.Saveur 1:" + cake.Saveur);
                Console.WriteLine("cake.poids 1:" + cake.poids);
        cake.Saveur = "Monstre";
        cake.Manger();
        //		Console.WriteLine(saveur);
        Console.WriteLine("cake.Saveur 2:"  + cake.Saveur);
        Console.WriteLine("cake.poids 2:" + cake.poids);

        Monde monde = new Monde();
        Console.WriteLine("monde :" + monde);
    }

}