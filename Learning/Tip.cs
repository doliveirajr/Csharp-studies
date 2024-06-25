public class Tip
{
    public (double low, double mid, double high) Tips(double time)
    {
        double lower = time * 0.95;
        double middle = time * 0.975;
        double higher = time * 1;

        return (lower, middle, higher);
    }
}