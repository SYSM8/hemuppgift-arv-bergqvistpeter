using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
    //Egenskaper
       public int NoPins {  get; set; }
        
    //Konstruktor
    public Board() { }
    
    //Metoder
    
        
        
        public void SetUP(int pins) 
        {
            NoPins = pins;
        }

        public void TakePins(int takePins) 
        {
           
                NoPins = NoPins - takePins;
          
            
        }

        public int GetNoPins() 
        { 
            return NoPins; 
        }
    }
}
