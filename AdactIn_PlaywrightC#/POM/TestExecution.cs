using Microsoft.Playwright.NUnit;

namespace AdactIn_PlaywrightC_.POM
{
    [TestFixture]
    public class TestExecution : PageTest
    {
        [SetUp]
        public async Task TestSetup()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.CurrentContext.Test.MethodName);
        }

        [TearDown]
        public async Task TearDown()
        {

        }

        [Test]
        public async Task Extent_Login_TC001()
        {
            LoginPage loginpage = new LoginPage(Page);
            await loginpage.Login("https://adactinhotelapp.com/", "Talhatest9", "Talhatest9");
        }
        [Test]
        public async Task Extent_SearchHotel_TC002()
        {
            LoginPage loginpage = new LoginPage(Page);
            SearchPage searchpage = new SearchPage(Page);
            await loginpage.Login("https://adactinhotelapp.com/", "Talhatest9", "Talhatest9");
            await searchpage.searchhotels();
        }
        [Test]
        public async Task Extent_SelectHotel_TC003()
        {
            LoginPage loginpage = new LoginPage(Page);
            SearchPage searchpage = new SearchPage(Page);
            SelectPage selectpage = new SelectPage(Page);
            await loginpage.Login("https://adactinhotelapp.com/", "Talhatest9", "Talhatest9");
            await searchpage.searchhotels();
            await selectpage.selecthotels();
        }
        [Test]
        public async Task Extent_BookingHotel_TC004()
        {
            LoginPage loginpage = new LoginPage(Page);
            SearchPage searchpage = new SearchPage(Page);
            SelectPage selectpage = new SelectPage(Page);
            BookingPage bookingpage = new BookingPage(Page);
            await loginpage.Login("https://adactinhotelapp.com/", "Talhatest9", "Talhatest9");
            await searchpage.searchhotels();
            await selectpage.selecthotels();
            await bookingpage.bookhotel();
        }

        public class AssemblyInitialize
        {
            [SetUpFixture]
            public class Setup
            {
                [OneTimeSetUp]
                public static void AssemblyLevelSetup()
                {
                    // Create Extent Report
                    ExtentReport.LogReport("TestReport");
                }

                [OneTimeTearDown]
                public static void AssemblyLevelTearDown()
                {
                    ExtentReport.extentReports.Flush();
                }
            }
        }

    }
}