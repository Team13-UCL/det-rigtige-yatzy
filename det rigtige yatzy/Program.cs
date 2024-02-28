using System.Threading.Channels;
using System;

namespace det_rigtige_yatzy
{
    internal class Program
    {
        static int Terning1, Terning2, Terning3, Terning4, Terning5, currentPlayerTal, runde, Kast, ettere, toere, treer, firer, femmere, seksere, etpar, topar, treens, fireens, hus, denlille, denstore, chance, yatzy;
        static bool IsTerning1Locked, IsTerning2Locked, IsTerning3Locked, IsTerning4Locked, IsTerning5Locked;
        static String spiller1, spiller2, spiller3, spiller4;
        static string[] SpillerNavn;
        static int totalPoints = ettere + toere + treer + firer + femmere + seksere + etpar + topar + treens + fireens + hus + denlille + denstore + chance + yatzy;


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
                    SpillerNavn = new string[2];
                    SpillerNavn[0] = Console.ReadLine();
                    spiller1 = SpillerNavn[0];
                    Console.WriteLine("Indtast navn på spiller 2:");
                    SpillerNavn[1] = Console.ReadLine();
                    spiller2 = SpillerNavn[1];
                    break;
                case 3:
                    // Anmodning om navne på tre spillere, hvis tre spillere er valgt
                    Console.WriteLine("Indtast navn på spiller 1:");
                    SpillerNavn = new string[3];
                    SpillerNavn[0] = Console.ReadLine();
                    spiller1 = SpillerNavn[0];
                    Console.WriteLine("Indtast navn på spiller 2:");
                    SpillerNavn[1] = Console.ReadLine();
                    spiller2 = SpillerNavn[1];
                    Console.WriteLine("Indtast navn på spiller 3:");
                    SpillerNavn[2] = Console.ReadLine();
                    spiller3 = SpillerNavn[2];
                    break;
                case 4:
                    // Anmodning om navne på fire spillere, hvis fire spillere er valgt
                    Console.WriteLine("Indtast navn på spiller 1:");
                    SpillerNavn = new string[4];
                    SpillerNavn[0] = Console.ReadLine();
                    spiller1 = SpillerNavn[0];
                    Console.WriteLine("Indtast navn på spiller 2:");
                    SpillerNavn[1] = Console.ReadLine();
                    spiller2 = SpillerNavn[1];
                    Console.WriteLine("Indtast navn på spiller 3:");
                    SpillerNavn[2] = Console.ReadLine();
                    spiller3 = SpillerNavn[2];
                    Console.WriteLine("Indtast navn på spiller 4:");
                    SpillerNavn[3] = Console.ReadLine();
                    spiller4 = SpillerNavn[3];
                    break;

                default:
                    Console.WriteLine("Du en Skovl! Prøv igen :D ");
                    goto repeat;


            }
            
