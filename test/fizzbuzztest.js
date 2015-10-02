var assert = require("chai").assert;
var codecheck = require("codecheck");

var expected = [];
for (var i=1; i<= 100; i++ ) {
  if(i % 15 == 0) expected.push("FizzBuzz");
  else if (i % 5 == 0) expected.push("Buzz");
  else if (i % 3 == 0) expected.push("Fizz");
  else expected.push("" + i);
}

function doTest(arg, expected, done) {
  var app = codecheck.consoleApp("./a.out");
  app.expected("" + expected);
  app.runAndVerify([arg], function(result) {
    assert(result.succeed, result.getMessage());
    done();
  });
} 

describe("fizzbuzz", function() {

  expected.forEach(function(value, index) {
    it("Test " + (index + 1) + " returns " + value, function(done) {
      doTest(index + 1, value, done);
    })
  });

});


