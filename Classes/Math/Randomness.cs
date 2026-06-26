namespace LunaLib.Math;

public static class Randomness // chaos is bound to happen (chaos theory)
{
    private static readonly Random Random = new();

    public static bool CoinFlip() // returns a 50/50 chance either it landed on true or false
    {
        return Random.Next(0, 2) == 0;
    }

    public static bool OneIn(int number) // 1/number chance to return true
    {
        return Random.Next(0, number) == 0;
    }
}