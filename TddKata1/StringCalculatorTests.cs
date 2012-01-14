using System.Globalization;
using System.Text;
using NUnit.Framework;

namespace TddKata1
{
  
  [TestFixture]
  public class StringCalculatorTests
  {
    private StringCalculator stringCalculator;

    [SetUp]
    public void Init()
    {
      stringCalculator = new StringCalculator();
    }

    [Test]
    public void AddEmptyStringWillReturn0()
    {
      Assert.AreEqual(0,  stringCalculator.Add(string.Empty));
    }

    [Test]
    public void AddOneNumberWillReturnThatNumber()
    {      
      Assert.AreEqual(1 , stringCalculator.Add("1"));
    }

    [Test]
    public void AddTwoNumbersWillReturnSum()
    {
      Assert.AreEqual(3, stringCalculator.Add("1,2"));
    }

    [Test]
    public void AddAnyNumbersWillReturnSum()
    {
      var sum = 0;
      var numbers = new StringBuilder(100);
      for (var i = 0; i < 100; i++ )
      {
        sum += i;
        numbers.Append(i.ToString(CultureInfo.InvariantCulture) + ",");
      }

      Assert.AreEqual(sum, stringCalculator.Add(numbers.ToString()));
    }

    [Test]
    public void AddNumbersWithEnterWillReturnSum()
    {
      Assert.AreEqual(6, stringCalculator.Add("1\n2,3"));
    }

    [Test]
    public void AddSupportDifferentDelimeters()
    {
      Assert.AreEqual(3, stringCalculator.Add("//;\n1;2"));
    }

    [Test]
    public void AddNegativeWillThrowNegativesNotAllowedException()
    {
      Assert.Throws<NegativesNotAllowedException>(() => stringCalculator.Add("-1,-2,10"));
    }
  }
}