using OpenQA.Selenium;


namespace BA.Page
{
    public class ShopHomePage : BasePage
    {
        private const string PageAddress = "http://automationpractice.com/index.php";
        private IWebElement searchField => Driver.FindElement(By.Id("search_query_top"));
        private IWebElement searchIcon => Driver.FindElement(By.CssSelector(".button-search"));
        private IWebElement singInButton => Driver.FindElement(By.CssSelector(".login"));
        public ShopHomePage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
        }
        public void ClickSingIn()
        {
            singInButton.Click();
        }
        public void ClickSearch(string text)
        {
            searchField.SendKeys(text);
            searchIcon.Click();

        }
    }
}
