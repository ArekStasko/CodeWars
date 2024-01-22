namespace CodeWars.bestMatch;

public class BestMatchTest
{
    public static int BestMatch(int[] goals1, int[] goals2)
    {
        int result = int.MaxValue;
        int index = 0;

        for (int i = 0; i < goals1.Length; i++)
        {
            int difference = Math.Abs(goals1[i] - goals2[i]);
            if (difference < result)
            {
                result = difference;
                index = i;
            }

            if (difference == result && goals1[i] > goals2[i] && goals1[i] > goals1[index])
            {
                result = difference;
                index = i;
            }
        }

        return index;
    }
}