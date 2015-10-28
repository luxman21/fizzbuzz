using NUnit.Framework;
using System;

[TestFixture]
public class FizzBuzzTest
{

    [Test]
    public void DoFizzBuzzTest()
    {

        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0)
                Assert.AreEqual("FizzBuzz", FizzBuzz.DoFizzBuzz(i));
            else if (i % 5 == 0)
                Assert.AreEqual("Buzz", FizzBuzz.DoFizzBuzz(i));
            else if (i % 3 == 0)
                Assert.AreEqual("Fizz", FizzBuzz.DoFizzBuzz(i));
            else
                Assert.AreEqual(i.ToString(), FizzBuzz.DoFizzBuzz(i));
        }
    }
}