Feature: Homepage

@npm
@specflow
Scenario: Link through header navigation
	Given I navigate to npm homepage
	When I click on all header links
	Then I will finish on the "support page" page

@npm
@specflow
Scenario: Link through footer navigation
	Given I navigate to npm homepage
	When I click on all footer links
	Then I will finish on the "home page" page

@npm
@specflow
Scenario: Select a search result
	Given I navigate to npm homepage
	When I search for a "chatbot" package and I select number 1
	Then I will finish on the "chatbot" page