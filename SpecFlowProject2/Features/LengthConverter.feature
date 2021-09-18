﻿Feature: LengthConverter
![LengthConverter](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Convert length from one unit to another

@convertFeetToInches
Scenario: Convert feet into inches
	Given the length is 30
	When the length in feet is converted to inches
	Then the length should be 360

@convertInchesToFeet
Scenario: Convert inches to feet
	Given the length is 360
	When the length in inches is converted to feet
	Then the length should be 30

@convertMetersToFeet
Scenario: Convert meters to feet
	Given the length is 1
	When the length in meters is converted to feet
	Then the length should be 3.28084M

@convertFeetToMeters
Scenario: Convert feet to meters
	Given the length is 1
	When the length in feet is converted to meters
	Then the length should be 0.3048M

@convertFeetToYards
Scenario: Convert feet to yards
	Given the length is 12
	When the length in feet is converted to yards
	Then the length should be 4

@convertYardsToFeet
Scenario: Convert yards to feet
	Given the length is 3
	When the length in yards is converted to feet
	Then the length should be 9
