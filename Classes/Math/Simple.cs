namespace LunaLib.Math;

public static class Simple // as they say, simplicity is simple :p
{
    public static double Add(params object[] nums) // adds stuff
    {
        double result = 0;

        foreach (var num in nums)
            result += Convert.ToDouble(num);

        return result;
    }

    public static double Subtract(params object[] nums) // idk subtracts things
    {
        if (nums.Length == 0)
            return 0;

        double result = Convert.ToDouble(nums[0]);

        for (int i = 1; i < nums.Length; i++)
            result -= Convert.ToDouble(nums[i]);

        return result;
    }

    public static double Multiply(params object[] nums) // definately multiplys things
    {
        if (nums.Length == 0)
            return 0;

        double result = 1;

        foreach (var num in nums)
            result *= Convert.ToDouble(num);

        return result;
    }

    public static double Divide(params object[] nums) // I swear devision always returns a decimal number (unless it is disvisible)
    {
        if (nums.Length == 0)
            return 0;

        double result = Convert.ToDouble(nums[0]);

        for (int i = 1; i < nums.Length; i++)
        {
            double val = Convert.ToDouble(nums[i]);
            result = val == 0 ? double.PositiveInfinity : result / val; // avoids deviding by 0 because... you cant lol
        }

        return result;
    }
}
