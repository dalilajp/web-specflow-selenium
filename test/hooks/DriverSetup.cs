namespace web_specflow_selenium.hooks
{
    using BoDi;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using TechTalk.SpecFlow;

    [Binding]
    public class DriverSetup
    {
        private IObjectContainer _objectContainer;
        public IWebDriver Driver;

        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver(@"C:\workspace\test\web-specflow-selenium\drivers");
            _objectContainer.RegisterInstanceAs(Driver);
        }

    }
}

