using System;

namespace premier_programme
{
    internal class Program
    {
        static void AfficherInfoPersonne(string nom, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour vous vous appelez, " + nom + " vous avez " + age + " ans.");
            Console.WriteLine("bientôt vous aurez " + (age + 1) + " ans");

            
            if(age == 17)
            {
                Console.WriteLine("Vous serez bientôt majeur");
            }
            else if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur");
            }
            else if(age < 10)
            {
                Console.WriteLine("Vous êtes un enfant");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous êtes un sénior");
            }
            else if (age > 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
        }

        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write(nom + ",Quel est votre age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur: l'âge ne dois pas être négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur: l'âge ne dois pas être égal à 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur: Vous devez rentrer un âge valide");
                }
            }
            return age_num;
        }

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";

            while (nom == "")
            {
                Console.Write("Quel est le nom de la personne numéro " + numeroPersonne + " ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();  //supprime les espaces 

                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne dois pas être vide");
                }
            }
            return nom;
        }

        static void Main(string[] args)
        {
            //demandr nom 
            string nom1 = DemanderNom(1);
            string nom2 = DemanderNom(2);

            //demander l'âge
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            //afficher les resultats 
            AfficherInfoPersonne(nom1, age1);
            AfficherInfoPersonne(nom2, age2);
        }
    }
}