public class Tip
{
    public double Lower { get; set; }
    public double Mid { get; set; }
    public double High { get; set; }
    public double lower, middle, higher;
    public Tip(double tip)
    {
        Lower = tip * 0.95;
        Mid = tip * 0.975;
        High = tip * 1;
    }
    public void Deconstruct(out double low, out double mid, out double high)
    {
        low = Lower;
        mid = Mid;
        high = High;
    }
}