Feature: User Registration
As a visitor
I want to be able to register in the website
So that I can vote for a sport car

Scenario: User successfully registers with valid details
	Given that I am in the Buggy Cars registration page
	When I have filled username as 'JaneDoe5565', First name as 'Jane' and Last name as 'Doe'
	And I enter password and confirm password as 'testUserPw1.'
	And I click Register button
	Then I should see a registration successful message

Scenario: User should only be able to register once with same username
	Given that I am in the Buggy Cars registration page
	When I have filled username as 'JaneDoe', First name as 'Jane' and Last name as 'Doe'
	And I enter password and confirm password as 'testUserPw1.'
	And I click Register button
	Then I should see an error message for duplicate username

Scenario: Password validation for password with no uppercases character
	Given that I am in the Buggy Cars registration page
	When I have filled username as 'JaneDoe', First name as 'Jane' and Last name as 'Doe'
	And I enter password and confirm password as 'testuserpw1.'
	And I click Register button
	Then I should see a password validation error for missing uppercase
	
Scenario: Password validation for password with no special character
	Given that I am in the Buggy Cars registration page
	When I have filled username as 'JaneDoe', First name as 'Jane' and Last name as 'Doe'
	And I enter password and confirm password as 'testUserPw1'
	And I click Register button
	Then I should see a password validation error for missing special character

Scenario: Password validation for password with no lowercase character
	Given that I am in the Buggy Cars registration page
	When I have filled username as 'JaneDoe', First name as 'Jane' and Last name as 'Doe'
	And I enter password and confirm password as 'TESTUSERPW1.'
	And I click Register button
	Then I should see a password validation error for missing lowercase
	
Scenario: Password validation for password with incorrect character length
	Given that I am in the Buggy Cars registration page
	When I have filled username as 'JaneDoe', First name as 'Jane' and Last name as 'Doe'
	And I enter password and confirm password as 'Test'
	And I click Register button
	Then I should see a password validation error for incorrect length



	 