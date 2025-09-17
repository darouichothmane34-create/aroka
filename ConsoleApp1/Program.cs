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

        chapitre_01();

        //Votre déroulé d'aventure
    }

    public static void chapitre_01()
    {
        String texte;

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\sous_titre01.txt");
        Console.WriteLine(texte);
        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\titre_image.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\1er_message.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\2éme_message.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\3ème_message.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\4ème_message.txt");
        Console.WriteLine(texte);
        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\4M_image.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\5ème_message.txt");
        Console.WriteLine(texte);
        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\5M_image.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\6ème_message.txt");
        Console.WriteLine(texte);
        
    }
    
}