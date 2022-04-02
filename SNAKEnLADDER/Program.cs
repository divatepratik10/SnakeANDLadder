using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEnLADDER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Programme.");

            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.Start_SnakenLadder_Game();

            Console.ReadLine();
        }
    }
}
