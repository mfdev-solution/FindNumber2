using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int nombre = 0;
        int nbEssais = 0;
        ArrayList listNbrTested = new ArrayList();

        /*  Boolean isCorrect = false; */


        while (true)
        {
            Console.WriteLine("Veuillez saisir un nombre :");
            string nb = Console.ReadLine();

            nbEssais++;
            listNbrTested.Add(nb);

            if (int.TryParse(nb, out nombre))
            {
                if (1 <= nombre && nombre <= 10)
                {
                    if (nombre == 5)
                    {
                        Console.WriteLine("Vous avez gagné avec {0} essais",nbEssais);

                    }
                    else
                    {
                        Console.WriteLine("Vous avez perdu ! ");
                    }
                    break;

                }
                else
                {
                    Console.WriteLine("Le nombre saisi n'est pas compris entre 1 et 10 !");
                }
            }
            else
            {
                Console.WriteLine("La valeur  entrée n'est pas un nombre entier ");
            }
            foreach(var nbrTested in listNbrTested)
            {
                Console.Write(nbrTested+"\t");
            }
            Console.WriteLine();
        }
    }
}