using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bloog
{
    class program
    {
        static void Main(string[] args)
        {
            List<string[]> Bloglista = new List<string[]>(); // Här skapar jag listan med strängvektor
            bool isRuning = true;

            while (isRuning) // Här startar while loppen. Så länge isRuninig är true fortsätter programmet
            {
                Console.Clear();
                Console.WriteLine("Skriv 1 för att skriva blogg"); // Här persenterar jag alternativerna
                Console.WriteLine("Skriv 2 för att visa bloggen");
                Console.WriteLine("Skriv 3 för att söka");
                Console.WriteLine("Skriv 4 för att avsluta programet");

                Console.WriteLine("Välj en alternativ:");

                int menyval;
                int.TryParse(Console.ReadLine(), out  menyval); // Här sparar jag användarens val
                switch (menyval)
                {
                    case 1:
                        string[] antalblog = new string[2]; // Skapar jag vektor som innehåller 2 vektorer
                        Console.WriteLine("Skriva din title\n");
                        antalblog[0] = Console.ReadLine(); // Här ska vi inmata titlens namn och vi gör det genom att tilldela första elmentet till Console.ReadLine();
                        Console.WriteLine("Skriva din text\n");
                        antalblog[1] = Console.ReadLine();

                        Bloglista.Add(antalblog);// Här lägger jag elmentet i Listan

                        Console.WriteLine("Din blogg har sparats!");
                        break;
                    case 2:

                        for (int i = 0; i < Bloglista.Count; i++) // Här sparar vi antal sprande element i BlogListan. Så länge i är mindre än BlogListan och adderar med 1
                        {
                            Console.WriteLine("_____________________________________");
                            Console.WriteLine(" Bloggnummer : " +  (i + 1));
                            Console.WriteLine(" Din Title heter: " + Bloglista[i][0] );
                            Console.WriteLine(" Din Text heter: " + Bloglista[i][1]);
                        }
                        break;
                    case 3:

                        bool nybool = false;
                        
                        Console.WriteLine(" sök titlens namn i bloggen: ");
                          string sökord = Console.ReadLine();// Här skriver vi det vi ska söka

                        for (int i = 0; i < Bloglista.Count; i++)
                        {
                            if (Bloglista[i][0].Contains(sökord) == true)// Här använder jag en metod som heter Contains.  Om de sprande titlar innehåller det ordet jag söker kommer funka. Om det är sant så funkar programmet och skrivas ut där nere.
                            {
                                Console.WriteLine("Namnet finns i vektor på indexplats " + i + "!");// Här ska den visa vilken indexnummer vår sökning hade
                                Console.WriteLine(" Sökningen lyckades!");
                                
                                nybool = true; 

                            }       
                        }
                        if (nybool == false)// Om vi har inte skriver något vi sparat i listan så funkar det ej.
                        {
                            Console.WriteLine("Sökordet hittades inte!!!"); // Visar användaren att sökningen stämmer inte med det som är sprande
                        }

                        break;
                    case 4:
                        isRuning = false;// Avsluta programmet när vi väljer alternativ 4
                        break;
                    default:
                        Console.WriteLine("Du måste skriva 1-4");// Påminner användaren att han/hon ska välja en siffra mellan 1 - 4
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}






