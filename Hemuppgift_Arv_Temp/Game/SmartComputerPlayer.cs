using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class SmartComputerPlayer : Player
    {
        //Konstruktor
        public SmartComputerPlayer(string userID) : base(userID)
        {
        }
        //Metod
        public override int TakePins(Board board)
        {
            int tempPins = board.GetNoPins(); //hämtar variabel för att kunna göra beräkningar
            int take;

            if (tempPins % 3 == 0) //kollar om det är jämnt delbart med tre, vilket innebär att man inte kan göra ett optimalt val. Då slumpar vi
            {
               
                Random rnd = new Random();
                take = rnd.Next(1, 3);
            }
            else //om det inte är delbart med 3 försöker datorn se till att spelaren ska hamna i ett läge med 3 kvar.
            {
                
                take = tempPins % 3; //sätter resten till värdet.
            }

            Console.WriteLine($"Datorn tar {take} stickor.");
            return take;//returnerar talet
        }
    }

    //D4. Vi effektiviserar och sätter parametrar som ska finnas på de olika spelarna.
    //Den abstrakta metoden tvingar subklasserna att skapa metoden som behöver finnas.
    
}
