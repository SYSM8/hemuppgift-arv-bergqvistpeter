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
    
        
        
        public void SetUP(int pins) // Startvärdet, metoden sätter det i NoPins.
        {
            NoPins = pins;
        }

        public void TakePins(int takePins) //Metod för att ta minska värdet på stickor
        {
           
                NoPins = NoPins - takePins;
          
            
        }

        public int GetNoPins() // Metod för att visa hur många stickor
        { 
            return NoPins; 
        }
    }
}
