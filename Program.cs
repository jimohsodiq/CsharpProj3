using System;

namespace CsharpProj3
{
    class Program
    {
        static void Main(string[] args)
{
            Random randoms = new Random();
            int randomNumber;
            
            var guess = 0;
            var chances = 0;
            var levels = "";
            var Result = "";
            int x = 25;
            int choose = 0;
            Console.WriteLine("Pls enter your guess number");
            choose = int.Parse(Console.ReadLine());
            if(choose==x){
                Console.WriteLine("You guessed right");
            }
            else{
            Console.WriteLine("You guessed wrong");
            Console.WriteLine("Now you have to choose between three levels");
            Console.WriteLine("Press 1 for easy");
            Console.WriteLine("Press 2 for medium");
            Console.WriteLine("Press 3 for hard");
            }
            
           
            int Inputs = int.Parse(Console.ReadLine());

            if (Inputs == 1)
            {
                levels = "Easy";
            }
            else if (Inputs == 2)
            {
                levels = "Medium";
            }
            else if (Inputs == 3)
            {
                levels = "Hard";
            }
            else
            {
                Result = "Game Over";
            }

            if(levels=="Easy"){
                randomNumber = randoms.Next(1,11);
                chances = 6;
                System.Console.WriteLine(guesses(1,10,chances,randomNumber,guess));
                }
                else if(levels == "Medium"){
                randomNumber = randoms.Next(1,21);
                chances = 4;
                System.Console.WriteLine(guesses(1,20,chances,randomNumber,guess));
                }
                else if(levels == "Hard"){
                randomNumber = randoms.Next(1,51);
                chances = 3;
                System.Console.WriteLine(guesses(1,50,chances,randomNumber,guess));
                }
                 Console.WriteLine(Result);
    }
    private static string guesses(int minVal, int maxVal, int Chances, int RandomNumber, int Guesses) {
        string Output = "";
            while (Guesses != RandomNumber || RandomNumber==25)
            {
                if (Chances > 1)
                {
                    Console.WriteLine($"You have {Chances} chances left.");
                    Console.Write($"Guess the number between {minVal} and {maxVal}: ");
                    Guesses = int.Parse(Console.ReadLine());
                }
                else if (Chances == 1)
                {
                    System.Console.WriteLine($"You have {Chances} chance left.");
                    System.Console.Write($"Guess the number between {minVal} and {maxVal}: ");
                    Guesses = int.Parse(Console.ReadLine());
                }
                        

                if (Guesses == RandomNumber && Chances > 0)
                {
                   Output = $"You are right, the answer is {RandomNumber}";
                    break;
                }

                if (Chances == 1)
                {
                    Output = "You no longer have any chances, Game Over";  
                    break;
                }
                else{
                    System.Console.WriteLine("You guessed wrong");
                }
                Chances -= 1;
            }
            return Output;
        }
    }
}


    
