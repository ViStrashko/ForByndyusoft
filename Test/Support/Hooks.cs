namespace Test.Support
{
    [Binding]
    public sealed class Hooks
    {
        public Hooks()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
            SingleWebDriver.QuitChrome();
        }
    }
}