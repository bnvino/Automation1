Feature: TestFeature2
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
	When I provid "vino@bugzila.com", "bnvino6#BNV" and click on Login button
	Then User should be at Enter Bug Page
	When I click on Logout button
	Then User should be logged out and should be at Home Page
