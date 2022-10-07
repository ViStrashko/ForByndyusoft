namespace Test.PageObjects
{
    public class ByndyusoftHomePage
    {
        public IWebElement ButtonOrderPresentation => _driver.FindElement(By.XPath("//*[@class='know-more__container']/span"));
        public IWebElement LinkMailbox => _driver.FindElement(By.XPath("//*[@class='popup-callback__footer-contacts']/*"));

        private IWebDriver _driver;

        public ByndyusoftHomePage()
        {
            _driver = SingleWebDriver.GetInstance();
        }

        public void SwitchToСurrentWindow()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        }

        public void ScrollToEndByndyusoftHomePage()
        {
            new Actions(_driver).SendKeys(Keys.Control + Keys.End).Build().Perform();
        }

        public void ClickOrderPresentationButton()
        {
            ButtonOrderPresentation.Click();
        }
    }
}
