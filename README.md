# nunit-pageobjects

Starting point for writing high level acceptance tests. Add Page Objects with custom selectors and methods, create tests and reuse.

## Example of test class

```[TestMethod]
        public void LinkThroughHeaderNavigation()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            npmHome.ClickAllHeaderLinks();
            Assert.IsTrue(ObjectSetup.Driver.Url.Equals("https://www.npmjs.com/support"));
        }
```

## Starting out

1. Delete current test files within ```.\Tests``` and also page object files within ```.\PageObjects```
2. Create a new Page Object within ```.\PageObjects``` that inherits ```BasePageObject```
	* You can use this class to add shared methods and properties across pages, otherwise, leave as is
3. Within new Page Object constructure, pass in ```IWebDriver``` to new class and to base class
4. From here on, it's full steam ahead for you new page :steam_locomotive:
5. When ready, you can finally create tests :smirk:
	* Use ```[TestInitialize]``` to initialize your Page Objects before your test runs
	* Create your tests with ```[TestMethod]``` and run your new framework :runner:

To edit target browser :computer:: 
1. Open App.config
2. Edit ```Browser``` key to equal ```Chrome```, ```Firefox```, ```IE``` or ```Edge```


### Extras

* :camera: Captures screenshots of page on Exceptions when finding elements. Can be expanded to cover other scenarios