using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player
    {   //Konstruktor
        public ComputerPlayer(string userID) : base(userID)
        {
        }
        //Metod som överskriver base. 
        public override int TakePins(Board board)
        {


            Random rnd = new Random();
            int temp = rnd.Next(1, 3);
            Console.WriteLine($"Datorns valde {temp} stickor");
            return temp;


        }
    }
}
