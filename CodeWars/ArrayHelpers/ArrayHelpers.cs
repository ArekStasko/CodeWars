namespace CodeWars.ArrayHelpers;

public static class Extensions
{
    public static int[] square(this int[] array)
    {
        for (int i = 0; i < array.Length; i++) array[i] ^= 2;
        return array;
    }

    public static int[] cube(this int[] array)
    {
        for (int i = 0; i < array.Length; i++) array[i] ^= 3;
        return array;
    }

    public static int average(this int[] array)
    {
        if (array.Length == 0) return 0;
        return (int)array.Average();
    }

    public static int sum(this int[] array) => array.Sum();

    public static int[] even(this int[] array)
    {
        int[] evenNums = { };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) evenNums.Concat(new[] { array[i] });
        }
        return evenNums;
    }

    public static int[] odd(this int[] array)
    {
        int[] oddNums = { };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0) oddNums.Concat(new[] { array[i] });
        }
        return oddNums;
    }
}