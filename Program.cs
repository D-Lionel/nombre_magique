using System;

namespace nombre_magique
{
    class Program
    {
        static int DemanderNombre(int min, int max) // Fonction pour demander au user un nombre int, compris entre le min et le max
        {
            int nb_user_int = min-1;
            string nb_user_str = "";
            Console.Write($"Devinez le nombre entre {min} et {max} : ");

            while (nb_user_int < min || nb_user_int > max) // On s'assure que l'utilisateur rentre un nombre compris entre min et max
            {
                nb_user_str = Console.ReadLine();
                try
                {
                    nb_user_int = int.Parse(nb_user_str); // On anticipe une saisie d'un caractère autre qu'un int

                    if (nb_user_int < min || nb_user_int > max)
                    {
                        Console.WriteLine($"Choisissez un nombre entre {min} et {(max)}");
                        nb_user_int = min - 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Entrez un nombre");
                }
            }
            
            return nb_user_int;
        }
        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 11;

            Random rand = new Random();
            int nbMagic = rand.Next(NOMBRE_MIN, NOMBRE_MAX); //On choisit le nombre magique aléatoirement entre le min et le max en constantes

            
            int nbUser = nbMagic-1; // On s'assure que le nombre du user est différent du nombre magique à l'initialisation pour pouvoir lancer notre boucle

            int nbVies = 6;

            while (nbUser != nbMagic)
            {
                nbUser = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);
                if (nbUser < nbMagic)
                {
                    Console.WriteLine($"Le nombre magique est plus grand que {nbUser}");
                    
                }
                else if (nbUser > nbMagic)
                {
                    Console.WriteLine($"Le nombre magique est plus petit que {nbUser}");
                    
                }
                else
                {
                    Console.WriteLine($"Bravo");
                }
                nbVies--;
                Console.WriteLine($"Il vous reste {nbVies} vies");
                if (nbVies == 0)
                {
                    Console.WriteLine("Perdu");
                    break;
                }
                
            }
            
            
        }
    }
}
