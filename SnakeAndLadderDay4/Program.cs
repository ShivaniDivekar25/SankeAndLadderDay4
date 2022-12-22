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
        }
    }
}