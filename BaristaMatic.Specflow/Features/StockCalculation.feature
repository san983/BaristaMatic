Feature: Stock calculation
	In order to know the ingredients stock
	As a user
	I want the machine to calculate it

Scenario: One coffee from scratch
	Given a full loaded barista matic coffee machine
	When I press 1
	Then the delivery status should be true
	And the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 7			|
		| Decaf Coffee  | 10        |
		| Sugar			| 9			|
		| Cream			| 9         |
		| Steamed Milk	| 10		|
		| Foamed Milk   | 10        |
		| Espresso		| 10		|
		| Cocoa Coffee  | 10        |
