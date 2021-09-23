using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace BA.Page
{
   public class SearchPage : BasePage
    {
        
        string productName => Driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(1) > div > div.right-block > h5 > a")).Text;
        private IWebElement firstElement => Driver.FindElement(By.CssSelector(".ajax_block_product.col-xs-12.col-sm-6.col-md-4.first-in-line.first-item-of-tablet-line.first-item-of-mobile-line"));
        private IWebElement successfulMessage => Driver.FindElement(By.CssSelector(".ajax_cart_product_txt_s:nth-child(1)"));
        private IWebElement addToCardButton => Driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(1) > div > div.right-block > div.button-container > a.button.ajax_add_to_cart_button.btn.btn-default"));
        
        public SearchPage(IWebDriver webdriver) : base(webdriver) { }
        public void VerifySearchResult(string text) 
        {

            Assert.AreEqual(text, productName, "Text is wrong");
            
        }
        public void AddToCard()
        {

            Actions actions = new Actions(Driver);
            IWebElement imagineElemenet = firstElement.FindElement(By.CssSelector(".replace-2x.img-responsive"));
            actions.MoveToElement(imagineElemenet);
            actions.Perform();
            addToCardButton.Click();
        }

        
        public void VerifySuccessfulAddToCard()
        {
           
            Assert.AreEqual("There is 1 item in your cart.", successfulMessage, "Text is wrong"); //nesuprantu, kodel neranda teksto...
        }
        public void ContinueToPayment()
        {
            IWebElement continueButton = Driver.FindElement(By.CssSelector(".btn.btn-default.button.button-medium"));
            continueButton.Click();
        }
    }
}
