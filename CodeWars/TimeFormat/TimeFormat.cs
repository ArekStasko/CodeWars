namespace CodeWars.TimeFormat;

public class TimeFormat
{
    public static string ConvertNumberToCorrectFormat(int numberToConver) => numberToConver.ToString().Length == 1 ? $"0{numberToConver}" : numberToConver.ToString();
    
    public static string GetReadableTime(int secondsToConvert)
    {
        if (secondsToConvert == 0) return "00:00:00";
        
        string convertedHours = ConvertNumberToCorrectFormat((secondsToConvert / 60) / 60);
        int rest = secondsToConvert % 3600;
        string convertedMinutes = ConvertNumberToCorrectFormat(rest / 60);
        string convertedSeconds = ConvertNumberToCorrectFormat(rest%60);
        
        return $"{convertedHours}:{convertedMinutes}:{convertedSeconds}";
    }
}