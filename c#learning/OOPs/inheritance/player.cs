using System;

namespace csharplearning
{
    class GameObject
    {
        public string gameName;

        public void getGame()
        {
            Console.Write("Enter game name: ");
            gameName = Console.ReadLine();
        }

        public void displayGame()
        {
            Console.WriteLine("Game: " + gameName);
        }
    }

    class Player : GameObject
    {
        public string playerName;

        public void getPlayer()
        {
            Console.Write("Enter player name: ");
            playerName = Console.ReadLine();
        }

        public void displayPlayer()
        {
            Console.WriteLine("Player: " + playerName);
        }
    }

    class ProPlayer : Player
    {
        public int level;
        public int score;

        public void getProPlayer()
        {
            Console.Write("Enter level: ");
            level = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter score: ");
            score = Convert.ToInt32(Console.ReadLine());
        }

        public void displayProPlayer()
        {
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Score: " + score);
        }
    }

    class Program
    {
        static void Main()
        {
            ProPlayer p = new ProPlayer();

            p.getGame();
            p.getPlayer();
            p.getProPlayer();

            Console.WriteLine("\n--- PLAYER DETAILS ---");

            p.displayGame();
            p.displayPlayer();
            p.displayProPlayer();
        }
    }
}