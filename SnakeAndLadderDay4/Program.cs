namespace SnakeAndLadderDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! to Snake and Ladder Game");
            int position = 0;
            Random random = new Random();       //Creating object random
           // Random random1 = new Random();      //Creating object random

            while(position<=100)
            {
                int Dice = random.Next(1, 7);
                int Option = random.Next(1, 4);

                switch (Option)         //Checking for options using switch case
                {
                    case 1:
                        position = position + Dice;     //Updating position
                        Console.WriteLine("The player moves ahead by number Dice value " + position);
                        break;
                    case 2:
                        position = position - Dice;     //Updating position
                        if (position < 0)       //Condition to get exact 100
                            position = 0;
                        Console.WriteLine("The player moves behind by number Dice value " + position);
                        break;
                    default:
                        Console.WriteLine("The player stay at same place " + position);
                        break;
                }
            }
        }
    }
}