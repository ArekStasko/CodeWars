namespace CodeWars.Scramblies;

public class Scramblies
{
    public static bool Scramble(string str1, string str2)
    {
        bool result = true;
        for (int i = 0; i < str2.Length; i++)
        {
            char charToFind = str2[i];
            if (!str1.Contains(charToFind)) return false;
            int indexToRemove = str1.IndexOf(charToFind);
            str1 = str1.Remove(indexToRemove, 1);
        }
        return result;
    }
}