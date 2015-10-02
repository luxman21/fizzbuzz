use strict;
use warnings;
use Test::More;

use app::Fizzbuzz;

fizzBuzzTest();

sub fizzBuzzTest {

  for my $i (1..100) {
    if ($i % 15 == 0) {
	  ok app::Fizzbuzz::fizzbuzz($i) eq "FizzBuzz";
    } elsif ($i % 5 == 0) {
	  ok app::Fizzbuzz::fizzbuzz($i) eq "Buzz";
    } elsif ($i % 3 == 0) {
	  ok app::Fizzbuzz::fizzbuzz($i) eq "Fizz";
    } else {
	  ok app::Fizzbuzz::fizzbuzz($i) eq $i;
    }
  }

}

done_testing;