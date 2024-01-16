using System.Numerics;

namespace CodeWars.LastDigit;

public class LastDigit
{
    public static int[] GetLastDigitSet(int lastDigit)
    {
        switch (lastDigit)
        {
            case 0:
                return new[] { 0 };
            case 1:
                return new[] { 1 };
            case 2:
                return new[] { 2, 4, 8, 6 };
            case 3:
                return new[] { 3, 9, 7, 1 };
            case 4:
                return new[] { 4, 6 };
            case 5:
                return new[] { 5 };
            case 6:
                return new[] { 6 };
            case 7:
                return new[] { 7, 9, 3, 1 };
            case 8:
                return new[] { 8, 4, 2, 6 };
            case 9:
                return new[] { 9, 1 };
            default:
                return new[] { 0 };
        }
    }
    
    public static int GetLastDigit(BigInteger n1, BigInteger n2)
    {
        if (n1 == 4)
        {
            return n2 % 2 == 0 ? 4 : 6;
        }
        
        if ((int)n1 == 0 || (int)n2 == 0) return 0;
        
        char[] convertedN1 = n1.ToString().ToCharArray();
        int lastDigit = int.Parse(convertedN1[convertedN1.Length - 1].ToString());

        if (lastDigit == 0) return 0;

        int[] lastDigitSet = GetLastDigitSet(lastDigit);
        BigInteger lastDigitSetLength = lastDigitSet.Length;

        int restOfDivision = (int)(n2 % lastDigitSetLength);

        if (restOfDivision == 0) return lastDigitSet[(int)lastDigitSetLength - 1];
        return lastDigitSet[restOfDivision-1];
    }
}