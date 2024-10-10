using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {

        public HumanPlayer(string UserID) : base(UserID) 
        { 
        
        }

        public override int TakePins(Board board)
        {
            Console.WriteLine("Välj hur många stickor du vill ta(1 eller 2):");
            
            return Convert.ToInt32(Console.ReadLine());

             
        }
    }
}
