namespace HangmanStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HangmanTools ht = new HangmanTools();
            string word = ht.GetRandomWord();
            Console.WriteLine("Random word: " + word);
            
        }

        
    }
}
