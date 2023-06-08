using Guess_the_Number;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomiser = new Random();
            HigherorLower guesser = new HigherorLower();
            int therandomnumber = randomiser.Next(1, 100); // between 1-99
            String userinput = "";
            int usernmber = 0;
            String responses = "";
            bool iswin = false;
            Console.WriteLine("guess a number between 1 and 99, you get 5 tries, I will tell you if you are higher or lower");
            userinput = Console.ReadLine(); //reads what user gives
            usernmber = Convert.ToInt32(userinput);
            Console.WriteLine($"the random number is: {therandomnumber} the user input is {userinput} converted number is {usernmber}");
            for (int i = 0; i<5; i++)
            {
                responses = guesser.whereisthenumber(therandomnumber, usernmber);
                if (responses== "You got it!")
                {
                    Console.WriteLine($"Congrats you guessed the number which was {therandomnumber}");
                    iswin = true;
                    break;
                }
                else if (responses=="Higher")
                {
                    Console.WriteLine($"Your number {usernmber} is Higher than my number {therandomnumber}");
                    Console.WriteLine("try again with another number");
                    userinput = Console.ReadLine();
                    usernmber = Convert.ToInt32(userinput);
                }
                else
                {
                    Console.WriteLine($"Your number {usernmber} is lower than my number {therandomnumber}");
                    Console.WriteLine("try again with another number");
                    userinput = Console.ReadLine();
                    usernmber = Convert.ToInt32(userinput);
                }
            }
            if (iswin==false) 
            {
                Console.WriteLine($"You loose! the number was {therandomnumber}");
            }
            
            Console.ReadLine();

        }
    }
}