namespace Test.PageObjects
{
    public class GoogleSearchPage
    {
        public IWebElement LinkByndyusoftWebsite => _driver.FindElement(By.XPath("//*[@href='https://byndyusoft.com/']"));

        private IWebDriver _driver;

        public GoogleSearchPage()
        {
            _driver = SingleWebDriver.GetInstance();
        }

        public void ClickByndyusoftWebsiteLink()
        {
            LinkByndyusoftWebsite.Click();
        }
    }
}
