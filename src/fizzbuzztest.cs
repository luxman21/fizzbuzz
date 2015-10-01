using NUnit.Framework;
using System;

[TestFixture]
public class FizzBuzzTest {

    [Test]
    public void IsFizzBuzzTest() {
    
    	for(int i = 1; i <= 100; i++) {
    		if(i%15 == 0) 
	        	Assert.AreEqual("FizzBuzz", FizzBuzz.isFizzBuzz(i));
       		else if (i%5 == 0) 
	        	Assert.AreEqual("Buzz", FizzBuzz.isFizzBuzz(i));
        	else if(i%3 == 0) 
	        	Assert.AreEqual("Fizz", FizzBuzz.isFizzBuzz(i));
	    }
	}

}