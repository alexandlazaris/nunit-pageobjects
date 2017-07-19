Feature: Homepage
	
Scenario Outline: Load Google in MultiBrowser
	Given I open <browser>
	And I navigate to "http://www.google.com"
	Then I have successfully loaded the homepage
	Then I close the browser

Scenario Outline: Click onto all Search Result links
	Given I open <browser>
	And I navigate to "http://www.google.com"
	When I send keys "Google" to "input#lst-ib" 

Scenarios: 
| browser |
| Chrome  |
| Firefox |
| IE11    |
| Edge    |