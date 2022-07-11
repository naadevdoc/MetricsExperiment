Feature: Basket
As a Customer
I want to get information of checked products in my cart
So I can know how much money will cost me
Background:
	Given the catalogue has following products
	  | product                 | price | currency | discount |
	  | motion-cam-hero-09-2019 | 10    | EUR      | 10%      |
	  | motion-cam-hero-10-2021 | 10    | EUR      | 0%       |
	  | phone-hero-13-2022      | 1342  | EUR      | 0%       |
	  | phone-hero-12-2019      | 999   | EUR      | 5%       |
	And these personas are registered
	  | Name        | Fidelity discount | Preferred currency |
	  | David       | 0%                | EUR                |
	  | Maria       | 20%               | EUR                |
	  | Paul        | 0%                | USD                |
	  | Oshiro      | 10%               | JPY                |
	  | Jules       | 5%                | JPY                |
	And the exchange rate at the time of operation is as follows
	  | From Currency | To Currency | Rate    |
	  | EUR           | USD         | 1.134   |
	  | USD           | EUR         | 0.881   |
	  | USD           | JPY         | 114.386 |
	  | JPY           | USD         | 0.009   |
	  | JPY           | EUR         | 0.008   |
	  | EUR           | JPY         | 129.737 |


Rule: Persona can check in products without purchasing
@executedInDelta00
Scenario: Delta00->This is a dummy scenario to illustrate architecture
	Given I create a sample answer request
	When I send the request to the service
	Then the content of sample answer response will be 'true'

@executedInDelta00
@executedInDelta01
Scenario: Delta01->A persona can check in a single product
	Given I am David
	And I am having an empty cart
	And I check in a product 'motion-cam-hero-10-2021'
	When I list checked in products
	Then there will be a single product with code 'motion-cam-hero-10-2021'
	And cart total will be 10 EUR

@executedInDelta00
@executedInDelta01
@executedInDelta02
Scenario: Delta02->A persona can check in same product several times
	Given I am David
	And I am having an empty cart
	And I add following products to my cart 2 times
	 | product                 |
	 | motion-cam-hero-10-2021 |	 
	When I list checked in products
	Then following products will be found
	 | product                 | prize |
	 | motion-cam-hero-10-2021 | 10    |
	 | motion-cam-hero-10-2021 | 10    |
	And total cost will be 20 EUR

@executedInDelta00
@executedInDelta01
@executedInDelta02
@executedInDelta03
Scenario: Delta03->A persona can also check in several products
	Given I am David
	And I am having an empty cart
	And I add following products to my cart
	 | product                 |
	 | motion-cam-hero-10-2021 |
	 | phone-hero-13-2022      |
	When I list checked in products
	Then following products will be found
	 | product                 | prize |
	 | motion-cam-hero-10-2021 | 10    |
	 | phone-hero-13-2022      | 1342  |
	And cart total will be 1352 EUR

@executedInDelta00
@executedInDelta01
@executedInDelta02
@executedInDelta03
@executedInDelta04
Scenario: Delta04->A persona can check in a product and pay in a different currency than preferred one
	Given I am Paul
	And I am having an empty cart
	And I check in a product 'motion-cam-hero-10-2021'
	When I list checked in products
	Then there will be a single product with code 'motion-cam-hero-10-2021'
	And cart total will be 11.34 USD
	
Rule: A persona can purchase a previously checked in product
@executedInDelta00
@executedInDelta01
@executedInDelta02
@executedInDelta03
@executedInDelta04
@executedInDelta05
Scenario: Delta05->A persona purchases a checked in product
	Given I am Paul
	And I check in a product 'motion-cam-hero-10-2021'
	When I purchase my product
	Then I will receive a message 'Thank you for your purchase'
	