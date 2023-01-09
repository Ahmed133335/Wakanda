using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_vektorer_och_sökning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] minVektor = new string[5];
            string sökord = "";// tilldelar sökord som en tom variabel 
            bool minbool = true;// så länge det svar är sann spelas in loopen

            while (minbool)
            {
                Console.WriteLine(" Välkommen till menyval");
                Console.WriteLine("[1] skriv ett elmemnt värde");
                Console.WriteLine("[2] skriv ut elmemntet");
                Console.WriteLine("[3] skapa en falsk bool");
                Console.WriteLine("[4] avsluta programmet");

                Console.WriteLine("Välj en menyval: ");


                int menyval;
                int.TryParse(Console.ReadLine(), out menyval);//Här sparar vi användarens val och hen ska välja en av menyvalen.




                switch (menyval)

                {
                    case 1:
                        // menyval 1

                        for (int i = 0; i < minVektor.Length; i++)// i är den som gör att vi får olika index från 0-4
                        {
                            minVektor[i] = Console.ReadLine();
                        }
                        break;

                    case 2:
                        // menval 2
                        for (int i = 0; i < minVektor.Length; i++)
                        {
                            Console.WriteLine(minVektor[i]);

                        }
                        break;

                    case 3:
                        // menval 3
                     bool nybool = false;  // så länge minVektor är fel spelas in loopen

                        Console.WriteLine("Det här är sökning. Skriv in ett Namn som börja¨på 'A' och se om det finns");
                         sökord = Console.ReadLine();
                        for (int i = 0; i < minVektor.Length; i++)
                        {

                            if (sökord == minVektor[i])
                            {
                                Console.WriteLine("Namnet finns i vektor på indexplats " + i + "!");
                                Console.WriteLine(" Sökningen lyckades!");
                                nybool = true;
                            }

                        }

                        if (nybool == false)
                        {
                            Console.WriteLine("Sökordet hittades inte!!!");
                        }

                        break;

                    default:

                        Console.WriteLine("Du skrev fel!");
                        minbool = false;// Här tilldelas Mybool till false. När användaren väljer menyval 3 stängs av programmet

                        break;

                }






            }
        }
    }

}
