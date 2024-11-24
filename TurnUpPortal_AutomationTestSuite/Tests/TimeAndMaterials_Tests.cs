using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUpPortal_AutomationTestSuite.Pages;
using TurnUpPortal_AutomationTestSuite.Utilities;

namespace TurnUpPortal_AutomationTestSuite.Tests
{
    [TestFixture]
    public class TimeAndMaterials_Tests : CommonDriver
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
        public void CreateTMRecord_Test()
        {
            TimeAndMaterials_Page timeAndMaterialsObj = new TimeAndMaterials_Page();
            timeAndMaterialsObj.CreateTimeRecord(driver);
        }

        [Test, Order(2)]
        public void EditTMRecord_Test()
        {
            TimeAndMaterials_Page timeAndMaterialsObj = new TimeAndMaterials_Page();
            timeAndMaterialsObj.EditTimeRecord(driver);
        }

        [Test, Order(3)]
        public void DeleteTMRecord_Test()
        {
            TimeAndMaterials_Page timeAndMaterialsObj = new TimeAndMaterials_Page();
            timeAndMaterialsObj.DeleteTimeRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
