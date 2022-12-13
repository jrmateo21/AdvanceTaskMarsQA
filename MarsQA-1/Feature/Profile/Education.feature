Feature: Education

As a Seller
I want the feature to add Skills to my Profile Details
So that
The people seeking for some details can look into it.

@AddEducation
Scenario: Seller is able to  add entry in Skills tab with valid details
	Given I login to the website
	When I navigate to   Education Tab
	And  I add a new Education , '<Country>' , '<University>', '<Title>', '<Degree>' , '<GraduationYear>'
	Then The Skill should be added successfully, '<Country>' , '<University>', '<Title>', '<Degree>' , '<GraduationYear>'
	Examples: 
		| Country     | University               | Title | Degree                 | GraduationYear |
		| Philippines | Bulacan State University | B.Sc  | Information Technology | 2010           |
		| New Zealand | AUT                      | B.Sc  | Data Analytics         | 2015           |


@UpdateEducation
Scenario: Seller is able to  Update entry in Skills tab with valid details
	Given I login to the website
	When I navigate to   Education Tab
	And  I  Update   Education entry  , '<Country>' , '<University>', '<Title>', '<Degree>' , '<GraduationYear>'
	Then The Skill should be Updated successfully, '<Country>' , '<University>', '<Title>', '<Degree>' , '<GraduationYear>'
	Examples: 
		| Country | University                       | Title | Degree                         | GraduationYear |
		| Jamaica | Updated-Bulacan State University | B.Sc  | Updated-Information Technology | 2011           |
		| Libya   | Updated-AUT                      | B.Sc  | Updated-Data Analytics         | 2013           |

				