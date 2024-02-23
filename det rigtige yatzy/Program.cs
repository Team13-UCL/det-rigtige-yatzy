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