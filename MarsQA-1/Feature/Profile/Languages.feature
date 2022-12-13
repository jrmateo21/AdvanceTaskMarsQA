Feature: Languages

As a Seller
I want the feature to add Languages to my Profile Details
So that
The people seeking for some details can look into it.

@AddLanguagesDetails
Scenario: Seller is able to  add entry in Languages tab with valid details
	Given I login to the website
	When I navigate to Languages
	And  I add a new Language
	Then The language should be added successfully