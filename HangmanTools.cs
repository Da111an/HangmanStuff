using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanStuff
{
    internal class HangmanTools
    {
        public string GetRandomWord()
        {
            Random r = new Random();

            string word = "";

            List<string> words = new List<string>()
            {
                "King",
                "Queen",
                "Prince",
                "Princess",
                "Net",
                "Demon"
            };
            // Get a random word.
            word = words[r.Next(words.Count)];

            return word;

           
        }

        public bool ValidGuess(string guess, string lettersGuessed)
        {
            bool result = true; //Default to valid guess

            if (guess.Length != 1) //
            {
                Console.WriteLine("Sorry, the guess can only be one letter.");
                result = false;
            }

            else if (!Char.IsLetter(guess[0]))
            {
                Console.WriteLine("Sorry, the guess needs to be a letter.");
                result = false;
            }

            else if (lettersGuessed.Contains(guess))
            {
                Console.WriteLine("Sorry, you have already guessed the letter " + guess);
                result = false;
            }
            return result;
        }

        public string UpdateWord(string lettersGuessed, string solution)
        {
            string result = "";

            for (int i = 0; i < solution.Length; i++)
            {
                if (lettersGuessed.Contains(solution[i]))
                {
                    result += solution[i];
                }
                else
                {
                    result += "_";
                }
            }

            return result;
        }
    }
}
