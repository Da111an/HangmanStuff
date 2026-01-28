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

            word = words[r.Next(words.Count)];

            return word;

           
        }

        public bool ValidGuess(string guess, string lettersGuessed)
        {

        }
    }
}
