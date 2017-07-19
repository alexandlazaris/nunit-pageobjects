Feature: Homepage

@smoke	
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

@searchResults
Scenario Outline: Select 1st search result
	Given I open <browser>
	And I navigate to "http://www.google.com"
	When I enter in "text" into locator "input#lst-ib"
	When I press this "button#_fZl"
	Then I wait for "2000" seconds 
	When I press this "div._NId:nth-child(1) h3.r a:nth-child(1)"
	Then I wait for "5000" seconds
	Then I close the browser 
Scenarios: 
| browser |
| Chrome  |
| Firefox |
| IE11    |
| Edge    |