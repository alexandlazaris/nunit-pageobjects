Feature: Homepage

@specflow
Scenario: Link through header navigation
	Given I open "browser"
	When I navigate to npm homepage
	And I click on all header links
	Then I will finish on the support page
