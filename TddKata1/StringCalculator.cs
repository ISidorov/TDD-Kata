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

      var defaultDelimeters = new [] {',', '\n'};
      if (numbers.StartsWith("//"))
      {
        defaultDelimeters = new[] { numbers[2] };

        numbers = numbers.Remove(0, 4);
      }

      var nums = numbers.Split(defaultDelimeters);
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