Feature: Login and Create Bug feature of the bugzilla
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: Pre-COndition
	#Given Step
	Given User is at Home Page
	And File  a Bug should be visible

@mytag
Scenario: Login scenario of BugZilla

	When I Click on File a Bug link
	Then User should be at Login Page
	When I provid username, password and click on Login button
	Then User should be at Enter Bug Page
	#But I provide the wrong username and password
	#Then Login page should display the error message
	When I click on Logout button
	Then User should be logged out and should be at Home Page

Scenario: Create Bug scenario of Bugzilla
	
	When I Click on File a Bug link
	Then User should be at Login Page
	When I provid username, password and click on Login button
	Then User should be at Enter Bug Page
	When I provide the severity, Hardware, platfor and summary
	And click on Submit button
	Then Bug should get created and 
	And USer should be at search page
	When I click on Logout button
	Then User should be logged out and should be at Home Page
	
