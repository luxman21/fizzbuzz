var assert = require("chai").assert;

var fizzbuzz = require("../app/fizzbuzz.js");

var expected = [];
for(var i=1; i<= 100; i++) {
  if(i % 15 == 0)       expected.push("FizzBuzz");
  else if (i % 5 == 0)  expected.push("Buzz");
  else if (i % 3 ==0)   expected.push("Fizz");
  else                  expected.push(i.toString());
}


describe("fizzbuzz", function() {

  it("1 to 100", function() {
    for(var i=1; i<= 100; i++) {
      assert.equal(fizzbuzz(i), expected[i-1]);
    }
  });
});
