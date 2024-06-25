public class Fibonacci
{
    List<long> fibonacciArray = new List<long>();
    int firstNumber = 0, secondNumber = 1;

    public void callFibonacci(int sequence)
    {
        fibonacciArray.Add(firstNumber);
        fibonacciArray.Add(secondNumber);
        for (int i = 2; i < sequence; i++)
        {
            int nextNumber = firstNumber + secondNumber;
            fibonacciArray.Add(nextNumber);

            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }

        foreach (long item in fibonacciArray)
        {

            Console.Write($"{item} ");

        }
        Console.WriteLine();
    }
}