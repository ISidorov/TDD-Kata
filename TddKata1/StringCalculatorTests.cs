using System.Globalization;
using System.Text;
using Xunit;
namespace TddKata1
{ 
  public class StringCalculatorFacts
  {
    private readonly StringCalculator stringCalculator;

    public StringCalculatorFacts()
    {
      stringCalculator = new StringCalculator();
    }
    
    [Fact]
    public void AddEmptyStringWillReturn0()
    {
      Assert.Equal(0,  stringCalculator.Add(string.Empty));
    }

    [Fact]
    public void AddOneNumberWillReturnThatNumber()
    {      
      Assert.Equal(1 , stringCalculator.Add("1"));
    }

    [Fact]
    public void AddTwoNumbersWillReturnSum()
    {
      Assert.Equal(3, stringCalculator.Add("1,2"));
    }

    [Fact]
    public void AddAnyNumbersWillReturnSum()
    {
      var sum = 0;
      var numbers = new StringBuilder(100);
      for (var i = 0; i < 100; i++ )
      {
        sum += i;
        numbers.Append(i.ToString(CultureInfo.InvariantCulture) + ",");
      }

      Assert.Equal(sum, stringCalculator.Add(numbers.ToString()));
    }

    [Fact]
    public void AddNumbersWithEnterWillReturnSum()
    {
      Assert.Equal(6, stringCalculator.Add("1\n2,3"));
    }

    [Fact]
    public void AddSupportDifferentDelimeters()
    {
      Assert.Equal(3, stringCalculator.Add("//;\n1;2"));
    }

    [Fact]
    public void AddNegativeWillThrowNegativesNotAllowedException()
    {
      Assert.Throws<NegativesNotAllowedException>(() => stringCalculator.Add("-1,-2,10"));
    }
  }
}