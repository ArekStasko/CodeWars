using System.Net;

namespace CodeWars;

public class Test
{
  public static string TimeConvert(int num)
  {
    if (num <= 0) return "00:00";

    string hours = (num / 60).ToString();
    string minutes = (num % 60).ToString();

    hours = hours.Length == 1 ? $"0{hours}" : hours;
    minutes = minutes.Length == 1 ? $"0{minutes}" : minutes;

    return $"{hours}:{minutes}";
  }
}
