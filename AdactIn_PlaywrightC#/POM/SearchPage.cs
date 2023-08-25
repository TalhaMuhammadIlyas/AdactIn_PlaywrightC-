using Microsoft.Playwright;
using NUnit.Framework.Constraints;

namespace AdactIn_PlaywrightC_.POM
{
    public class SearchPage
    {

        private readonly IPage _page;
        private readonly ILocator location;
        private readonly ILocator hotels;
        private readonly ILocator roomtype;
        private readonly ILocator noofrooms;
        private readonly ILocator checkindate;
        private readonly ILocator checkoutdate;
        private readonly ILocator adultsperroom;
        private readonly ILocator childrenperroom;
        private readonly ILocator searchbtn;


        public SearchPage(IPage page)
        {
            _page = page;
            location = _page.Locator("#location");
            hotels = _page.Locator("#hotels");
            roomtype = _page.Locator("#room_type");
            noofrooms = _page.Locator("#room_nos");
            checkindate = _page.Locator("#datepick_in");
            checkoutdate = _page.Locator("#datepick_out");
            adultsperroom = _page.Locator("#adult_room");
            childrenperroom = _page.Locator("#child_room");
            searchbtn = _page.Locator("#Submit");

        }

        public async Task searchhotels()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Search Hotel");

            await location.TypeAsync("Sydney");
            await location.TypeAsync("Sydney");
            await hotels.TypeAsync("Hotel Hervey");
            await roomtype.TypeAsync("Deluxe");
            await noofrooms.TypeAsync("1 - One");
            await checkindate.TypeAsync("24/08/2023");
            await checkoutdate.TypeAsync("29/08/2023");
            await adultsperroom.TypeAsync("2 - Two");
            await childrenperroom.TypeAsync("0 - None");
            await searchbtn.ClickAsync();

            await ExtentReport.TakeScreenshot(_page, "Search Hotel Performed Successfully");
        }
    }
}