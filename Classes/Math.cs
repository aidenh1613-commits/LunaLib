namespace LunaLib;

public class Math
{
    private static readonly Random Random = new();

    public static bool CoinFlip() // returns a 50/50 chance either it landed on true or false
    {
        return Random.Next(0, 2) == 0;
    }

    public static double AddAll(params object[] Nums)
    {
        double sum = 0;
        foreach (var Number in Nums)
        {
            double addition = Convert.ToDouble(Number);

            sum += addition;
        }
        return sum;
    }
}
