namespace CodeWars.MeanSquare;

public class MeanSquare
{
    public static double Solution(int[] firstArray, int[] secondArray)
    {
        var result = new List<double> {};
        for (int i = 0; i < firstArray.Length; i++) result.Add(Math.Pow(Math.Abs(firstArray[i] - secondArray[i]), 2));
        return result.Sum() / result.Count;
    }
}