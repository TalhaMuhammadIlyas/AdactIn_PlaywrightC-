using Microsoft.Playwright;
using NUnit.Framework.Constraints;

namespace AdactIn_PlaywrightC_.POM
{
    public class SelectPage
    {

        private readonly IPage _page;
        private readonly ILocator SelectRbtn;
        private readonly ILocator Continuebtn;



        public SelectPage(IPage page)
        {
            _page = page;
            SelectRbtn = _page.Locator("#radiobutton_0");
            Continuebtn = _page.Locator("#continue");

        }

        public async Task selecthotels()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Select Hotel");

            await SelectRbtn.ClickAsync();
            await Continuebtn.ClickAsync();

            await ExtentReport.TakeScreenshot(_page, "Select Hotel Performed Successfully");
        }
    }
}