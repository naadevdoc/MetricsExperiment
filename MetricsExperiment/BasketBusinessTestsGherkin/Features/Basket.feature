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
