Feature: Accounts

@npm
@specflow
Scenario: Attempt Login Unsuccessfully
	Given I navigate to npm homepage
	When I press "login"
	And I input "Hello username" into "username"
	And I input "Hello password" into "password"
	When I press "submit"
	Then I should see an error message
	
@npm
@specflow
Scenario: Attempt Login Unsuccessfully and Sign Up
	Given I navigate to npm homepage
	When I press "login"
	And I input "Hello username" into "username"
	And I input "Hello password" into "password"
	When I press "submit"
	When I press "sign up"
	And I input "Hello fullname" into "fullname"
	And I input "Hello email" into "email"
	And I input "Hello username" into "username"
	And I input "Hello password" into "password"
	And I accept terms and conditions
	Then the submit button should be selectable