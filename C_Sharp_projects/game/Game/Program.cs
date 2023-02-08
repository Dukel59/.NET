using System;

namespace Game
{
    class Program
    {
        public static bool WinCondition(int you, int pc, string[] arg)
        {
            bool win = true;
            if ((arg.Length / 2) > you)
            {
                for (int i = you + 1; i <= (you + arg.Length / 2); i++)
                {
                    if (arg[i] == arg[pc])
                    {
                        win = false;
                        return win;
                    }
                }
            }
            else
            {
                for (int i = you-1; i >= (you - arg.Length/2); i--)
                {
                    if(arg[i] == arg[pc])
                    {
                        return win;
                    }
                }
                win = false;
            }
            return win;
        }
        static void Main(string[] args)
        {
            string[] arg = { "ROCK", "PAPPER", "SCISSORS", "LIZARD", "SPOCK" };
            if (arg.Length < 3 || (arg.Length % 2 == 0))
            {
                Console.WriteLine("Enter more args");
            }
            else
            {
                for (int i = 0; i < arg.Length; i++)
                {
                    for (int j = 1+i; j < arg.Length; j++)
                    {
                        if (arg[i].ToLower() == arg[j].ToLower())
                            Console.WriteLine("Not Uniq args");
                    }
                }
            }
            for (int i = 0; i < arg.Length; i++)
            {
                Console.WriteLine($"{i+1} - {arg[i]}");
            }
            Console.Write("Enter your move: ");
            int move = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine($"Your move: {arg[move]}");

            Random rand = new Random();
            int movePC = rand.Next(0, arg.Length-1);
            Console.WriteLine($"Computer move: {arg[movePC]}");

            if(WinCondition(move, movePC, arg))
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("You lose");
            }

        }


        //public void Menu (string[] arg)
        //{
        //    for (int i = 0; i < arg.Length; i++)
        //    {
        //        Console.WriteLine($"{i} - {arg[i]}");
        //    }
        //    Console.Write("Enter your move: ");
        //    int move = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($"Your move: {arg[move]}");
        //}
    }
}
