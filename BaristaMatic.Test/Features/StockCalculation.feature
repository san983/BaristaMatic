Feature: Stock calculation
	In order to know the ingredients stock
	As a user
	I want the machine to calculate it

Scenario: Initial Stock
	Given a full loaded barista matic coffee machine
	Then the stock and unit cost should be
		| Ingredient	| Units		| UnitCost	| 	
		| Coffee		| 10		| 0.75		|
		| Decaf Coffee  | 10        | 0.75		|
		| Sugar			| 10		| 0.25		|
		| Cream			| 10        | 0.25		|
		| Steamed Milk	| 10		| 0.35		|
		| Foamed Milk   | 10        | 0.35		|
		| Espresso		| 10		| 1.10		|
		| Cocoa		    | 10        | 0.90		|
		| Whipped Cream | 10        | 1.00		|

Scenario: Just one coffee
	Given a full loaded barista matic coffee machine
	When I press 5
	Then the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 7			|
		| Decaf Coffee  | 10        |
		| Sugar			| 9			|
		| Cream			| 9         |
		| Steamed Milk	| 10		|
		| Foamed Milk   | 10        |
		| Espresso		| 10		|
		| Cocoa			| 10        |
		| Whipped Cream | 10        |

Scenario: Just one decaf coffee
	Given a full loaded barista matic coffee machine
	When I press 6
	Then the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 10		|
		| Decaf Coffee  | 7			|
		| Sugar			| 9			|
		| Cream			| 9         |
		| Steamed Milk	| 10		|
		| Foamed Milk   | 10        |
		| Espresso		| 10		|
		| Cocoa			| 10        |
		| Whipped Cream | 10        |

Scenario: Just one Caffe Latte
	Given a full loaded barista matic coffee machine
	When I press 2
	Then the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 10		|
		| Decaf Coffee  | 10		|
		| Sugar			| 10		|
		| Cream			| 10        |
		| Steamed Milk	| 9			|
		| Foamed Milk   | 10        |
		| Espresso		| 8			|
		| Cocoa			| 10        |
		| Whipped Cream | 10        |

Scenario: Just one Caffe Americano
	Given a full loaded barista matic coffee machine
	When I press 1
	Then the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 10		|
		| Decaf Coffee  | 10		|
		| Sugar			| 10		|
		| Cream			| 10        |
		| Steamed Milk	| 10		|
		| Foamed Milk   | 10        |
		| Espresso		| 7			|
		| Cocoa			| 10        |
		| Whipped Cream | 10        |

Scenario: Just one Caffe Mocha
	Given a full loaded barista matic coffee machine
	When I press 3
	Then the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 10		|
		| Decaf Coffee  | 10		|
		| Sugar			| 10		|
		| Cream			| 10        |
		| Steamed Milk	| 9			|
		| Foamed Milk   | 10        |
		| Espresso		| 9			|
		| Cocoa			| 9	        |
		| Whipped Cream | 9		    |

Scenario: Just one Cappuccino
	Given a full loaded barista matic coffee machine
	When I press 4
	Then the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 10		|
		| Decaf Coffee  | 10		|
		| Sugar			| 10		|
		| Cream			| 10        |
		| Steamed Milk	| 9			|
		| Foamed Milk   | 9	        |
		| Espresso		| 8			|
		| Cocoa			| 10        |
		| Whipped Cream | 10        |

Scenario: Restock
	Given a full loaded barista matic coffee machine
	When I press 5
	And I press 6
	Then the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 7			|
		| Decaf Coffee  | 7		    |
		| Sugar			| 8			|
		| Cream			| 8		    |
		| Steamed Milk	| 10		|
		| Foamed Milk   | 10        |
		| Espresso		| 10		|
		| Cocoa		    | 10        |
		| Whipped Cream | 10        |
	When I press R
		Then the stock should be
		| Ingredient	| Units		|		
		| Coffee		| 10		|
		| Decaf Coffee  | 10        |
		| Sugar			| 10		|
		| Cream			| 10        |
		| Steamed Milk	| 10		|
		| Foamed Milk   | 10        |
		| Espresso		| 10		|
		| Cocoa		    | 10        |
		| Whipped Cream | 10        |
