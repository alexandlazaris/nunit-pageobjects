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

### Creating tests and files
1. Delete current test files within ```.\Tests``` and also page object files within ```.\PageObjects```
2. Create a new Page Object within ```.\PageObjects``` that inherits ```BasePageObject```
	* You can use this class to add shared methods and properties across pages, otherwise, leave as is
3. Within new Page Object constructure, pass in ```IWebDriver``` to new class and to base class
4. From here on, it's full steam ahead for you new page :steam_locomotive:
5. When ready, you can finally create tests :smirk:
	* Use ```[TestInitialize]``` to initialize your Page Objects before your test runs
	* Create your tests with ```[TestMethod]``` and run your new framework :runner:

### Editing driver options
To edit target browser :computer:: 
1. Open App.config
2. Edit ```Browser``` key to equal ```Chrome```, ```Firefox```, ```IE``` or ```Edge```

### Executing in MSTest

1. Open your chosen CLI and ```cd``` to	```C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE>``` (this is for .NET 4.6, VS Community 207, Windows 10. Directory may differ for various versions)
2. Apped ```MSTest.exe``` with the path to your project .dlls. My command looked like ```.\MSTest.exe /testcontainer:C:\path\to\project\bin\Debug\BDD.dll```
3. Press ```enter``` and your tests will run. A new CLI window will appear with test logs and will close once complete
4. Append ```/resultsfile:C:\path\to\project\TestResults\``` to output results (a .trx (xml-kind-of) file into a directory)

For more MSTest.exe options, visit https://msdn.microsoft.com/en-us/library/ms182489(v=vs.110).aspx

### Extras

* :camera: Captures screenshots of page on Exceptions when finding elements. Can be expanded to cover other scenarios