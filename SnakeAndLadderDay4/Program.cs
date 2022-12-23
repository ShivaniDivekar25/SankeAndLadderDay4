namespace SnakeAndLadderDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player one");      //Taking user input for player1
            string playerOne = Console.ReadLine();
            Console.WriteLine("Enter player two");      //Taking user input for player2
            string playerTwo = Console.ReadLine();

            int playerOnePosi = 0, playerTwoPosi = 0,count = 0;    //Initializing value
            bool playerTurn = true;

            Random random = new Random();       //Creating object for dice 
            Random random1 = new Random();      //Creating object for switch case conditions

            while (playerOnePosi < 100 && playerTwoPosi < 100)        //While loop for conditions required for both player
            {
                int option = random1.Next(1, 4);        //Using random method for Swich case
                int Dice = random.Next(1, 7);           //Using random method for Dice
                if (playerTurn==true)        //Condition to get alternate turn of each player 
                {
                    if (playerOnePosi < 100)        //For player one to play
                    {
                        count = count + 1;

                        switch (option)         //Checking for options using switch case
                        {
                            case 1:
                                playerOnePosi = playerOnePosi + Dice;       //Updating position
                                if (playerOnePosi > 100)            //Updating to get 100
                                    playerOnePosi = 100;
                                Console.WriteLine("The player1 moves ahead by number Dice value " + playerOnePosi);
                                if(playerOnePosi==100)
                                    Console.WriteLine("{0} is Winner!",playerOne);
                                playerTurn = true;
                                break;
                            case 2:
                                playerOnePosi = playerOnePosi - Dice;       //Updating position
                                if (playerOnePosi < 0)          //Upadating to get 0
                                    playerOnePosi = 0;
                                Console.WriteLine("The player1 moves behind by number Dice value " + playerOnePosi);
                                playerTurn = false;
                                break;
                            default:
                                Console.WriteLine("The player1 remain at same place " + playerOnePosi);
                                playerTurn = false;
                                break;
                        }
                    }

                }
                else
                {
                    if (playerTwoPosi < 100)        //For player two to play
                    {
                        count = count + 1;

                        switch (option)         //Checking for options using switch case
                        {
                            case 1:
                                playerTwoPosi = playerTwoPosi + Dice;       //Updating position
                                if (playerTwoPosi > 100)            //Updating to get 100
                                    playerTwoPosi = 100;
                                Console.WriteLine("The player2 moves ahead by number Dice value " + playerTwoPosi);
                                if(playerTwoPosi==100)
                                    Console.WriteLine("{0} is Winner"!,playerTwo);
                                playerTurn = false;
                                break;
                            case 2:
                                playerTwoPosi = playerTwoPosi - Dice;       //Updating position
                                if (playerTwoPosi < 0)          //Updating to get 0
                                    playerTwoPosi = 0;
                                Console.WriteLine("The player2 moves behind by number Dice value " + playerTwoPosi);
                                playerTurn = true;
                                break;
                            default:
                                Console.WriteLine("The player2 remain at same place " + playerTwoPosi);
                                playerTurn = true;
                                break;
                        }
                    }
                }
            }
            Console.WriteLine("{0} times the dice was played to win the game ", count);         //To count number of to times dice rolled to get Win position.
        }
    }
}