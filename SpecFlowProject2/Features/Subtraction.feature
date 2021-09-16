Feature: Substraction

@easy
Scenario: Subtract a number from another
	Given the minuend is 70
	And the subtrahend is 50
	When the subtrahend is subtracted from the minuend
	Then the subtraction result should be 20