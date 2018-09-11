Feature: Scrum Training
	In order to book scrum trainings
	As an interested customer
	I want to see the scrum training information

@mytag
Scenario: Navigating to Scrum Training landing page
	Given I am on the homepage
	When I click on the menu
	And I click on scrum trainings
	Then I should be navigated to "scrum-trainings-koeln"
