# specflow-multibrowser-bdd
Starting point for writing high level acceptance tests. Also prints out .html report

Currently covers Chrome, Edge, Firefox and IE11. 

To continue, add required page objects and design steps + feature files to your needs.

### The difference

To run your scenarios in more than 1 browser, you may end up bloating your Feature file to look like this:
```
Scenario: Load Google in MultiBrowser
	Given I open "Chrome"
	And I navigate to "http://www.google.com"
	Then I have successfully loaded the homepage
	Then I close the browser
  
Scenario: Load Edge in MultiBrowser
	Given I open "Edge"
	And I navigate to "http://www.google.com"
	Then I have successfully loaded the homepage
	Then I close the browser
 ```

Instead, you can loop through the steps with predefined values, where <browser> can be interchanged with values you set below in the ```Scenarios``` table.

```
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
```

### Edge

- When creating edge driver, you must add the .exe directory as constructor arguments
- Right click edge driver, open properties and tick "Unblock". Similar to MacOS preventing you from opening applications