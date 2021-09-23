using BA.Drivers;
using BA.Page;
using BA.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;


namespace BA.Test
{
    public class BaseTest
    {
        protected static IWebDriver driver;

        public static ShopHomePage _shopHomePage;
        public static SearchPage _searchPage;
        public static PaymentPage _paymentPage;
        public static LoginPage _loginPage;
      





        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = CustomDriver.GetChromeWithSpecOptions();

            _shopHomePage = new ShopHomePage(driver);
            _searchPage = new SearchPage(driver);
            _paymentPage = new PaymentPage(driver);
            _loginPage = new LoginPage(driver);

        }


        [TearDown]
        public static void Screenshots()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshots.TakeScreenshot(driver);
            }

        }

        [OneTimeTearDown]
        public static void TearDown()
        {

            driver.Quit();
        }
    }
}
