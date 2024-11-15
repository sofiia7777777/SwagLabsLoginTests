using FluentAssertions;
using OpenQA.Selenium;
using SwagLabsLoginTests.Drivers;
using SwagLabsLoginTests.Pages;
using SwagLabsLoginTests.Utils;
using Serilog;


namespace SwagLabsLoginTests.Tests
{
    public class LoginPageTestLockedOutUser : BaseLoginPageTest
    {
        [Theory]
        [InlineData("Chrome")]
        [InlineData("Firefox")]
        [InlineData("Edge")]
        public void TestLoginFormForLockedOutUser_ShowsUserIsLockedOutError(string browserType)
        {
            TestLogger.Initialize();
            Log.Information("Test Login form for locked_out_user");

            Log.Information("Starting test for browser {BrowserType}", browserType);
            InitializeDriver(browserType);
            var loginPage = new LoginPage(driver!);

            Log.Information("Opening the login page.");
            loginPage.Open();

            Log.Information("Entering username and password.");
            loginPage.InputUsername("locked_out_user");
            loginPage.InputPassword("secret_sauce");

            Log.Information("Clicking the login button.");
            loginPage.ClickLoginButton();

            string errorMessage = loginPage.GetErrorMessage();
            Log.Information("ErrorMessage: {errorMessage}", errorMessage);

            errorMessage.Should().Be("Epic sadface: Sorry, this user has been locked out.");
            Log.Information("Test completed successfully.");
            Log.CloseAndFlush();
        }
    }
}
