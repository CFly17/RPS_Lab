using System;

namespace Week4_Lab14_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Season 8 of Survivor: Rock Paper Scissors!\n");
            bool goOn = true;
            Rocky r = new Rocky();
            Randa rr = new Randa();
            UserPlayer p = new UserPlayer();
            Console.WriteLine();

            while (goOn == true)
            {
                Console.WriteLine("Who would you like to play against?\n[1] Rocky the Regular\n\tor\n[2] Randa the Ruthless");
                int userSelection = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("You have chosen Rocky as an opponent. Prepare for battle!\n");
                        RPSEnum myResult = p.GenerateRPS();
                        Console.WriteLine($"You have chosen {myResult}.\nAnd now for your opponent...");
                        RPSEnum rockyResult = r.GenerateRPS();
                        Console.WriteLine($"Rocky chose {rockyResult}. What a surprise.");
                        goOn = false;
                        //battle method
                        break;
                    case 2:
                        Console.WriteLine("You have chosen Randa as an opponent. Prepare for battle!\n");
                        RPSEnum myResult2 = p.GenerateRPS();
                        Console.WriteLine($"You have chosen {myResult2}.\nAnd now for your opponent...");
                        RPSEnum randaResult = rr.GenerateRPS();
                        Console.WriteLine($"Randa chose {randaResult}. Bold!");
                        goOn = false;
                        break;
                }
            }
            Console.WriteLine("Would you like to play again? \n[Y]es or [N]o");
            
                //User plays:

            //Console.WriteLine($"Your opponent {Opponent} has chosen {Opponent.Selection}.");

        }
    }
}
