
using HelloWorld.Learning;

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
            var cheking = new Learning.CheckingAcct("John", "Doe", 2500.0m);
            Console.WriteLine(cheking.Balance);

            var tuple4 = Tuple.Create(10, 25, 30, 40);
            Console.WriteLine("Item 1: {0}, Item 2: {1}, Item 3: {2}, Item 4{3}",
                                tuple4.Item1, tuple4.Item2, tuple4.Item3, tuple4.Item4);


            var voteForPresident = new VoteForPresident();

            VoteForPresident.Vote4President(25);

            var breakUrl = new Learning.BreakUrl();
            string b = BreakUrl.Break("www.batata.com");
            Console.WriteLine(b);

            var batman = new Learning.Movie("Batman", "PG-20", 75);
            var batman2 = new Learning.Movie("Batman", "PG-20", 76);
            var batman3 = new Learning.Movie("Batman", "PG-20", 17);

            Console.WriteLine(batman.ToString());
            Console.WriteLine(batman2.ToString());
            Console.WriteLine(batman3.ToString());
            var test = new Learning.WordsOfAffirmation();
            test.StartTimer(0);

            var fibonacci = new Fibonacci();
            fibonacci.CallFibonacci(9);

            // Deconstruct class
            Tip Earth = new(9.63);
            var (low, mid, high) = Earth;
            Console.WriteLine($"Higher: {high} \nMid: {mid}\nLower: {low}");
            MyMethod("25", "Denilson", "30");

            List<int> ts = [1, 2, 4, -5, -8, 5, 80, 0, -1, 5, -2];
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

            var auto = new Learning.New(" ABBA ");

            Console.Write("\n");
            Console.WriteLine(auto.ToString());

            List<ClassicCar> carList = [];
            Learning.CarPopulate.PopulateData(carList);

            // How many cars are in the collection?
            Console.WriteLine("There are {0} cars in the collection!", carList.Count);

            // How many Fords are there?
            List<ClassicCar> fordList = carList.FindAll(CarPopulate.FindFords);
            Console.WriteLine("There are {0} Fords in the entire collection!", fordList.Count);

            // What is the most valuable car?
            ClassicCar? mostValCar = null;
            int highValue = 0;
            foreach (ClassicCar c in carList)
            {
                if(c.m_Value > highValue)
                {
                    mostValCar = c;
                    highValue = c.m_Value;
                }
            }

            Console.WriteLine("The most valuable car is {0} {1} {2}, cost {3}",
                                mostValCar?.m_Make,
                                mostValCar?.m_Model,
                                mostValCar?.m_Year,
                                mostValCar?.m_Value);

            // What is the entire collection worth?
            int collectionWorth = 0;
            foreach (ClassicCar c in carList)
            {
                collectionWorth += c.m_Value;
            }

            Console.WriteLine("The entire collection worth ${0}", collectionWorth);

            // How many unique manufacturers are there?
            Dictionary<string, bool> makes = [];
            foreach (ClassicCar c in carList) {
                try {
                    makes.Add(c.m_Make, true);
                }
                catch (Exception) { }
            };
            Console.WriteLine("The collection contains {0} unique manufacturers.\n", makes.Keys.Count);

            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
            return 0;
        }
    }
}
