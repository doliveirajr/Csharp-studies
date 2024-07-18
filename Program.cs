
namespace HelloWorld
{
    class Program
    {
        static void MyMethod(string number, string name, string age)
        {
            Console.WriteLine($"{number}, {name}, {age}.");
        }
        static int Main(string[] args)
        {
            var cheking = new Bank.CheckingAcct("John", "Doe", 2500.0m);
            Console.WriteLine(cheking.Balance);

            var tuple4 = Tuple.Create(10, 25, 30, 40);
            Console.WriteLine("Item 1: {0}, Item 2: {1}, Item 3: {2}, Item 4{3}",
                                tuple4.Item1, tuple4.Item2, tuple4.Item3, tuple4.Item4);


            var voteForPresident = new VoteForPresident();

            voteForPresident.Vote4President(25);

            var breakUrl = new BreakUrl();
            string b = breakUrl.Break("www.batata.com");
            Console.WriteLine(b);

            var batman = new Movie("Batman", "PG-20", 75);
            var batman2 = new Movie("Batman", "PG-20", 76);
            var batman3 = new Movie("Batman", "PG-20", 17);

            Console.WriteLine(batman.ToString());
            Console.WriteLine(batman2.ToString());
            Console.WriteLine(batman3.ToString());
            var test = new HelloWorld.Learning.WordsOfAffirmation();
            test.StartTimer(0);

            var fibonacci = new Fibonacci();
            fibonacci.callFibonacci(9);

            // Deconstruct class
            Tip Earth = new Tip(9.63);
            var (low, mid, high) = Earth;
            Console.WriteLine($"Higher: {high} \nMid: {mid}\nLower: {low}");
            MyMethod("25", "Denilson", "30");

            List<int> ts = [1, 2, 4, 5, 80, 0, -1, 5, -2];
            string? word = null;
            word ??= "Null word!";
            Console.WriteLine(word);

            // Patterns
            int e = 5;
            if (e is int a)
            {
                Console.WriteLine(a);
            }

            var lista = Test.PositiveNumbers(ts);
            foreach (var item in lista)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n");

            var lista1 = Test.NegativeNumbers(ts);
            foreach (var item in lista1)
            {
                Console.Write($"{item} ");
            }

            var auto = new Testing.New(" ABBA ");

            Console.Write("\n");
            Console.WriteLine(auto.ToString());

            return 0;
        }
    }
}
