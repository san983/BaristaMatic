Feature: Inventory And Menu Display
	In order to show inventory and available drinks
	As a client
	I want to be told the inventory of ingredients and available drinks with each correspondent cost

Scenario: Inventory Display at Startup
	Given a full loaded barista matic coffee machine with console
	Then the console output should read like this
		| OutputLine		| 		
		| Inventory:		| 	
		| Cocoa,10			|        
		| Coffee,10		| 		
		| Cream,10			|         
		| Decaf Coffee,10	|   
		| Espresso,10		| 	
		| Foamed Milk,10   |  
		| Steamed Milk,10	|
		| Sugar,10			|
		| Whipped Cream,10 |	
		| Menu:								| 	
		| 1,Caffe Americano,$3.30,true		|        
		| 2,Caffe Latte,$2.55,true			| 		
		| 3,Caffe Mocha,$3.35,true			|         
		| 4,Cappuccino,$2.90,true			|   
		| 5,Coffee,$2.75,true				| 	
		| 6,Decaf Coffee,$2.75,true		|        
		
Scenario: Dispensing an available drink
	Given a full loaded barista matic coffee machine with console
	When I press 2
	And I press q
	Then the console output should read like this
		| OutputLine		| 		
		| Inventory:		| 	
		| Cocoa,10			|        
		| Coffee,10		| 		
		| Cream,10			|         
		| Decaf Coffee,10	|   
		| Espresso,10		| 	
		| Foamed Milk,10   |  
		| Steamed Milk,10	|
		| Sugar,10			|
		| Whipped Cream,10 |	
		| Menu:								| 	
		| 1,Caffe Americano,$3.30,true		|        
		| 2,Caffe Latte,$2.55,true			| 		
		| 3,Caffe Mocha,$3.35,true			|         
		| 4,Cappuccino,$2.90,true			|   
		| 5,Coffee,$2.75,true				| 	
		| 6,Decaf Coffee,$2.75,true		|         
		| Dispensing: Caffe Latte		| 		
		| Inventory:		| 	
		| Cocoa,10			|        
		| Coffee,10		| 		
		| Cream,10			|         
		| Decaf Coffee,10	|   
		| Espresso,8		| 	
		| Foamed Milk,10   |  
		| Steamed Milk,9	|
		| Sugar,10			|
		| Whipped Cream,10 |	
		| Menu:								| 	
		| 1,Caffe Americano,$3.30,true		|        
		| 2,Caffe Latte,$2.55,true			| 		
		| 3,Caffe Mocha,$3.35,true			|         
		| 4,Cappuccino,$2.90,true			|   
		| 5,Coffee,$2.75,true				| 	
		| 6,Decaf Coffee,$2.75,true		|  


Scenario: Trying to dispense an non-available drink
	Given a full loaded barista matic coffee machine with console
	When I press 1
	And I press 1
	And I press 1
	And I press 1
	Then the console output should read like this
		| OutputLine		| 		
		| Inventory:		| 	
		| Cocoa,10			|        
		| Coffee,10		| 		
		| Cream,10			|         
		| Decaf Coffee,10	|   
		| Espresso,10		| 	
		| Foamed Milk,10   |  
		| Steamed Milk,10	|
		| Sugar,10			|
		| Whipped Cream,10 |	
		| Menu:								| 	
		| 1,Caffe Americano,$3.30,true		|        
		| 2,Caffe Latte,$2.55,true			| 		
		| 3,Caffe Mocha,$3.35,true			|         
		| 4,Cappuccino,$2.90,true			|   
		| 5,Coffee,$2.75,true				| 	
		| 6,Decaf Coffee,$2.75,true		|         
		| Dispensing: Caffe Americano		| 		
		| Inventory:		| 	
		| Cocoa,10			|        
		| Coffee,10		| 		
		| Cream,10			|         
		| Decaf Coffee,10	|   
		| Espresso,7		| 	
		| Foamed Milk,10   |  
		| Steamed Milk,10	|
		| Sugar,10			|
		| Whipped Cream,10 |	
		| Menu:								| 	
		| 1,Caffe Americano,$3.30,true		|        
		| 2,Caffe Latte,$2.55,true			| 		
		| 3,Caffe Mocha,$3.35,true			|         
		| 4,Cappuccino,$2.90,true			|   
		| 5,Coffee,$2.75,true				| 	
		| 6,Decaf Coffee,$2.75,true		|  
		| Dispensing: Caffe Americano		| 		
		| Inventory:		| 	
		| Cocoa,10			|        
		| Coffee,10		| 		
		| Cream,10			|         
		| Decaf Coffee,10	|   
		| Espresso,4		| 	
		| Foamed Milk,10   |  
		| Steamed Milk,10	|
		| Sugar,10			|
		| Whipped Cream,10 |	
		| Menu:								| 	
		| 1,Caffe Americano,$3.30,true		|        
		| 2,Caffe Latte,$2.55,true			| 		
		| 3,Caffe Mocha,$3.35,true			|         
		| 4,Cappuccino,$2.90,true			|   
		| 5,Coffee,$2.75,true				| 	
		| 6,Decaf Coffee,$2.75,true		|
		| Dispensing: Caffe Americano		| 		
		| Inventory:		| 	
		| Cocoa,10			|        
		| Coffee,10		| 		
		| Cream,10			|         
		| Decaf Coffee,10	|   
		| Espresso,1		| 	
		| Foamed Milk,10   |  
		| Steamed Milk,10	|
		| Sugar,10			|
		| Whipped Cream,10 |	
		| Menu:								| 	
		| 1,Caffe Americano,$3.30,true		|        
		| 2,Caffe Latte,$2.55,true			| 		
		| 3,Caffe Mocha,$3.35,true			|         
		| 4,Cappuccino,$2.90,true			|   
		| 5,Coffee,$2.75,true				| 	
		| 6,Decaf Coffee,$2.75,true		|  
		| Out of stock: Caffe Americano		| 		
		| Inventory:		| 	
		| Cocoa,10			|        
		| Coffee,10		| 		
		| Cream,10			|         
		| Decaf Coffee,10	|   
		| Espresso,1		| 	
		| Foamed Milk,10   |  
		| Steamed Milk,10	|
		| Sugar,10			|
		| Whipped Cream,10 |	
		| Menu:								| 	
		| 1,Caffe Americano,$3.30,true		|        
		| 2,Caffe Latte,$2.55,true			| 		
		| 3,Caffe Mocha,$3.35,true			|         
		| 4,Cappuccino,$2.90,true			|   
		| 5,Coffee,$2.75,true				| 	
		| 6,Decaf Coffee,$2.75,true		|  