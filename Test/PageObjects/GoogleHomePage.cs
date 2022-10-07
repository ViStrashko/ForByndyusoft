namespace Test.PageObjects
{
    public class GoogleHomePage
    {
        public IWebElement TextBoxSearch => _driver.FindElement(By.XPath("//*[@title='Поиск']"));

        private IWebDriver _driver;

        private const string PageUrl = "https://www.google.ru/";

        public GoogleHomePage()
        {
            _driver = SingleWebDriver.GetInstance();
        }

        public void OpenThisPage()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(PageUrl);
        }

        public void EnterSearchText(string searchText)
        {
            TextBoxSearch.SendKeys(searchText);
        }

        public void ClickEnter()
        {
            new Actions(_driver).SendKeys(Keys.Enter).Build().Perform();
        }
    }
}
