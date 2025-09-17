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

        texte = File.ReadAllText(@"C:\Users\Administrateur\Documents\git\JAT\aroka\ressources\titre.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"C:\Users\Administrateur\Documents\git\JAT\aroka\ressources\image.txt");
        Console.WriteLine(texte);
 

 



        //Votre déroulé d'aventure
    }
}