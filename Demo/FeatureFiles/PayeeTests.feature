Feature: Payee Tests

This is a demo of the framework, testing the Payee page

Scenario: Verify you can navigate to Payees page using the navigation menu
	Given that the user is in the Home page
	When the user clicks the Menu element
	And the user clicks the Payees element 
	Then the user should be in the Payees page
	And the page should load completely under 4000 milliseconds

Scenario: Verify you can add new payee in the Payees page
	Given that the user is in the Payees page
	When the user clicks the Add element
	And the user enters the payee details
	And the user clicks the Add Payee element
	Then the user added Payee should be present

Scenario: Verify payee name is a required field
	Given that the user is in the Payees page
	When the user clicks the Add element
	And the user clicks the Add Payee element
	Then the following error message should show when clicking an input field
	| inputField             | errorMessage                                                     |
	| ComboboxInput-apm-name | Payee Name is a required field. Please complete to continue.     |
	When the user provides a Payee name
	And the user clicks the Add Payee element
	Then the following error message should show when clicking an input field
	| inputField  | errorMessage                                                     |
	| apm-bank    | Bank Code is a required field. Please complete to continue.      |
	| apm-branch  | Branch Code is a required field. Please complete to continue.    |
	| apm-account | Account Number is a required field. Please complete to continue. |
	| apm-suffix  | Suffix is a required field. Please complete to continue.         |
	When the user enters the payee details
	Then no error messages should be shown

Scenario: Verify that payees can be sorted by name
	Given that the user is in the Payees page
	Then the payee list should be ordered alphabetically
	When the user clicks the Name element
	Then the payee list should be ordered alphabetically reversed
