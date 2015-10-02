using NUnit.Framework;
using System;

[TestFixture]
public class FizzBuzzTest {

    [Test]
    public void fizzbuzzTest() {
    
    	for(int i = 1; i <= 100; i++) {
    		if(i%15 == 0) 
	        	Assert.AreEqual("FizzBuzz", FizzBuzz.fizzbuzz(i));
       		else if (i%5 == 0) 
	        	Assert.AreEqual("Buzz", FizzBuzz.fizzbuzz(i));
        	else if(i%3 == 0) 
	        	Assert.AreEqual("Fizz", FizzBuzz.fizzbuzz(i));
            else 
                Assert.AreEqual(i, FizzBuzz.fizzbuzz(i));
	    }
	}

}