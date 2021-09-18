Feature: LengthConverter
![LengthConverter](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Convert length from one unit to another

@convertFeetToInches
Scenario: Convert feet into inches
	Given the length in feet is 30
	When the length in feet is converted to inches
	Then the length in inches should be 360