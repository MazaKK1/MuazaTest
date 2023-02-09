using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace MuazaTest
{
    public class Driver
    {
        private static FirefoxDriver driver;
        public static object WindowHandles;

        public static IWebDriver Instance { get; set; }

        //Default Constructor
        public static void Initialize()
        {
            Instance = new ChromeDriver();

            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));

            Instance.Manage().Window.Maximize();
        }

        public static void Initialize(int n)
        {

            if (n == 1)
            {
                var downloadDirectory = @"C:\Drivers1\Firefox";
                FirefoxOptions options = new FirefoxOptions();

                options.SetPreference("download.deafult_directory", downloadDirectory);
                options.SetPreference("download.prompt_for_download", false);
                options.SetPreference("disable-popup-blocking", "true");

                Instance = new FirefoxDriver();
                Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
                Instance.Manage().Window.Maximize();
            }
            else if (n == 2)
            {
                var downloadDirectory = @"C:\Drivers1\Chrome";
                ChromeOptions options = new ChromeOptions();

                options.AddUserProfilePreference("download.default_directory", downloadDirectory);
                options.AddArgument("--disable-notifications");
                options.AddUserProfilePreference("download.prompt_for_download", false);
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                options.AddUserProfilePreference("plugins.plugins_disabled", new[] 
                {
                "Adobe Flash Player",
                "Chrome PDF Viewer"
                                                                                   });

                Instance = new ChromeDriver(@"C:\Drivers\", options);
                Instance.Manage().Window.Maximize();

            }

            else if (n == 3)
            {
                var downloadDirectory = @"C:\Drivers1\InternetExplorer";
                InternetExplorerOptions options = new InternetExplorerOptions();

                options.AddAdditionalInternetExplorerOption("download.deafult_directory", downloadDirectory);
                options.AddAdditionalInternetExplorerOption("download.prompt_for_download", false);
                options.AddAdditionalInternetExplorerOption("disable-popup-blocking", "true");

                Instance = new InternetExplorerDriver();
                Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
                Instance.Manage().Window.Maximize();
            }
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static void Initialize(int a, ReadOnlyDesiredCapabilities capabilities)
        {
            throw new NotImplementedException();
        }

        public static object switchTo()
        {
            throw new NotImplementedException();
        }

        public static void switchBackToMainWindow()
        {
            var currentWindowHandle = Driver.Instance.CurrentWindowHandle;

            foreach (var Handle in Driver.Instance.WindowHandles)
            {
                if (Handle != currentWindowHandle)
                {
                    Driver.Instance.SwitchTo().Window(Handle);

                    Driver.Instance.Navigate().Back();

                    Driver.Instance.Close();
                }
            }
            Thread.Sleep(2000);
            Driver.Instance.SwitchTo().Window(currentWindowHandle);
        }
    }
}
