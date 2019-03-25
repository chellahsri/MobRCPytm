Feature: MobRCPtm
	Do Mobile recharge on Paytm website

@mytag
Scenario: Mobile Recharge on Paytm
	Given I am paytm website rechage
	And I have entered Mobile number,Operator and the amount
	When I Click on Proceed to Recharge
	Then the result should be proceed to Proceed to Pay
