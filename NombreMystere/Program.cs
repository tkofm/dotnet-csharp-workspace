//initialisation des variables
const int nbMystere = 6;
string prenom = "";
int nbSaisi = 0;
Console.Write("******Mystery Number GAME******\n");
Console.WriteLine("");
Console.Write("Veuillez saisir votre prénom: \n");
 prenom = Console.ReadLine();

while (nbSaisi != nbMystere){

    Console.WriteLine("Veuillez entrer un nombre entre 1 et 10");
    try
    {
        nbSaisi = int.Parse(Console.ReadLine());
        if(nbSaisi < 1 || nbSaisi > 10)
        {
            Console.WriteLine("Votre nombre doit être compris entre 1 et 10.");
        }else{
            if(nbSaisi == nbMystere){
            Console.WriteLine("Vous avez trouvé le nombre Mystère.");
            }else {
                if(nbSaisi < nbMystere)
                {
                    Console.WriteLine("Le nombre Mystère est plus Grand.");
                }else{
                    Console.WriteLine("Le nombre Mystère est plus Petit.");
                }
            }
            
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Il semblerait que vous ayez commis une erreur de saisi. Veuillez recommencez en saisissant un nombre en fichre.");
    }
}
