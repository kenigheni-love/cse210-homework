using System;

class Program
{
    static void Main(string[] args)
    {
        // Keep track of whether the user wants to play again
        bool playAgain = true;
        
        // Continue playing as long as the user wants to 
        while (playAgain)
        {
            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // Initialize variables for the game
            int guess = 0;
            int guessCount = 0;
            bool gameOver = false;

            // Start the guessing loop
            while (!gameOver)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                
                if (guess == magicNumber)
                {
                    Console.WriteLine("Wow! You guessed it!");
                    Console.WriteLine($"You used {guessCount} guesses.");
                    gameOver = true;

                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");

                }
                else 
                {
                    Console.WriteLine("Lower"); 
                }
            }
            // Ask if user wants to play again
            Console.Write("Do you want to play again (yes/no): ");
            string response = Console.ReadLine();
            if (response.ToLower() != "yes")
            {
                playAgain = false;
            }
     
        }
        

   }


}              
         
 

        