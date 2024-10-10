using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string userID) : base(userID)
        {
        }

        public override int TakePins(Board board)
        {
            Console.WriteLine("Datorns tur");

            Random rnd = new Random();
            int temp = rnd.Next(1, 3);

            return temp;
            

        }

    }
}
