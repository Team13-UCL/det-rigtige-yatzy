namespace det_rigtige_yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start besked
            Console.WriteLine("TEAM 13 Yahtzee!");

            // Brugerinput (Antal a spillere)
            Console.WriteLine("Hvor mange skal spille?");
            int numPlayers = int.Parse(Console.ReadLine());

            // Liste med spillernavne
            List<Player> players = new List<Player>();

            // Loop for at få spillernes navne
            for (int i = 0; i < numPlayers; i++)
            {
                // Indtast spillernavne
                Console.WriteLine($"Indtast spillernavn {i + 1}:");
                string playerName = Console.ReadLine();

                // Gør det nye spillernavn til et opjekt
                players.Add(new Player(playerName));
            }




            // scoreboard 1. udkast prøv at kør det for sig selv, og se om det er den retning det skal være
            Console.WriteLine("skriv navn:");
            string playername1 = Console.ReadLine();
            string playername2 = Console.ReadLine();
            string playername3 = Console.ReadLine();
            string playername4 = Console.ReadLine();

            Console.Clear();

            int ettere = 4;
            int toere = 2;
            int treer = 9;
            int firer = 16;
            int femmere = 15;
            int seksere = 18;
            int treafenslags = 6;
            int fireafenslags = 12;
            int hus = 0;
            int denlille = 0;
            int denstore = 0;
            int chance = 0;
            int yatzy = 0;
            int t1 = 3;
            int t2 = 4;
            int t3 = 2;
            int t4 = 6;
            int t5 = 2;
            int antalslag = 3;


            //Scoreboardet
            Console.WriteLine($"Y A H T Z E E \t\t\t\t\t\t\t\t Players: \t  1:, 2, 3, 4");
            Console.WriteLine($"Player 1:{playername1}    Player 2:{playername2}    Player 3:{playername3}    Player 4:{playername4}");
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
            Console.WriteLine($"{playername1}, tur");
            Console.WriteLine($"Dit terningslag {t1}, {t2}, {t3}, {t4}, {t5}\t\t\t slag tilbage:{antalslag}");

        }
    }

    internal class Player
    {
        private string? playerName;

        public Player(string? playerName)
        {
            this.playerName = playerName;
        }
    }

    internal class YahtzeeGame
    {
        private List<Player> players;

        public YahtzeeGame(List<Player> players)
        {
            this.players = players;
        }
    }
}

//antal spillere med navn

//scoreboard ses hele tiden

//terningen
{
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
                // Sp'rg om du vil l[se din terning eller kaste igen
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
}

}

//selve spillet kigge på regler, holde terninger, opdater scoreboard


//15 ture afslut, implementer bonuser