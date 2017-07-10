Feature: Homepage
	
Scenario Outline: Load Google in MultiBrowser
	Given I open <browser>
	And I navigate to "http://www.google.com"
	Then I have successfully loaded the homepage
	Then I close the browser
Scenarios: 
| browser |
| Chrome  |
| Firefox |
| IE11    |
| Edge    |

