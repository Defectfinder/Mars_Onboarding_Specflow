Feature: SkillFeature

Add, Update and delete the Skill
@tag1
Scenario Outline: User able to add the Skills
	Given User logs into Mars Portal
	And navigates to Skills tab in Profile Page
	When user enters Skill "<Skill>" and Skill Level "<Level>"
	Then the Skill "<Skill>" should be added to Skills tab in Profile Page
Examples:
	| Skill         | Level              |
	| Multitasking  | Intermediate       |
	| Or++**123on   | Beginner           |
	|               | Choose Skill Level |
	|               | Intermediate       |
	| Music			| Expert             |
Scenario Outline: User able to edit the Skills
	Given User logs into Mars Portal
	And navigates to Skills tab in Profile Page
	When user edits Skill "<Skill>" and Skill Level "<Level>"
	Then the Skill "<Skill>" should be updated to Skills tab in Profile Page
Examples:
	| Skill       | Level              |
	| Multitasker | Beginner           |
	|             | Choose Skill Level |
	| Test++      | Expert             |


Scenario: User able to delete the Skill
	Given User logs into Mars Portal
	And navigates to Skills tab in Profile Page
	When Delete the Skill
	