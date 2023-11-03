using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    internal class Program
    {
        // Déclarations globabes
        static char reponse;
        static void saisie()
        {
            do
            {
                Console.Write("Avez vous un prix à saisir ? (O/N) : ");
                reponse = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (reponse != 'O' && reponse != 'N');
        }
        static void Main(string[] args)
        {
            // Déclarations
            float prix;
            float total = 0;

            // Demande de saisie d'un premier prix
            saisie();

            // Saisie d'un premier prix
            if (reponse == 'O')
            {
                Console.WriteLine();
                Console.Write("Saisissez un prix : ");
                prix = float.Parse(Console.ReadLine());
                total = total + prix;
            }
            // Demande de saisie d'un prix
            while (reponse == 'O')
            {
                saisie();
                // Saisie d'un prix
                if (reponse == 'O')
                {
                    Console.WriteLine();
                    Console.Write("Saisissez un prix : ");
                    prix = float.Parse(Console.ReadLine());
                    total = total + prix;
                }
                else
                {
                    Console.Write("Le total des prix est : " + total + " euros.");
                    Console.ReadLine();
                }
            }


        }
    }
}
