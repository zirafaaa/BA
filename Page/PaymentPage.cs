using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace BA.Page
{
    public class PaymentPage : BasePage
    {
        private IWebElement proceedButton => Driver.FindElement(By.CssSelector(".standard-checkout > span"));
        private IWebElement ProceedButtonAddress => Driver.FindElement(By.CssSelector(".button:nth-child(4) > span"));
        private IWebElement proceedButtonShipping => Driver.FindElement(By.CssSelector(".button.btn.btn-default.standard-checkout.button-medium"));
        private IWebElement checkbox => Driver.FindElement(By.Id("uniform-cgv"));
        private IWebElement totalPrice => Driver.FindElement(By.Id("total_price_container"));
        public PaymentPage(IWebDriver webdriver) : base(webdriver) { }
        public void ClickProceedButton()
        {
            Actions actions = new Actions(Driver);            
            actions.MoveToElement(proceedButton);
            proceedButton.Click();
            //actions.Perform();
        }
        public void ClickProceedButtonInAdress()
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(ProceedButtonAddress);
            ProceedButtonAddress.Click();
            //actions.Perform();
        }
        public void ClickProceedInShipping()
        {
            checkbox.Click();
            Actions actions = new Actions(Driver);
            actions.MoveToElement(proceedButtonShipping);
            proceedButtonShipping.Click();
            //actions.Perform();
        }
        public void VerifyTotalPrice()
        {
            Assert.AreEqual("$30.98", totalPrice, "Price is wrong"); //ta pati beda..nesuprantu kodel teksto nenuskaito
        }
    }
}
