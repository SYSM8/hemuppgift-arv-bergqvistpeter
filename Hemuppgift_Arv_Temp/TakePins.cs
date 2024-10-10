using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            // Fråga F2 a) Det är en basklass. F2 b) alternativ 2 och 3.

            Player player1 = new HumanPlayer("Peter");
            Player player2 = new SmartComputerPlayer("Computer");
            Board board = new Board();

            //Väljer hur många stickor spelet ska innehålla
            Console.WriteLine("Välj antal stickor för spel partiet mellan 10 och 100: ");
            int sticks = Convert.ToInt32(Console.ReadLine());
            while (sticks < 10 || sticks > 100) //Väljer fram till det att man valt en siffra mellan 10 och 100
            {
                Console.WriteLine("Felaktigt val! Välj antal stickor för spel partiet mellan 10 och 100: ");
                sticks = Convert.ToInt32(Console.ReadLine());
            }
            board.SetUP(sticks); // sätter antalet sticks

            while (board.GetNoPins() > 0) //körs så länge antalet stickor är mer än 0
            {
                board.TakePins(player1.TakePins(board)); //anropar metod som drar bort stickor

                Console.WriteLine($"{board.GetNoPins()} finns kvar"); //Skriver ut hur många stickor som finns kvar 

                if (board.GetNoPins() <= 0) // om man når 0 eller lägra så vinner spelare 1
                {
                    Console.WriteLine($"{player1.UserID} vann! Grattis!");
                    break;
                }

                board.TakePins(player2.TakePins(board)); // Anropar metod som drar bort stickor
                Console.WriteLine($"{board.GetNoPins()} finns kvar"); //Skriver ut hur många stickor som finns kvar 

                if (board.GetNoPins() <= 0) // om man når 0 eller lägra så vinner spelare 1
                {
                    Console.WriteLine($"{player2.UserID} vann! Grattis!");
                    break;
                }
            }

        }

    }
}
