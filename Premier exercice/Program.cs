
using System;

namespace exercice1
{
   
    /*Ecrire un programme en C# pour déterminer si un entier saisie par l'utilisateur est un nombre premier ou non.
    Gérer la validité des données saisie par l'utilisateur.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez entrer un nombre  ");
            int nombre = Convert.ToInt32(Console.ReadLine());

            while (nombre != 0)
            {
                int div = 2;
                while ((nombre % div != 0) && (div < Math.Sqrt(nombre)))
                {
                    div++;
                }
                if (nombre % div == 0)
                    Console.WriteLine(nombre + " n'est pas  un nombre premier");
                else
                    Console.WriteLine(nombre + " est  un nombre premier");

                Console.Write("Entrer un nombre S'il vous plait   ");
                nombre = Convert.ToInt32(Console.ReadLine());

            }
            if (nombre == 0)
            {
                Console.WriteLine("Entrer un nombre different de  0 S'il vous plait ");

            }

            Console.ReadKey();
        }
    }
}
