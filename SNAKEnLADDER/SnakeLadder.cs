using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEnLADDER
{
    internal class SnakeLadder
    {
        public int POS = 0;
        public const int WIN_POS = 100;
        
        int DieCountForP1 = 0, DieCountForP2 = 0;
        int PosForP1 = 0, PosForP2 = 0;
        int Position = 0;
        public void Start_SnakenLadder_Game()
        {

            Random random = new Random();
            int player = random.Next(0, 7);

            Random random1 = new Random();
            int option = random1.Next(0, 3);


            Console.WriteLine("Snake And Ladder Game starts....");
            while (DieCountForP1 != WIN_POS && DieCountForP2 != WIN_POS)
            {
                DieCountForP1++;
                switch (option)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("Player stay at the same position");
                        break;

                    case 2:
                        Console.WriteLine("Your current position is : {0}",Position);
                        Console.WriteLine("You got a ladder");
                        if ((Position + player) > 100)
                        {
                            Console.WriteLine("Current position is : {0}" ,Position);
                        }
                        else
                        {
                            Position+=player;
                            Console.WriteLine("Player moves ahead with ladder : {0}", Position);
                        }
                        break;

                    case 3:
                        if (Position > player)
                        {
                            Position-=player;
                        }
                        break;
                }
                PosForP1 = Position;
                Console.WriteLine("player 1 die count : {0} Position : {1}",DieCountForP1,PosForP1);
                DieCountForP2++;
                switch (option)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("Player stay at the same position");
                        break;

                    case 2:
                        Console.WriteLine("Your current position is : {0}", Position);
                        Console.WriteLine("You got a ladder");
                        if ((Position + player) > 100)
                        {
                            Console.WriteLine("Current position is : {0}" ,Position);
                        }
                        else
                        {
                            Position = Position + player;
                            Console.WriteLine("Player ladder moves ahead : {0}",Position);
                        }
                        break;

                    case 3:
                        if (Position > player)
                        {
                            Position = Position - player;
                        }
                        break;
                }
                PosForP2 = Position;
                Console.WriteLine("player 2 die count : {0} Position : {1}",DieCountForP2,PosForP2);
            }
            if (PosForP1 == WIN_POS)
            {
                Console.WriteLine("Player1 won the game, You rolled the die {0} times",DieCountForP1);
            }
            else
            {
                Console.WriteLine("Player2 won the game, You rolled the die {0} times",DieCountForP2);
            }


        }
    }
}
