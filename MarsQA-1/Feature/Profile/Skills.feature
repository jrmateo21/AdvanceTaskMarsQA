Feature: Skills

As a Seller
I want the feature to add Skills to my Profile Details
So that
The people seeking for some details can look into it.

@AddSkills
Scenario: Seller is able to  add entry in Skills tab with valid details
	Given I login to the website
	When I navigate to Skills Tab
	And  I add a new skills , '<Skill>' , '<Level>'
	Then The Skill should be added successfully, '<Skill>' , '<Level>'
	Examples: 
		| Skill   | Level        |
		| Python  | Beginner     |
		| Testing | Intermediate |