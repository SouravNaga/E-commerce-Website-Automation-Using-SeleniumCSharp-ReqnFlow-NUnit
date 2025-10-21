Feature: Verify Login feature

Background: 
	Given Open the browser
	When Login the url
@login
Scenario: Login feature with valid creds
	Given Click on the Login button
	Then enter email
	And enter valid password
	And click Login button
	Then Verify Login successful or not
