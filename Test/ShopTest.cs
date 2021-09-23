using NUnit.Framework;


namespace BA.Test
{
    public class ShopTest : BaseTest
    {
        [Test]
        public static void TestSearchResult()
        {
            _shopHomePage.NavigateToPage();            
            _shopHomePage.ClickSearch("dress");
            _searchPage.VerifySearchResult("Printed Summer Dress");
        }
        [Test]
        public static void TestAddToCard()
        {
            _shopHomePage.NavigateToPage();            
            _shopHomePage.ClickSearch("dress");
            _searchPage.AddToCard();
            _searchPage.VerifySuccessfulAddToCard();
        }
        [Test]
        public static void TestPaymentPage()
        {
            _shopHomePage.NavigateToPage();
            _shopHomePage.ClickSingIn();
            _loginPage.EnterLoginInput();
            _shopHomePage.ClickSearch("dress");
            _searchPage.AddToCard();
            _searchPage.ContinueToPayment();
            _paymentPage.ClickProceedButton();
            _paymentPage.ClickProceedButtonInAdress();
            _paymentPage.ClickProceedInShipping();
            _paymentPage.VerifyTotalPrice();
            
        }
    }
}
