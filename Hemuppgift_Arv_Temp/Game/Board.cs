using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
    //Egenskaper
       public int noPins {  get; set; }
        
    //Konstruktor
    public Board() { }
    
    //Metoder
    
        
        
        public void SetUP(int pins) 
        {
            noPins = pins;
        }

        public void TakePins(int takePins) 
        {
            noPins =- takePins;
        }

        public int GetNoPins() 
        { 
            return noPins; 
        }
    }
}
