Feature: Verify Register feature

Background: 
	Given Open the browser
	When Login the url
@register
Scenario: Register feature with valid creds
	Given Click on the Register button
	When Fill all details with valid data
	| Field     | Value         |
    | Gender      | male        |
    | Firstname       | sourav            |
    | Lastname   | naga         |
#	| Email   | sourav123a@gmail.com         |
	Then enter gmail
	Then enter password
	And enter confirm password
	And click Register button
	Then Verify register successful or not
