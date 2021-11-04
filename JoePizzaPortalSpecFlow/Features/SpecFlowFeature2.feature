Feature: Confirmfeature
	Confirm if the order is placed

@Confirmfeature
Scenario: Get Order Details
	Given the order id is 19
	Then order quantity should be 2
	Then the card number should be 256798907865
	Then the shipping adress should be 1st Cross, HM Marg, New Delhi
	Then the Pizza Id should be 4
	Then the Pizza Type should be Veg