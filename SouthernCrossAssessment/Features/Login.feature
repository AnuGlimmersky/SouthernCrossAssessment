Feature: User Registration
As a visitor
I want to be able to register in the website
So that I can vote for a sport car

Scenario: Password validation for valid password
	Given that I am in registration page
	When I enter a valid password
	Then I should not see a password validation error

	
Scenario: Password validation for invalid password
	Given that I am in registration page
	When I enter an invalid password
	Then I should see a password validation error

