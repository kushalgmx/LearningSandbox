Feature: Multiplication

@easy
Scenario: Multiples of ten must end with a zero 
	Given the first number is 9
	And the second number is 10
	When the numbers are multiplied
	Then the product end with 0

@easy
Scenario: Multiples of hundred must end with two zeroes
	Given the first number is 8
	And the second number is 100
	When the numbers are multiplied
	Then the product end with 00

@easy
Scenario: Multiples of thousand must end with three zeroes
	Given the first number is 7
	And the second number is 1000
	When the numbers are multiplied
	Then the product end with 000

