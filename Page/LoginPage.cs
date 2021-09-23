using OpenQA.Selenium;


namespace BA.Page
{
   public class LoginPage : BasePage
    {
        private IWebElement emailInput => Driver.FindElement(By.Id("email"));
        private IWebElement passwordInput => Driver.FindElement(By.Id("passwd"));
        private IWebElement singInButton => Driver.FindElement(By.Id("SubmitLogin"));
        public LoginPage(IWebDriver webdriver) : base(webdriver) { }
        public void EnterLoginInput()
        {
            emailInput.SendKeys("egidijake@gmail.com");
            passwordInput.SendKeys("Testas");
            singInButton.Click();
        }
    }
}
