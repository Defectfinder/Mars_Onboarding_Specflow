Feature: LanguageFeature

Add, update, and delete the languages

Scenario Outline:User can able to Add the Languages
	Given user logs into Mars Portal
	And navigates to Languages tab in Profile Page
	When user enters Language "<Language>" and Language Level "<Level>"
	Then the language "<Language>" should be added to Languages tab in Profile Page

Examples:
	| Language      | Level                 |
	| English       | Choose Language Level |
	| 123French++	| Basic                 |
	|               | Choose language level |
	|               | Basic                 |
	| Tamil	        | Fluent                |
	| Telugu	    | Conversational        |

Scenario Outline: User can edit the added Language
	Given user logs into Mars Portal
	And navigates to Languages tab in Profile Page
	When user edits Language "<Language>" and Language Level "<Level>"
	Then the language "<Language>" should be edited into Languages tab in Profile Page
Examples:
	| Language	| Level          |
	| Spanish	| Basic          |
	| Telugu	| Conversational |

Scenario Outline: User can delete the language
	Given user logs into Mars Portal
	And navigates to Languages tab in Profile Page
	When user deletes the Language "<Language>"
	
Examples:
	| Language | Level  |
	| Spanish | Basic |




