// See https://aka.ms/new-console-template for more information


using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {   //Commentaar voert niet uit dan eerst  // verwijderen om te kunnen aanroepen
            //TheNumbers();
            //Greattranslator();
            //Tellen();
            Blackjack();
            

        }

        static void Blackjack()
        {
            //varriablen declareren
            bool win = false;
            bool lose = false;
            string input;
            var diceroll = 0;
            var score = 0;
            //Random number varriable aanmaken
            var dice = new Random();

            Console.WriteLine("Welcome to blackjack");
            Console.WriteLine("Throw the dice? (y/n)");
            Console.ForegroundColor = ConsoleColor.Black;


            //While () begin van de loop die zich herhaalt tot voldaan aan voorwaarde
            while (score <= 21)
            {
                //Past de input van de key's aan naar type string en altijd lowercase
                input = Console.ReadKey().KeyChar.ToString().ToLower();
                
                Console.WriteLine();
                //Begin van "Als dit dan dat"
                switch (input)
                {
                    //Case altijd beginnen met case en eindigen met break. Vergeet de : niet
                    case "y":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Throwing dice!");
                        //diceroll wordt hier gelijk gezet aan het willekeurige nummer dat voort komt uit dice tss 1 en 7 (1 tem 6 dus)
                        diceroll = dice.Next(1, 7);
                        Console.WriteLine("You throw " + diceroll);
                        score = score + diceroll;
                        Console.WriteLine("You have a total of " + score);
                        Console.ForegroundColor = ConsoleColor.Black;

                        switch (score)
                        {
                            case 20:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("You won");
                                Console.WriteLine();
                                win = true;
                                if (win == true)
                                { 
                                score = 0;
                                }
                                Console.WriteLine("Want to play again? (y/n)");

                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            case 21:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("You've won");
                                Console.WriteLine();
                                win = true;
                                if (win == true)
                                {
                                    score = 0;
                                }
                                Console.WriteLine("Want to play again? (y/n)");
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            case >= 22:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("You have lost");
                                Console.WriteLine();
                                lose = true;
                                if (lose == true)
                                {
                                    score = 0;
                                }
                                Console.WriteLine("Want to play again? (y/n)");
                                Console.ForegroundColor= ConsoleColor.Black;
                                break;

                        }

                        break;
                    case "n":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You have stopped throwing the dice. The game will now shutdown");
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Score op 22 zetten om de loop te stoppen (>21)
                        score = 22;
                        break;
                    default:
                        //Maken dat ze alleen maar y of n kunnen bezigen
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please use y or n");
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                }

                
                

                

            }
            
 }
            
            
            





       
        static void Tellen()
        {
            Console.WriteLine("Optellen en aftellen ");

            for (int i = 20; i >= 0; i--)
            {
                Console.WriteLine(i);
                //Thread.Sleep(500); Dees is leuk voor nen delay - anders NOOIT gebruiken!!!!!!!! Als ge echt wilt: await Task.Delay(500);  <-- bijvoorbeeld
            }
            var y = 0;
            {
                while (y < 10) ;
                Console.WriteLine(y);
                y++;
            }

        }
        static void Gradetranslator()
        {
            Console.WriteLine("The great grader");
            /* var input = Console.ReadLine();
             string E = "Excellent";
             string V = "Very Good";
             string G = "Good";
             string A = "Average";
             string F = "Fail";

             if (input == "E")
             {
                 Console.WriteLine(E);
             }
             else if (input == "V")
             {
                 Console.WriteLine(V);
             }
             else if (input == "G")
             {
                 Console.WriteLine(G);
             }
             else if (input == "A")
             {
                 Console.WriteLine(A);
             }
             else if (input == "F")
             {
                 Console.WriteLine(F);
             }*/
            //Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please give a grade from E to F");
            var input = Console.ReadLine().ToUpper();

            Console.Write("Your grade is ");
            switch (input)
            {
                case "E":
                    Console.WriteLine("Excellent");
                    break;
                case "V":
                    Console.WriteLine("Very good");
                    break;
                case "G":
                    Console.WriteLine("Good");
                    break;
                case "A":
                    Console.WriteLine("Average");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }

        static void TheNumbers()
        {
            //aanmaken var om dan te vergelijken hoeveel characters er zijn en met If else is de if then van VB.net
            Console.WriteLine("Is het even of is het oneven!!?");
            Console.WriteLine("Geef input aub");

            var input = Console.ReadLine()!;

            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"het is ({input.Length}) en dus Even");
            }
            else
            {
                Console.WriteLine($"het is ({input.Length}) en dus oneven");
            }
        }
    }

    class Calculus
    {
        static void calculus(string[] args)
        {
            Console.WriteLine("We gaan optellen");
            Console.WriteLine("Geef aub 2 cijfers op");



            //Input vanaf hier - schrijft volgende 2 lijnen vervolgens achter elkaar
            Console.Write("First number: ");
            var firstNumber = int.Parse(Console.ReadLine() ?? "0");
            // ?? "0" is in dekken dat als er niets wordt meegegeven dat hij eigenlijk 0 als waarde neemt - hij pakt string na int dus geef string mee
            Console.Write("Second number: ");
            var secondNumber = int.Parse(Console.ReadLine() ?? "0");
            //int.parse is om te zetten naar integer
            //hier neem ik het totaal

            /*Console.Write($"{firstNumber} + {secondNumber} = ");
            var totaal = firstNumber + secondNumber;
            Console.WriteLine(totaal);

            Console.Write($"{firstNumber} * {secondNumber} = ");
            totaal = firstNumber * secondNumber;
            Console.WriteLine(totaal);

            Console.Write($"{firstNumber} / {secondNumber} = ");
            totaal = firstNumber / secondNumber; 
            Console.Write(totaal);

            Console.Write($" De rest is ");
            var rest = firstNumber % secondNumber;// % of mod  zorgt dat ik de rest zie en niet het resultaat van de deling
            Console.WriteLine(rest);

            
            Console.Write($"{firstNumber} - {secondNumber} = ");
            totaal = firstNumber - secondNumber;
            Console.WriteLine(totaal); */



            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber} (met rest: {firstNumber % secondNumber})");










        }
    }
}