namespace CodeWars.MissingArray;

public class MissingArray
{
    public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
    {
        if (arrayOfArrays == null || arrayOfArrays.Length == 0) return 0;
        
        List<int> arrayLengths = new List<int>();
        
        foreach (var array in arrayOfArrays)
        {
            if (array == null || array.Length == 0) return 0;
            arrayLengths.Add(array.Length);
        }
        
        arrayLengths.Sort();
        
        for (int i = 1; i < arrayLengths.Count; i++)
        {
            var firstArrayLength = arrayLengths[i-1];
            var secondArrayLength = arrayLengths[i];

            if (firstArrayLength + 1 != secondArrayLength) return firstArrayLength + 1;
        }

        return 0;
    }
}