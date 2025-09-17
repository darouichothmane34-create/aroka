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

        chapitre_00();
        

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

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\2eme_message.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\3eme_message.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\4eme_message.txt");
        Console.WriteLine(texte);
        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\4M_image.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\5eme_message.txt");
        Console.WriteLine(texte);
        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\5M_image.txt");
        Console.WriteLine(texte);

        texte = File.ReadAllText(@"../../../../ressources\chapitre_01\6eme_message.txt");
        Console.WriteLine(texte);

    }


    public static void chapitre_00()
    {
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

    }






} 
 