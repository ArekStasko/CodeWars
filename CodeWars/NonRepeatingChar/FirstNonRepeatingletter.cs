namespace CodeWars.NonRepeatingChar;

public class FirstNonRepeatingChar
{
    public static string FirstNonRepeatingLetter(string s)
    {
        if (s.Length == 0) return "";
        
        string result = "";
        bool isRepeated = true;
        
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                isRepeated = s[i].ToString().ToLower() == s[j].ToString().ToLower() && i != j;
                if(isRepeated) break;
            }

            if (!isRepeated)
            {
                result = s[i].ToString();
                break;
            }
        }

        return result;
    }
}