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
      var negatives = "";
      foreach (string num in nums)
      {
        int i;
        
        if (int.TryParse(num, out i))
        {
          if (i < 0)
          {            
            negatives += i + ",";
            continue;
          }

          sum += i;
        }        
      }

      if (!string.IsNullOrEmpty(negatives))
      {
        throw new NegativesNotAllowedException(negatives);
      }
      return sum;
    }
  }
}