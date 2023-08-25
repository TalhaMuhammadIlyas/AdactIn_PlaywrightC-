using Microsoft.Playwright;
using NUnit.Framework.Constraints;

namespace AdactIn_PlaywrightC_.POM
{
    public class BookingPage
    {

        private readonly IPage _page;
        private readonly ILocator firstname;
        private readonly ILocator lastname;
        private readonly ILocator billAdd;
        private readonly ILocator crecardnum;
        private readonly ILocator crecardtype;
        private readonly ILocator expmonth;
        private readonly ILocator expyear;
        private readonly ILocator cvvnum;
        private readonly ILocator booknowbtn;
        private readonly ILocator logoutbtn;



        public BookingPage(IPage page)
        {
            _page = page;
            firstname = _page.Locator("#first_name");
            lastname = _page.Locator("#last_name");
            billAdd = _page.Locator("#address");
            crecardnum = _page.Locator("#cc_num");
            crecardtype = _page.Locator("#cc_type");
            expmonth = _page.Locator("#cc_exp_month");
            expyear = _page.Locator("#cc_exp_year");
            cvvnum = _page.Locator("#cc_cvv");
            booknowbtn = _page.Locator("#book_now");
            logoutbtn = _page.Locator("#logout");

        }

        public async Task bookhotel()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Book Hotel");


            await firstname.FillAsync("Talha");
            await lastname.FillAsync("Ilyas");
            await billAdd.FillAsync("Johar");
            await crecardnum.FillAsync("1234567895263148");
            await crecardtype.TypeAsync("Master Card");
            await expmonth.TypeAsync("September");
            await expyear.TypeAsync("2023");
            await cvvnum.FillAsync("2596");
            await booknowbtn.ClickAsync();
            Thread.Sleep(3000);
            await logoutbtn.ClickAsync();

            await ExtentReport.TakeScreenshot(_page, "Hotel Booked Successfully");
        }
    }
}