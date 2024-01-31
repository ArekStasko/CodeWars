namespace CodeWars.MaxPartition;

public class MaxPartition
{
    public static (int[][], int) FindPartMaxProd(int n)
    {
        if (n == 2)
        {
            int[][] result =  { new []{2} };
            return (result, 2);
        }
        
        if (n == 3)
        {
            int[][] result =  { new []{3} };
            return (result, 3);
        }

        int partitionCalc = n;
        List<int> resultPartition = new List<int>();
        int partitionMaximum = 1;
        while (partitionCalc > 3)
        {
            partitionCalc =- 3;
            if (partitionCalc > 3)
            {
                resultPartition.Add(3);
                partitionMaximum *= 3;
            }

            if (partitionCalc <= 3)
            {
                resultPartition.Add(3);
                resultPartition.Add(partitionCalc);
            }
        }
        int[][] convertedResult =  { resultPartition.ToArray() };
        return (convertedResult,partitionMaximum);
    }
}