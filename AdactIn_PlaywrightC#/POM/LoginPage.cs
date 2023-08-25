using Microsoft.Playwright;

namespace AdactIn_PlaywrightC_.POM
{
    public class LoginPage
    {

        private readonly IPage _page;
        private readonly ILocator username;
        private readonly ILocator password;
        private readonly ILocator loginbtn;

        public LoginPage(IPage page)
        {
            _page = page;
            username = _page.Locator("#username");
            password = _page.Locator("#password");
            loginbtn = _page.Locator("#login");
        }

        public async Task Login(string url, string user, string pass)
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login Hotel");

            await _page.GotoAsync(url);
            await username.FillAsync(user);
            await password.FillAsync(pass);
            await loginbtn.ClickAsync();

            await ExtentReport.TakeScreenshot(_page, "Login Performed Successfully");
        }
    }
}