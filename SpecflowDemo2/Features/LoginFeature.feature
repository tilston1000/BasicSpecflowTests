Feature: Login_Feature
	In order to access my account
	As a user of the website
	I want to log into the website

@mytag
Scenario Outline: Successful login with Valid Credentials
	Given User is at the Home Page
	And navigates to the Login Page
	When the user enters <username> and <password>
	And clicks on the Login button
	Then the Success login message should be displayed
Examples:
| username    | password    |
| testuser_1  | test@153 |
| testuser_2  | test@153    |

Scenario: Successful Logout
	When the user logs out of the application
	Then the Success logout message should be displayed

