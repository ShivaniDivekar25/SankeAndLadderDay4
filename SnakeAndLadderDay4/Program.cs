namespace SnakeAndLadderDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! to Snake and Ladder Game");
            int position = 0;
            Random random = new Random();       //Creating object random
             
            while(position<100)
            {
                int Dice = random.Next(1, 7);
                int Option = random.Next(1, 4);

                switch (Option)         //Checking for options using switch case
                {
                    case 1:
                        position = position + Dice;     //Updating position
                        if (position > 100)     //Updating to get 100
                            position = 100;
                        Console.WriteLine("The player is got ladder {0} and palyer moves ahead by number Dice value {1} ",Dice, position);
                        break;
                    case 2:
                        position = position - Dice;     //Updating position
                        if (position < 0)       //Condition to get exact 0
                            position = 0;
                        Console.WriteLine("The player is got snake {0} and player moves behind by number Dice value ",Dice, position);
                        break;
                    default:
                        Console.WriteLine(" NO play,{0}.The player stay at same place {1} " ,Dice ,position);
                        break;
                }
            }
        }
    }
}