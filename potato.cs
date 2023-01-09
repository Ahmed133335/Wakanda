using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Bloog
{
    class program
    {
        static void Main(string[] args)
        {
            string search = "";
            List<string[]> Bloglista = new List<string[]>();
            bool isRuning = true;

            while (isRuning)
            {
                Console.Clear();
                Console.WriteLine("Skriva 1 för att skriva blog\nSkriva 2 för att visa blogen\nSkriva 3 för att avsluta programet");
                Int32.TryParse(Console.ReadLine(), out int menyval);
                switch (menyval)
                {
                    case 1:
                        string[] antalblog= new string[2];
                        Console.WriteLine("Skriva din title\n");
                        antalblog[0] = Console.ReadLine();
                        Console.WriteLine("Skriva din Blog\n");
                        antalblog[1] = Console.ReadLine();

                        Bloglista.Add(antalblog);

                        Console.WriteLine("din blog har sparats!");
                        break;
                    case 2:

                        for (int i = 0; i<Bloglista.Count; i++)
                        {
                            Console.WriteLine("Title:\n" + Bloglista[i][0] + "\n");
                            Console.WriteLine("Blog:\n" + Bloglista[i][1] + "\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("write a keyword or the title of the blog u wanna search: ");
                        search = Console.ReadLine();
                        for (int i = 0; i > Bloglista.Count; i++)
                        {
                            if (Bloglista[i][0].Contains(search) == true)
                            {
                                Console.WriteLine("Title:\n" + Bloglista[i][0] + "\n");
                                Console.WriteLine("Blog:\n" + Bloglista[i][1] + "\n");
                            }
                        }

                        break;
                    case 4:
                        isRuning= false;
                        break;
                    default:
                        Console.WriteLine("Du måste skriva 1-4");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
