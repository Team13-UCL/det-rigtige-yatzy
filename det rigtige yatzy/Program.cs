namespace det_rigtige_yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Velkomstbesked
            Console.WriteLine("Velkommen til TEAM 13 Yahtzy");
            Console.WriteLine("");

        //goto
        repeat:

            // Anmodning om antal spillere
            Console.WriteLine("Indtast antal spillere (2-4)");

            // Læs antallet af spillere fra brugeren
            String antal = Console.ReadLine();
            int valgtetal = int.Parse(antal);

            //spillernavne
            String spiller1 = "";
            String spiller2 = "";
            String spiller3 = "";
            String spiller4 = "";


            // Switch-sætning baseret på antal spillere
            switch (valgtetal)
            {
                case 1:
                    // Besked om for få spillere, hvis kun én spiller er valgt
                    Console.WriteLine("Ikke nok spillere");
                    break;
                case 2:
                    // Anmodning om navne på to spillere, hvis to spillere er valgt
                    Console.WriteLine("Indtast navn på spiller 1:");
                    spiller1 = Console.ReadLine();
                    Console.WriteLine("Indtast navn på spiller 2:");
                    spiller2 = Console.ReadLine();
                    break;
                case 3:
                    // Anmodning om navne på tre spillere, hvis tre spillere er valgt
                    Console.WriteLine("Indtast navn på spiller 1:");
                    spiller1 = Console.ReadLine();
                    Console.WriteLine("Indtast navn på spiller 2:");
                    spiller2 = Console.ReadLine();
                    Console.WriteLine("Indtast navn på spiller 3:");
                    spiller3 = Console.ReadLine();
                    break;
                case 4:
                    // Anmodning om navne på fire spillere, hvis fire spillere er valgt
                    Console.WriteLine("Indtast navn på spiller 1:");
                    spiller1 = Console.ReadLine();
                    Console.WriteLine("Indtast navn på spiller 2:");
                    spiller2 = Console.ReadLine();
                    Console.WriteLine("Indtast navn på spiller 3:");
                    spiller3 = Console.ReadLine();
                    Console.WriteLine("Indtast navn på spiller 4:");
                    spiller4 = Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Du en Skovl! Prøv igen :D ");
                    goto repeat;


            }

            static int Terning1, Terning2, Terning3, Terning4, Terning5;
            static bool IsTerning1Locked, IsTerning2Locked, IsTerning3Locked, IsTerning4Locked, IsTerning5Locked;
            static int Kast;

            // Tjekker om vores terning er locked og vores Kast som senere max er 3
            static void Main(string[] args)
            {
                IsTerning1Locked = false;
                IsTerning2Locked = false;
                IsTerning3Locked = false;
                IsTerning4Locked = false;
                IsTerning5Locked = false;
                Kast = 0;

                while (Kast < 3)
                {
                    if (Kast == 0)
                    {
                        Console.WriteLine("Skriv kast for at slå\n");
                    }
                    else
                    {
                        // Spørg om du vil låse din terning eller kaste igen
                        Console.WriteLine("Skriv Kast for at slå med terningerne igen eller skriv lås tallet på den terning du gerne vil låse 1-5\n");
                    }

                    // Man kan også bruge ''if (Console.ReadKey().Key == ConsoleKey.S)'' Hvis man bare vil bruge en knap istedet for at skrive noget
                    string userInput = Console.ReadLine();
                    if (userInput == "Kast" || userInput == "kast")
                    {
                        KastTerninger();

                        // Skriver terningernes tal ud
                        Console.WriteLine($"Kast {Kast}: {Terning1} {Terning2} {Terning3} {Terning4} {Terning5}\n"); // Viser at terningen er låst

                        Console.WriteLine($"Du har brugt {Kast} slag\n");
                    }
                    else if (userInput == "Lås" || userInput == "lås")
                    {
                        // Spørg om du vil låse din terning eller kaste igen
                        Console.WriteLine("Skriv tallet på den terning du gerne vil låse [1-5]:\n");
                        int terningNummer = int.Parse(Console.ReadLine());
                        LåsTerning(terningNummer);
                    }
                }
            }

            private static void KastTerninger()
            {
                Random r = new Random();

                //TO-DO tjek om terningen er låst inden den får en ny værdi
                if (!IsTerning1Locked)
                {
                    Terning1 = r.Next(1, 7);
                }
                if (!IsTerning2Locked)
                {
                    Terning2 = r.Next(1, 7);
                }
                if (!IsTerning3Locked)
                {
                    Terning3 = r.Next(1, 7);
                }
                if (!IsTerning4Locked)
                {
                    Terning4 = r.Next(1, 7);
                }
                if (!IsTerning5Locked)
                {
                    Terning5 = r.Next(1, 7);
                }

                Kast++;
            }

            private static void LåsTerning(int DiceNumber) //TO-DO Lås terningen
            {
                if (DiceNumber == 1)
                {
                    IsTerning1Locked = true;
                }
                else if (DiceNumber == 2)
                {
                    IsTerning2Locked = true;
                }
                else if (DiceNumber == 3)
                {
                    IsTerning3Locked = true;
                }
                else if (DiceNumber == 4)
                {
                    IsTerning4Locked = true;
                }
                else if (DiceNumber == 5)
                {
                    IsTerning5Locked = true;
                }
                else
                {
                    Console.WriteLine("\nUgyldigt terningnummer hvorfor prøver du ikke igen lille idiot? :)");
                }
            }




            // scoreboard 1. udkast 
            Console.Clear();

            int ettere = 0;
            int toere = 0;
            int treer = 0;
            int firer = 0;
            int femmere = 0;
            int seksere = 0;
            int treafenslags = 0;
            int fireafenslags = 0;
            int hus = 0;
            int denlille = 0;
            int denstore = 0;
            int chance = 0;
            int yatzy = 0;
            


            //Scoreboardet
            Console.WriteLine($"Y A H T Z E E \t\t\t\t\t\t\t\t Players: \t  1:, 2:, 3:, 4:");
            Console.WriteLine($"Player 1:{spiller1}    Player 2:{spiller2}    Player 3:{spiller3}    Player 4:{spiller4}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t 1----------------{ettere}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t 2----------------{toere}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t 3----------------{treer}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t 4----------------{firer}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t 5----------------{femmere}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t 6----------------{seksere}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t tre af en slags--{treafenslags}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t fire af en slags-{fireafenslags}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t Hus--------------{hus}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t denlille---------{denlille}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t denstore---------{denstore}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t chance-----------{chance}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t yatzy------------{yatzy}");
            Console.WriteLine($"{spiller1}, tur");
            Console.WriteLine($"Dit terningslag {Terning1}, {Terning2}, {Terning3}, {Terning4}, {Terning5}\t\t\t antal kast:{Kast}");
        }
    }
}

//antal spillere med navn = ✓
//scoreboard ses hele tiden = ✓
//terningen = ✓
//holde terninger = ✓
//selve spillets gang
//kigge på reglerne og opdater scoreboard
//15 ture afslut, implementer bonuser