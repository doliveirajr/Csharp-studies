namespace HelloWorld.Learning
{
    public class Tip(double tip)
    {
        public double Lower { get; set; } = tip * 0.95;
        public double Mid { get; set; } = tip * 0.975;
        public double High { get; set; } = tip * 1;
        public double lower, middle, higher;

        public void Deconstruct(out double low, out double mid, out double high)
        {
            low = Lower;
            mid = Mid;
            high = High;
        }
    }
}