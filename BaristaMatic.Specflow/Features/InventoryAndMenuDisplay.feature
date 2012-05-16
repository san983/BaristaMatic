Feature: Inventory And Menu Display
	In order to show inventory and available drinks
	As a client
	I want to be told the inventory of ingredients and available drinks with each correspondent cost

Scenario: Inventory Display at Startup
	Given a full loaded barista matic coffee machine
	When I start the machine
	Then the console output should read like this
		| OutputLine		| 		
		| Inventory:		| 	
		| _Cocoa,10			|        
		| _Coffee,10		| 		
		| _Cream,10			|         
		| _Decaf Coffee,10	|   
		| _Espresso,10		| 	
		| _Foamed Milk,10   |  
		| _Steamed Milk,10	|
		| _Sugar,10			|
		| _Whipped Cream,10 |	
		| Menu:								| 	
		| _1,Caffe Americano,$3.30,true		|        
		| _2,Caffe Latte,$2.55,true			| 		
		| _3,Caffe Mocha,$3.35,true			|         
		| _4,Cappuccino,$2.90,true			|   
		| _5,Coffee,$2.75,true				| 	
		| _6,Decaf Coffee,$2.75,true		|         
