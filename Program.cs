

namespace ConsoleApp1
{
    internal class Program
    {
        static int DemanderNombre(int min, int max)
        {
            int nmbr = 0;
            string mess = $"Veuillez entrer un nombre compris entre {min} et {max}";

            while (nmbr > max || nmbr < min)
            {
                try
                {
                    Console.WriteLine(mess);
                    nmbr = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(mess);
                }
            }
            return nmbr;
        }

        static void Main(string[] args)
        {
            /*string prenom = string.Empty;

            while ( prenom.Length < 3)
            {
                Console.Write("Quel est votre prénom :");
                prenom = Console.ReadLine();
            }

            Console.Write("Quel est votre âge :");
            string age = Console.ReadLine();

            Console.WriteLine($"Bonjour, {prenom} vous avez actuellement {age} ans");
            
            // Dans un an vous aurez age+1
            try
            {
                int ageNbr = int.Parse(age);
                if (ageNbr > 0)
                { // L'âge doit être un nombre positif
                    Console.WriteLine($"Bonjour, {prenom} dans un an vous aurez {ageNbr + 1} ans");
                }
                else
                {
                    Console.WriteLine($"Veuillez entrer un âge supérieur à 0");
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Votre age est incorrect");
            }*/


            //** Déclaration des variable initiales  **//
            int usernumber = 0;
            int count_coup = 1;
            bool gagne = false;
            //                                         //

            // constantes
            // **********
            const int MIN_ALEA = 1;
            const int MAX_ALEA = 10;
            const int MAX_COUP = 4;

            Console.WriteLine("*********************");
            Console.WriteLine("Le NOMBRE MAGIQUE (Jeu)");
            Console.WriteLine("Règles du jeu : ");
            Console.WriteLine($"- Vous avez le droit à {MAX_COUP} coups");
            Console.WriteLine($"- Le nombre magique est compris entre {MIN_ALEA} et {MAX_ALEA}");
            Console.WriteLine("*********************"); Console.WriteLine(""); Console.WriteLine("");
            // Jeu du nombr e Magique 
            Random random = new Random();

            // Générez un nombre aléatoire
            int randomnumbermagic = random.Next(MIN_ALEA, MAX_ALEA + 1);

            while (count_coup <= MAX_COUP && !gagne)
            {
                usernumber = DemanderNombre(1, MAX_ALEA);
                //Console.WriteLine($"Donnez moi un nombre entre 1 et 10");
                //usernumber = int.Parse(Console.ReadLine());
                if (usernumber < randomnumbermagic)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Coup - {count_coup} : Votre numéro est plus petit que le numéro magique");
                }
                else if (usernumber > randomnumbermagic)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Coup - {count_coup} : Votre numéro est plus grand que le numéro magique");
                }
                else if (usernumber == randomnumbermagic)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"**Bravo, vous avez trouvé le numéro magique qui est égal à {randomnumbermagic}**");
                    gagne = true;
                    break;
                }
                count_coup++;
            }

            if (!gagne)
            {
                if (count_coup > MAX_COUP)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"**Vous avez épuisé tout vos coups possible ! ({MAX_COUP})**");
                    Console.WriteLine($"**Dommage, vous avez perdu le numéro magique était ({randomnumbermagic})**"); Console.WriteLine(""); Console.WriteLine("");
                }
            }
            // Affichez le nombre généré
        }
    }
} 
