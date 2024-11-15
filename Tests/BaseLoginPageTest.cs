using OpenQA.Selenium;
using SwagLabsLoginTests.Drivers;

namespace SwagLabsLoginTests.Tests
{
    public abstract class BaseLoginPageTest : IDisposable
    {
        protected IWebDriver? driver;
        private bool disposed = false;

        protected virtual void InitializeDriver(string browserType)
        {
            driver = BrowserManager.GetDriver(browserType);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    driver?.Quit();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
