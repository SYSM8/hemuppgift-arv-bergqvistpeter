using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
    //egenskaper
     public string UserID { get; set; }
        //Konstruktor

        public Player(string userID) 
        { 
            this.UserID = userID;
        }
        //Metod

        public string GetUserID() 
        
        { 
            return UserID;
        }

        public abstract int TakePins(Board board);

        
    }
}
