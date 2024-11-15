using OpenQA.Selenium;
using SwagLabsLoginTests.Pages;
using SwagLabsLoginTests.Drivers;
using FluentAssertions;
using Serilog;
using SwagLabsLoginTests.Utils;

namespace SwagLabsLoginTests.Tests
{
    public class LoginPageTestEmptyPassword : BaseLoginPageTest
    {
        [Theory]
        [InlineData("Chrome")]
        [InlineData("Firefox")]
        [InlineData("Edge")]
        public void TestLoginFormWithEmptyPasswordField_ShowsPasswordRequiredError(string browserType)
        {
            TestLogger.Initialize();

            Log.Information("UC-2: Test Login form with credentials by passing Username");

            Log.Information("Starting test for browser {BrowserType}", browserType);
            InitializeDriver(browserType);
            var loginPage = new LoginPage(driver!);

            Log.Information("Opening the login page.");
            loginPage.Open();

            Log.Information("Entering username and password.");
            loginPage.InputUsername("any_username");
            loginPage.InputPassword("any_password");

            Log.Information("Clearing password.");
            loginPage.ClearPassword();

            Log.Information("Clicking the login button.");
            loginPage.ClickLoginButton();


            string errorMessage = loginPage.GetErrorMessage();
            Log.Information("ErrorMessage: {errorMessage}", errorMessage);

            errorMessage.Should().Be("Epic sadface: Password is required");
            Log.Information("Test completed successfully.");
            Log.CloseAndFlush();
        }
    }
}
