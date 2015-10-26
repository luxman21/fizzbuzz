require_relative '../app/fizzbuzz'

expected = []
100.times do |i|
	if (i% 15 == 0)
		expected.push("FizzBuzz")
	elsif (i % 5 == 0)
		expected.push("Buzz")
	elsif (i % 3 == 0)
		expected.push("Fizz")
	else expected.push(i) 	
	end
end		

describe "fizzbuzz" do
	
	it "1 to 100" do
		100.times do |i|
			expect(fizzbuzz(i)).to eq(expected[i])
		end
	end	
end
