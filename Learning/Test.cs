using System.Collections;

public class Test
{
    public static IEnumerable PositiveNumbers(List<int> ints)
    {
        IEnumerable<int> ints1 =
        from i in ints
        where i > 0
        select i;

        return ints1;
    }

    public static IEnumerable NegativeNumbers(List<int> ints)
    {
        IEnumerable<int> ints1 =
        from i in ints where i < 0 select i;

        return ints1;
    }
}