            //viser scoreboard
            scoreboard();

            
            for (runde = 0; runde < 16; runde++) //kører i 15 runder
            {
                //clear og viser opdateret scoreboard
                Console.Clear();
                scoreboard();

                while (currentPlayerTal < SpillerNavn.Length) // så længe at current spillere er mindre end indexlængden på arrayen
                {
                    
                    //unødvendigt fordi de er standard false og 0 åbenbart, men er fint til at forstå hvad der sker
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

                        // Man kan også bruge ''if (Console.ReadKey().Key == ConsoleKey.K)'' Hvis man bare vil bruge en knap istedet for at skrive noget
                        string userInput = Console.ReadLine();
                        if (userInput == "Kast" || userInput == "kast")
                        {
                            KastTerninger();

                            // Skriver terningernes tal ud
                            Console.WriteLine($"Kast {Kast}: {Terning1} {Terning2} {Terning3} {Terning4} {Terning5}\n"); // Viser at terningen er låst

                            Console.WriteLine($"Du har brugt {Kast} slag\n");
                        }
                        else if (userInput.Equals("Lås", StringComparison.OrdinalIgnoreCase))
                        {
                            // Spørg om du vil låse din terning eller kaste igen
                            Console.WriteLine("Skriv tallet på den terning du gerne vil låse [1-5]:\n");
                            int terningNummer = int.Parse(Console.ReadLine());
                            LåsTerning(terningNummer);
                        }
                    }


                    //sumafTerning method bruges til at beregne summen af øjnene for hver terning og for hver mulig værdi fra 1 til 6. og gemmes i sum variabler
                    int sum1 = SumAfTerning(1, Terning1, Terning2, Terning3, Terning4, Terning5);
                    int sum2 = SumAfTerning(2, Terning1, Terning2, Terning3, Terning4, Terning5);
                    int sum3 = SumAfTerning(3, Terning1, Terning2, Terning3, Terning4, Terning5);
                    int sum4 = SumAfTerning(4, Terning1, Terning2, Terning3, Terning4, Terning5);
                    int sum5 = SumAfTerning(5, Terning1, Terning2, Terning3, Terning4, Terning5);
                    int sum6 = SumAfTerning(6, Terning1, Terning2, Terning3, Terning4, Terning5);



                    //clear console
                    Console.Clear();

                    //Scoreboardet som er i en method
                    scoreboard();

                    Console.WriteLine("skriv bogstavet på pladsen du vil ligge dem ind på");
                    String bogstav = Console.ReadLine();


                    //REGLER:

                    //ettere 
                    if (bogstav == "A")
                    {
                        ettere = sum1 * 1;
                    }

                    //toere 
                    if (bogstav == "B")
                    {
                        toere = sum2 * 2;
                    }

                    //treer 
                    if (bogstav == "C")
                    {
                        treer = sum3 * 3;
                    }

                    //firer 
                    if (bogstav == "D")
                    {
                        firer = sum4 * 4;
                    }

                    //femmere 
                    if (bogstav == "E")
                    {
                        femmere = sum5 * 5;
                    }

                    //seksere 
                    if (bogstav == "F")
                    {
                        seksere = sum6 * 6;
                    }

                    //etpar 
                    if (bogstav == "G")
                    {
                        for (int i = 6; i > 0; i--)
                        {
                            if (SumAfTerning(i, Terning1, Terning2, Terning3, Terning4, Terning5) >= 2)
                            {
                                etpar = 2 * i;
                                break;
                            }
                        }
                    }

                    //topar 
                    if (bogstav == "H")
                    {
                        int antalPar = 0;
                        for (int i = 6; i > 0; i--)
                        {
                            if (SumAfTerning(i, Terning1, Terning2, Terning3, Terning4, Terning5) >= 2)
                            {
                                topar += 2 * i;
                                antalPar++;
                            }
                            if (antalPar == 2)
                                break;
                        }
                    }


                    //treens 
                    if (bogstav == "I")
                    {
                        for (int i = 6; i > 0; i--)
                        {
                            if (SumAfTerning(i, Terning1, Terning2, Terning3, Terning4, Terning5) >= 3)
                            {
                                treens = 3 * i;
                                break;
                            }
                        }
                    }


                    //fireens 
                    if (bogstav == "J")
                    {
                        for (int i = 6; i > 0; i--)
                        {
                            if (SumAfTerning(i, Terning1, Terning2, Terning3, Terning4, Terning5) >= 4)
                            {
                                fireens = 4 * i;
                                break;
                            }
                        }
                    }


                    //hus 
                    if (bogstav == "K")
                    {
                        int antalPars = 0;
                        bool par = false;
                        bool treafdesamme = false;
                        for (int i = 6; i > 0; i--)
                        {
                            if (SumAfTerning(i, Terning1, Terning2, Terning3, Terning4, Terning5) >= 2)
                            {
                                topar += 2 * i;
                                antalPars++;
                            }
                            if (antalPars == 2)
                                par = true;

                        }
                        for (int i = 6; i > 0; i--)
                        {
                            if (SumAfTerning(i, Terning1, Terning2, Terning3, Terning4, Terning5) >= 3)
                            {
                                treafdesamme = true;
                                break;
                            }
                        }

                        if (treafdesamme && par)
                        {
                            hus = Terning1 + Terning2 + Terning3 + Terning4 + Terning5;
                        }
                        else
                        {
                            hus = 0; //skriv 0 hvis der ikke er hus
                        }
                    }

                    //denlille DONE men man kan snyde
                    if (bogstav == "L")
                    {
                        denlille = 15;
                    }

                    //denstore DONE men man kan snyde
                    if (bogstav == "M")
                    {
                        denstore = 20;
                    }
                    //chancen 
                    if (bogstav == "N")
                    {
                        chance = (sum1 * 1) + (sum2 * 2) + (sum3 * 3) + (sum4 * 4) + (sum5 * 5) + (sum6 * 6);
                    }

                    //Yatzy DONE men man kan snyde
                    if (bogstav == "O")
                    {
                        yatzy = 50;
                    }

                    //clear og viser opdateret scoreboard
                    Console.Clear();
                    scoreboard();


                    currentPlayerTal++;
                    if (currentPlayerTal >= SpillerNavn.Length)
                    {
                        currentPlayerTal = 0;
                        break;
                    }
                    Console.WriteLine($"{SpillerNavn[currentPlayerTal]}, det er din tur.");
                }
            }
            if (runde == 16)
            {
                // Holder styr på den højeste score, start værdien er sat til 0 indtil der bliver fundet højere
                int maximumPoints = 0;
                // Holder navn på videren
                string Vinderen = "";

                // Dette er en løkke som går igennem alle vores spillere og holder styr på dem
                for (int i = 0; i < SpillerNavn.Length; i++)
                {
                    //Tager vores totalpoints fra hver spiller og finder ud af hvem der har mest og så viser navnet
                    int currentPlayerPoints = totalPoints[SpillerNavn[i]];
                    if (currentPlayerPoints > maximumPoints)
                    {
                        maximumPoints = currentPlayerPoints;
                        Vinderen = SpillerNavn[i];
                    }
                }

                Console.WriteLine($"Tillykke til vinderen, {Vinderen}, med {maximumPoints} points!");

                switch (SpillerNavn.Length)
                {
                    case 2:
                        Console.WriteLine($"Tillykke {SpillerNavn[0]} du har fået {totalPoints[SpillerNavn[0]]} points:");
                        Console.ReadLine();
                        Console.WriteLine($"Tillykke {SpillerNavn[1]} du har fået {totalPoints[SpillerNavn[1]]} points:");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine($"Tillykke {SpillerNavn[0]} du har fået {totalPoints[SpillerNavn[0]]} points:");
                        Console.ReadLine();
                        Console.WriteLine($"Tillykke {SpillerNavn[1]} du har fået {totalPoints[SpillerNavn[1]]} points:");
                        Console.ReadLine();
                        Console.WriteLine($"Tillykke {SpillerNavn[2]} du har fået {totalPoints[SpillerNavn[2]]} points:");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine($"Tillykke {SpillerNavn[0]} du har fået {totalPoints[SpillerNavn[0]]} points:");
                        Console.ReadLine();
                        Console.WriteLine($"Tillykke {SpillerNavn[1]} du har fået {totalPoints[SpillerNavn[1]]} points:");
                        Console.ReadLine();
                        Console.WriteLine($"Tillykke {SpillerNavn[2]} du har fået {totalPoints[SpillerNavn[2]]} points:");
                        Console.ReadLine();
                        Console.WriteLine($"Tillykke {SpillerNavn[3]} du har fået {totalPoints[SpillerNavn[3]]} points:");
                        Console.ReadLine();
                        break;
                }
            }










            //////////////////////////ALLE METHODS////////////////////////
            static int SumAfTerning(int eyes, int t1, int t2, int t3, int t4, int t5)
            {
                int r = 0;
                if (eyes == t1) r++;

                if (eyes == t2) r++;

                if (eyes == t3) r++;

                if (eyes == t4) r++;

                if (eyes == t5) r++;

                return r;
            }

            static void KastTerninger()
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

            static void LåsTerning(int DiceNumber) //TO-DO Lås terningen
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

            static void scoreboard()
            {
                //Scoreboardet
                Console.WriteLine($"Y A H T Z Y    \t\t\t\t   Players: \t\t    1:, 2:, 3:, 4:");
                Console.WriteLine($"Player 1:{spiller1} Player 2:{spiller2} Player 3:{spiller3} Player 4:{spiller4} \t\t Runde: {runde}");
                Console.WriteLine($"\t\t\t\t\t\t\t A-1--------{ettere}");
                Console.WriteLine($"\t\t\t\t\t\t\t B-2--------{toere}");
                Console.WriteLine($"\t\t\t\t\t\t\t C-3--------{treer}");
                Console.WriteLine($"\t\t\t\t\t\t\t D-4--------{firer}");
                Console.WriteLine($"\t\t\t\t\t\t\t E-5--------{femmere}");
                Console.WriteLine($"\t\t\t\t\t\t\t F-6--------{seksere}");
                Console.WriteLine($"\t\t\t\t\t\t\t G-etpar----{etpar}");
                Console.WriteLine($"\t\t\t\t\t\t\t H-topar----{topar}");
                Console.WriteLine($"\t\t\t\t\t\t\t I-treens---{treens}");
                Console.WriteLine($"\t\t\t\t\t\t\t J-fireens--{fireens}");
                Console.WriteLine($"\t\t\t\t\t\t\t K-Hus------{hus}");
                Console.WriteLine($"\t\t\t\t\t\t\t L-denlille-{denlille}");
                Console.WriteLine($"\t\t\t\t\t\t\t M-denstore-{denstore}");
                Console.WriteLine($"\t\t\t\t\t\t\t N-chance---{chance}");
                Console.WriteLine($"\t\t\t\t\t\t\t O-yatzy----{yatzy}");
                Console.WriteLine($"{SpillerNavn[currentPlayerTal]}, Det Er Din tur.");
                Console.WriteLine($"Dit terningslag {Terning1}, {Terning2}, {Terning3}, {Terning4}, {Terning5}\t\t\t du har brugt {Kast} slag");
                         
            }

            
        }
    }
}

//antal spillere med navn = ✓
//scoreboard ses hele tiden = ✓
//terningen = ✓
//holde terninger = ✓
//selve spillets gang = ✓
//kigge på reglerne og opdater scoreboard= ✓
//15 runder, med alle spillere = ✓
// KÆMPE PROBLEM, lige pt er det kun player 1 der kan få point...
//afslut, implementer bonuser
//skrive noter til alting