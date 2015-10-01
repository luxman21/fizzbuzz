var assert = require("chai").assert;
var codecheck = require("codecheck");

function doTest(arg, expected, done) {
  var app = codecheck.consoleApp("./a.out");
  app.expected("" + expected);
  app.runAndVerify([arg], function(result) {
    assert(result.succeed, result.getMessage());
    done();
  });
} 

describe("isFizzbuzz", function() {

  it("Test for Fizz, Buzz, FizzBuzz and number upto 100", function(done) {

    var expected = [];
    for (var i=0; i<= 100; i++ ) {
      if(i % 15 == 0) expected[i] = "FizzBuzz";
      else if (i % 5 == 0) expected[i] = "Buzz";
      else if (i % 3 == 0) expected[i] = "Fizz";
      else expected[i] = i;
    }
    var cnt = 0;
    for (var i=1; i<=100; i++) {
      doTest(i, expected[i], function() {
        cnt++;
        if (cnt === 100) {
          done();
        }
      });
    }
  });

});


