Feature: Login

@mytag
Scenario: Login as Administrator User
	Given I navigate to the Application
	And I click the Login link
	And I enter Username and Password
		| UserName | Password |
		| admin    | password    |
	And I click Login
	Then I should see user logged in to the Application