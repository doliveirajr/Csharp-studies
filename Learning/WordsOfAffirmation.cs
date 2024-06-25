namespace HelloWorld.Learning
{
    public class WordsOfAffirmation
    {
        private readonly string[] words = ["You are doing great!", "Keep it up!", "Fantastic job!", "You rock it!", "Let's Go!", "Keep the fire!"];


        public void StartTimer(int interval)
        {
            int i = 0;
            var n = new Random();

            for (int x = 0; x < words.Length; x++)
            {
                Thread.Sleep(interval * 1000);
                Console.WriteLine(words[n.Next(6)]);
                i++;
            }
        }
    }
}