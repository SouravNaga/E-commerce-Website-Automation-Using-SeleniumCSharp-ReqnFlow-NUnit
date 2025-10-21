Feature: Verify Product search feature
Background: 
	Given Open the browser
	When Login the url
	Given Click on the Login button
	Then enter email
	And enter valid password
	And click Login button
	Then Verify Login successful or not
@product
Scenario: Seach feature any product
	Given Select below product item
	| Field     | Value         |
    | product      | Apparel & Shoes        |
	Then Fetch all products names
	And  select third product
	Then Verify correct product displaying or not
	And Fetch all details for the product
	And Click Add to cart button
	Then Click Shopping cart link
	Then Verify product cut successful or not

