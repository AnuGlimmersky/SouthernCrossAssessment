Feature: User Registration
As a visitor
I want to be able to register in the website
So that I can vote for a sport car

Scenario: User successfully registers with valid details
	Given that I have navigated to Buggy Cars website
	And I have clicked on Register button
	And I have filled username as 'JaneDoe', First name as'Jane' and Last name as 'Doe'
	When I enter valid password and confirm password as 'testUser1.'
	And I click Register button
	Then I should see a registration successful message

#	
#Scenario: Password validation for password with no uppercases character
#	Given that I am in registration page
#	When I enter a password with no uppercases
#	Then I should see a password validation error
#	
#Scenario: Password validation for password with no special character
#	Given that I am in registration page
#	When I enter a password with no special characters
#	Then I should see a password validation error
#
#	
#Scenario: Password validation for password with no lowercase character
#	Given that I am in registration page
#	When I enter a password with no special characters
#	Then I should see a password validation error
#
#	
#Scenario: Password validation for password with incorrect character length
#	Given that I am in registration page
#	When I enter a password with no special characters
#	Then I should see a password validation error
#
#	

	 