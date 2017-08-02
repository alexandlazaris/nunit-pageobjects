# specflow-multibrowser-bdd
Starting point for writing high level acceptance tests. Add Page Objects with custom selectors and methods, create tests and reuse.

Currently to edit target browser:
1. Open App.config
2. Edit ```Browser``` key to equal ```Chrome```, ```Firefox```, ```IE``` or ```Edge```

## Example of test class

```[TestMethod]
        public void LinkThroughHeaderNavigation()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            npmHome.ClickAllHeaderLinks();
            Assert.IsTrue(ObjectSetup.Driver.Url.Equals("https://www.npmjs.com/support"));
        }
```

### Extras

* Captures screenshots of page on Exceptions when finding elements. Can be expanded to cover other scenarios