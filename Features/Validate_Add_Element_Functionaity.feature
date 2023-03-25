Feature: Add element funtionality at herokuapp
	
	
@Regression
Scenario: Validate 8 Element added in Add/Remove Elements Page

    Given user navigates into "https://the-internet.herokuapp.com/add_remove_elements/"
	When user clicks add element BTN "8" times 
	Then Verify user see "8" Delete BTN generated