using System;

namespace TddKata1
{
  public class NegativesNotAllowedException : ApplicationException
  {
    public NegativesNotAllowedException(string message) : base(message)
    {
    }
  }
}