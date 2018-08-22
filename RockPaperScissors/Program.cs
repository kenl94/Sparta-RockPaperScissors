using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            Console.WriteLine("enter name");
            Player player = new Player();
            Console.WriteLine(player.rPS);
            Console.ReadLine();
        }
    }
}