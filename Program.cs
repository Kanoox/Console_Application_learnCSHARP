

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quel est votre prénom :");
            string prenom = Console.ReadLine();

            Console.Write("Quel est votre âge :");
            string age = Console.ReadLine();

            Console.WriteLine($"Bonjour, {prenom} vous avez actuellement {age} ans");
        }
    }
}