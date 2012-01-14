using System.Linq;
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
  }

  public class StringCalculator
  {
    public int Add(string numbers)
    {
      if (numbers.Equals(string.Empty))
      {
        return 0;
      }
      var nums = numbers.Split(',');
      return nums.Sum(num => int.Parse(num));
    }
  }
}