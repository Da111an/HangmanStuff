using System.Globalization;

namespace HangmanStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HangmanTools ht = new HangmanTools();

            string solution = "";
            string guess = "";
            string lettersGuessed = "";
            bool gameOver = false;
            int incorrectGuesses = 0;

            Console.WriteLine("Welcome to Hangman!");

            solution = ht.GetRandomWord();

            Console.WriteLine("A random word has been chosen. Try to guess it letter by letter.");
            Console.Write("Please enter the letter that you would like to guess: ");

            do
            {
                if (lettersGuessed.Length > 0)
                {
                    Console.WriteLine($"Guessed letters: {lettersGuessed}");
                    Console.WriteLine($"Word: {ht.UpdateWord(lettersGuessed, solution)}");
                }
                
                do
                {
                    guess = Console.ReadLine();
                } while (!ht.ValidGuess(guess, lettersGuessed));


                if (solution.Contains(guess))
                {
                    lettersGuessed += guess;
                    Console.WriteLine($"Congratulations! The letter {guess} is in the word.");
                    if (ht.UpdateWord(lettersGuessed, solution) == solution)
                    {
                        Console.WriteLine($"You won! The word was {solution}.");
                        gameOver = true;
                    }
                    
                }

                else
                {
                    lettersGuessed += guess;
                    Console.WriteLine($"Sorry, the letter {guess} is not in the word.");
                    incorrectGuesses++;
                    if (incorrectGuesses < 6)
                    {
                        Console.WriteLine($"You have {6 - incorrectGuesses} guesses remaining.");
                    }
                    
                    if (incorrectGuesses >= 6)
                    {
                        Console.WriteLine($"You lost! The word was {solution}.");
                        gameOver = true;
                    }
                }

                
            } while (!gameOver);

            Console.WriteLine("Thanks for playing! Please come again.");





        }

        
    }
}
