namespace SnakeAndLadderDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! to Snake and Ladder Game");
            int position = 0;       //Position Initializin
            Random random = new Random();       //Creating object random
            int Dice = random.Next(1, 7);       // Using random method 
            Console.WriteLine("The postition of player starts: {0} and random number of Dice: {1}",position, Dice);
            Random random1 = new Random();      //Creating object random
            int option = random1.Next(1, 4);        //Using random method

            switch (option)         //Checking for options using switch case
            {
                case 1:
                    position = position + Dice;
                    Console.WriteLine("The player moves ahead by number Dice value " + position);
                    break;
                case 2:
                    position = position - Dice;
                    Console.WriteLine("The player moves behind by number Dice value " + position);
                    break;
                default:
                    Console.WriteLine("The player stay at same place " + position);
                    break;
            }
        }
    }
}