from nose.tools import assert_equal

from app.fizzbuzz import fizzbuzz

expected = []
for i in range(1, 100):
	if(i % 15 == 0):
   		expected.append("FizzBuzz")
  	elif(i % 5 == 0):
    		expected.append("Buzz")
  	elif(i % 3 == 0):
    		expected.append("Fizz")
  	else: 
    		expected.append(str(i))

def test_fizzbuzz():
	for i in range(1, 100):
		assert_equal(fizzbuzz(i), expected[i-1])