using OpenQA.Selenium.Chrome;

namespace Test.Support
{
    public class SingleWebDriver
    {
        private static IWebDriver _instance;

        private SingleWebDriver() { }

        public static IWebDriver GetInstance(ChromeOptions options = null)
        {
            if (_instance == null)
            {
                if (options == null)
                {
                    _instance = new ChromeDriver();
                }
                else
                {
                    _instance = new ChromeDriver(options);
                }
            }
            return _instance;
        }

        public static void QuitChrome()
        {
            _instance.Quit();
            _instance = null;
        }
    }
}