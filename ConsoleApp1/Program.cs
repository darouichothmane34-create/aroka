using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        String choix;
        String texte;

        texte = File.ReadAllText(@"../../../../ressources\titre.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\image.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\démmarrage.txt");
        Console.WriteLine(texte);
        Console.ReadLine();

        texte = File.ReadAllText(@"../../../../ressources\histoire.txt");
        Console.WriteLine(texte);

 

        //Votre déroulé d'aventure
    }
}