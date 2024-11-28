using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUpPortal_AutomationTestSuite.Pages;
using TurnUpPortal_AutomationTestSuite.Utilities;

namespace TurnUpPortal_AutomationTestSuite.Tests
{
    [TestFixture]
    public class Customers_Tests : CommonDriver
    {
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

            // Perform Login Actions
            Login_Page loginObj = new Login_Page();
            loginObj.LoginActions(driver);

            // Navigate to Time and Materials Module from Default Landing Page
            Home_Page homePageObj = new Home_Page();
            homePageObj.NavigateToTMPage(driver);
        }

        [Test, Order(1)]
        public void CreateCustomerRecord_Test()
        {
            Customers_Page customersObj = new Customers_Page();
            customersObj.CreateCustomersRecord(driver);
        }

        [Test, Order(2)]
        public void EditCustomersRecord_Test()
        {
            Customers_Page customersObj = new Customers_Page();
            customersObj.EditCustomersRecord(driver);
        }

        [Test, Order(3)]
        public void DeleteCustomersRecord_Test()
        {
            Customers_Page customersObj = new Customers_Page();
            customersObj.DeleteCustomersRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
