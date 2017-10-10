Feature: Argument
	TO Demo passing of argument value from the feature file

Background: Pre-COndition
	#Given Step
	Given User is at Home Page wit url "http://localhost:5001/"
	And File  a Bug should be visible

	@ignore
	Scenario: Login scenario of BugZilla

	When I Click on "File a Bug" link
	Then User should be at Login Page with title "Log in to Bugzilla"
	When I provid "vino@bugzila.com", "bnvino6#BNV" and click on Login button
	Then User should be at Enter Bug Page with title "Enter Bug: TestProduct"
	When I click on Logout button at enter bug page
	Then User should be logged out and should be at Home Page

	@ignore
	Scenario: Create Bug scenario of Bugzilla
	
	When I Click on "File a Bug" link
	Then User should be at Login Page with title "Log in to Bugzilla"
	When I provid "vino@bugzila.com", "bnvino6#BNV" and click on Login button
	Then User should be at Enter Bug Page with title "Enter Bug: TestProduct"
	When I provide the severity, Hardware, platform, summary and Desc
	| Severity | Hardware  | OS    | Summary     | Desc            |
	| blocker  | Other     | Linux | Summary one | Description one |
	| major    | Macintosh | Other | Summary tow | Description two |
	And click on Submit button in Page
	Then Bug should get created and 
	And USer should be at search page
	When I click on Logout button at bug detail page
	Then User should be logged out and should be at Home Page

	Scenario Outline: Create Bug scenario of Bugzilla with scenario outline
	When I Click on "<fLink>" link
	Then User should be at Login Page with title "<lTitle>"
	When I provid "<User>", "<Password>" and click on Login button
	Then User should be at Enter Bug Page with title "<eTitle>"
	When I provide the "<Severity>", "<Hardware>", "<Platform>", "<Summary>" and "<Desc>"
	And click on Submit button in Page
	Then Bug should get created and 
	And USer should be at search page
	When I click on Logout button at bug detail page
	Then User should be logged out and should be at Home Page
	Examples: 
	| TestCase | fLink      | lTitle             | User             | Password    | eTitle                 | Severity | Hardware  | Platform | Summary     | Desc            |
	| A        | File a Bug | Log in to Bugzilla | vino@bugzila.com | bnvino6#BNV | Enter Bug: TestProduct | blocker  | Other     | Linux    | Summary one | Description one |
	| B        | File a Bug | Log in to Bugzilla | vino@bugzila.com | bnvino6#BNV | Enter Bug: TestProduct | major    | Macintosh | Other    | Summary tow | Description two |