using System.Linq;

namespace TddKata1
{
  public class StringCalculator
  {
    public int Add(string numbers)
    {
      if (numbers.Equals(string.Empty))
      {
        return 0;
      }
      var nums = numbers.Split(',', '\n');
      int sum = 0;
      foreach (string num in nums)
      {
        int i;
        if (int.TryParse(num, out i))
        {
          sum += i;
        };        
      }
      return sum;
    }
  }
}