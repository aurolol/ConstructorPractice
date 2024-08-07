using System;
using ConstructorPractice;
namespace ConstructorPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Baby baby1 = new Baby("Atakan", "Çelik");

            baby1.WelcomeWorld();              // Parametre alarak oluşturulan constructor.
            Console.WriteLine("----------------------------");
            Baby baby2 = new Baby();
            baby2._name = "Atakan";
            baby2._surName = "Çelik";
            baby2.WelcomeWorld();              //  Default Constructor tarzında parametre almayan bir metot.
        }
    }
}
