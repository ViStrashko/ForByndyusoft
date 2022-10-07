namespace Test.StepDefinitions
{
    [Binding]
    public class TestContactsStepDefinitions
    {
        [Given(@"Open page Google")]
        public void GivenOpenPageGoogle()
        {
            var page = new GoogleHomePage();
            page.OpenThisPage();
        }

        [Given(@"In the search box type ""([^""]*)""")]
        public void GivenInTheSearchBoxType(string searchText)
        {
            var page = new GoogleHomePage();
            page.EnterSearchText(searchText);
            page.ClickEnter();
        }

        [Given(@"Follow the link of Byndyusoft")]
        public void GivenFollowTheLinkOfByndyusoft()
        {
            var page = new GoogleSearchPage();
            page.ClickByndyusoftWebsiteLink();
        }

        [When(@"Click on the yellow Order presentation button")]
        public void WhenClickOnTheYellowOrderPresentationButton()
        {
            var page = new ByndyusoftHomePage();
            page.SwitchTo—urrentWindow();
            page.ScrollToEndByndyusoftHomePage();
            page.ClickOrderPresentationButton();
        }

        [Then(@"Expected mailbox ""([^""]*)""")]
        public void ThenExpectedMailbox(string expectedMailbox)
        {
            var page = new ByndyusoftHomePage();
            var actualMailbox = page.LinkMailbox.Text;
            Assert.Equal(expectedMailbox, actualMailbox);
        }
    }
}
