// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
// Console.WriteLine("J'apprends le C#");

// int age = 18;
// string nom = "Minou";
// bool guest = true;
// int taille = 183;
// taille =  200; // réaffactation

// const string country = "FR"; // constante

// //Typage implicite
// var valeur = 10; // Obligation d'affecter une valeur

//exercice 1
// Console.Write("Bonjour veuillez saisir une entrée: ");
// var value = Console.ReadLine();
// Console.WriteLine();
// Console.WriteLine("Vous avez saisis l'entrée: " + value + " qui est de type" + value.GetType().Name);

// System.Int32 tag = 106;

// int unMilliard = 1_000_000_000;
//  var iNeedALong = 16UL;

// Console.WriteLine(tag.GetType().Name);

// string prenom = "Christophe";
// char charA = 'a';
// char copyriht = '\u00A9'; //écrire des caractère unicode
// Console.WriteLine(copyriht);

// using System.Globalization;

// string cheminWindowsSimple = @"C:\docs\fichier.txt";
// string jacquesADit = @"Jacques a dit : ""Assis !""";

// string prenom = "Minou";
// string bonjour = $"Bonjour, {prenom}";
// Console.WriteLine(bonjour);

//Exercice 2
// Console.WriteLine("Veuillez saisir votre prenom");
// string prenom = Console.ReadLine();
// Console.WriteLine("Veuillez saisir votre age");
// string age = Console.ReadLine();
// Console.WriteLine($"Bonjour {prenom}, vous avez {age} ans.");

// int a = 1;
// int b = 1;

// bool equal = a == b;
// Console.WriteLine(equal);

//Conversion de Type pas possible en cSharp sauf dans certain cas, comme suit:

// string age = "11";
// int intAge = Convert.ToInt32(age);//convert avec la fonction convert
// Console.WriteLine(intAge);

// string saisie = Console.ReadLine();
// int intSaisie = int.Parse(saisie);

//Les Conditions

//Exercice 3
// const int ageMajorité = 18;
// Console.Write("Entrer votre age: \n");
// if (int.Parse(Console.ReadLine()) >= ageMajorité)
// {
//     Console.WriteLine("Vous êtes majeur.");
// }else{
//     Console.WriteLine("Vous ête mineur.");
// }

//Les Collections
// //Le Tableau
// string[] monTableau = new string[10];

// monTableau[0] = "toto";
// monTableau[9] = "hello";

// string toto = monTableau[0];
// //init et affectation de valeur dans un tableau (nb saisir toutes valeurs du tableaux)
// int[] unACinq = new int[5]{1,2, 3, 4, 5};

// // La Liste
// List<string> maListe = new List<string>();
// maListe.Add(toto);
// toto = maListe[0];

// //Les Boucles

// //for
// int[] tab = new int[10];
// //pour remplir
// for(int i = 0; i < tab.Length; i++)
// {
//     tab[i] = (int) i;
// }
// //pour lire
// // for(int i = 0; i < tab.Length; i++)
// // {
// //     Console.WriteLine(tab[i]);
// // }
// //while
// //for_each
// //affcher les éléments du tableau
// Console.WriteLine("Votre tableau contient les entiers: ");
// foreach(int i in tab)
// {
//     Console.WriteLine(i);
// }

//Les exceptions
//try/Catch

try{
    Console.WriteLine("Veuillez saisir votre age: ");
string age = Console.ReadLine();
int agefutur =  int.Parse(age) + 10;
Console.WriteLine("Vous aurez  "+ agefutur +" ans dans 10 ans.");

}catch (Exception e)
{
    Console.WriteLine("Veuillez à bien saisir une valeur numérique.");
}