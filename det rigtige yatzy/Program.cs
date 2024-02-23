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


//selve spillet kigge på regler, holde terninger, opdater scoreboard


//15 ture afslut, implementer bonuser