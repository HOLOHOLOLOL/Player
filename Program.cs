using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    using System;

    public class Player
    {
        public string Name { get; set; }
        public int Time { get; set; }

        public Player(string name, int time)
        {
            Name = name;
            Time = time;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Time: {Time}";
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Enter number of players: ");

            int numberOfPlayers = int.Parse(Console.ReadLine());

            Player[] players = new Player[numberOfPlayers];

            for (int i = 0; i < numberOfPlayers; i++)
            {

                Console.Write("Enter player's name: ");

                string playerName = Console.ReadLine();

                Console.Write("Enter player's time: ");

                int playerTime = int.Parse(Console.ReadLine());

                players[i] = new Player(playerName, playerTime);

            }

            foreach (Player p in players)
            {

                Console.WriteLine($"Player data - {p}");

            }
            Console.ReadKey();
        }  
        
    }
}
