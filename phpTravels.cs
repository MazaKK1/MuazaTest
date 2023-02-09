using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;

namespace MuazaTest
{
    public class phpTravels
    {
        public static string Search(string php)
        {
            string message = "",
                googleMessage = "";

            try
            {
                var google = Driver.Instance.FindElement(By.Name("q"));
                google.Click();
                google.SendKeys(php);
                google.SendKeys(Keys.Enter);
                Thread.Sleep(500);

                var googlePhptravels = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div > div.yuRUbf > a > h3"));
                googlePhptravels.Click();
                Thread.Sleep(500);

                Functions.TakeScreenshot();
                Thread.Sleep(500);
            }
            catch
            {
                message += "ERROR!!! " + googleMessage;
            }

            message += googleMessage;

            return message;
        }

        public static string Demo()
        {
            string message = "",
                DemoMessage = "";

            try
            {
                var DemoPhp = Driver.Instance.FindElement(By.CssSelector("body > div.jfHeader-wrapper > div > div.jfHeader-menuWrapper > ul > li.jfHeader-menuListItem.desktop-hidden > a"));
                DemoPhp.Click();
                Thread.Sleep(500);
            }
            catch
            {
                message += "ERROR!!! " + DemoMessage;
            }

            message += DemoMessage;

            return message;
        }

        public static string Pricing()
        {
            string message = "",
                PricingMessage = "";

            try
            {
                var PricingPhp = Driver.Instance.FindElement(By.CssSelector("body > div.jfHeader-wrapper > div > div.jfHeader-menuWrapper > ul > li:nth-child(2) > a"));
                PricingPhp.Click();
                Thread.Sleep(500);
            }
            catch
            {
                message += "ERROR!!! " + PricingMessage;
            }

            message += PricingMessage;

            return message;
        }

        public static string Features()
        {
            string message = "",
                FeaturesMessage = "";

            try
            {
                var FeaturesPhp = Driver.Instance.FindElement(By.CssSelector("body > div.jfHeader-wrapper > div > div.jfHeader-menuWrapper > ul > li:nth-child(3) > a"));
                FeaturesPhp.Click();
                Thread.Sleep(500);
            }
            catch
            {
                message += "ERROR!!! " + FeaturesMessage;
            }

            message += FeaturesMessage;

            return message;
        }

        public static string Integrations()
        {
            string message = "",
                IntegrationsMessage = "";

            try
            {
                var IntegrationsPhp = Driver.Instance.FindElement(By.CssSelector("body > div.jfHeader-wrapper > div > div.jfHeader-menuWrapper > ul > li:nth-child(4) > a"));
                IntegrationsPhp.Click();
                Thread.Sleep(500);
            }
            catch
            {
                message += "ERROR!!! " + IntegrationsMessage;
            }

            message += IntegrationsMessage;

            return message;
        }


        public static string Company()
        {
            string message = "",
                CompanyMessage = "";

            try
            {
                var CompanyPhp = Driver.Instance.FindElement(By.CssSelector("body > div.jfHeader-wrapper > div > div.jfHeader-menuWrapper > ul > li.jfHeader-menuListItem.hasSubMenu.hasIcon.jfHeader-support-menu > a"));
                CompanyPhp.Click();
                Thread.Sleep(500);
            }
            catch
            {
                message += "ERROR!!! " + CompanyMessage;
            }

            message += CompanyMessage;

            return message;
        }

        internal static string IntegrationsOptions()
        {
            string message = "",
                IntegrationsOptionsMessage = "";

            try
            {
                phpTravels.Integrations();
                var IntegrationHubSpot = Driver.Instance.FindElement(By.CssSelector("#menuContent-1 > ul > li:nth-child(2) > a > span"));
                IntegrationHubSpot.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();

                var IntegrationsOthers = Driver.Instance.FindElement(By.CssSelector("#menuContent-1 > ul > li:nth-child(3) > a"));
                IntegrationsOthers.Click();
                Thread.Sleep(500);

                phpTravels.Integrations();

                var IntegrationsHotels = Driver.Instance.FindElement(By.CssSelector("#menuToggle-2 > button"));
                IntegrationsHotels.Click();
                Thread.Sleep(500);

                var IntegrationsHotelsRizlive = Driver.Instance.FindElement(By.CssSelector("#menuContent-2 > ul > li:nth-child(2) > a > span"));
                IntegrationsHotelsRizlive.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsHotels.Click();

                var IntegrationsHotelsAgoda = Driver.Instance.FindElement(By.CssSelector("#menuContent-2 > ul > li:nth-child(3) > a > span"));
                IntegrationsHotelsAgoda.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsHotels.Click();

                var IntegrationsHotelsHotelson = Driver.Instance.FindElement(By.CssSelector("#menuContent-2 > ul > li:nth-child(4) > a > span"));
                IntegrationsHotelsHotelson.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsHotels.Click();

                var IntegrationsHotelsMore = Driver.Instance.FindElement(By.CssSelector("#menuContent-2 > ul > li:nth-child(5) > a"));
                IntegrationsHotelsMore.Click();
                Thread.Sleep(500);

                phpTravels.Integrations();

                var IntegrationsFlights = Driver.Instance.FindElement(By.CssSelector("#menuToggle-3 > button"));
                IntegrationsFlights.Click();
                Thread.Sleep(500);

                var IntegrationsFlightsKiwi = Driver.Instance.FindElement(By.CssSelector("#menuContent-3 > ul > li:nth-child(2) > a"));
                IntegrationsFlights.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsFlights.Click();

                var IntegrationFlightsAmadeus = Driver.Instance.FindElement(By.CssSelector("#menuContent-3 > ul > li:nth-child(3) > a"));
                IntegrationFlightsAmadeus.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsFlights.Click();

                var IntegrationsFlightsAerTicket = Driver.Instance.FindElement(By.CssSelector("#menuContent-3 > ul > li:nth-child(4) > a"));
                IntegrationsFlightsAerTicket.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsFlights.Click();

                var IntegrationsFlightsDuffel = Driver.Instance.FindElement(By.CssSelector("#menuContent-3 > ul > li:nth-child(5) > a"));
                IntegrationsFlightsDuffel.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsFlights.Click();

                var IntegrationsFlightsMore = Driver.Instance.FindElement(By.CssSelector("#menuContent-3 > ul > li:nth-child(6) > a"));
                IntegrationsFlightsMore.Click();
                Thread.Sleep(500);

                phpTravels.Integrations();

                var IntegrationsTours = Driver.Instance.FindElement(By.CssSelector("#menuToggle-4 > button"));
                IntegrationsTours.Click();
                Thread.Sleep(500);

                var IntegrationsToursTiqets = Driver.Instance.FindElement(By.CssSelector("#menuContent-4 > ul > li:nth-child(2) > a"));
                IntegrationsToursTiqets.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsTours.Click();

                var IntegrationsToursViator = Driver.Instance.FindElement(By.CssSelector("#menuContent-4 > ul > li:nth-child(3) > a"));
                IntegrationsToursViator.Click();
                Thread.Sleep(500);
                //needs to close the tab

                Driver.switchBackToMainWindow();
                phpTravels.Integrations();
                IntegrationsTours.Click();

                var IntegrationToursMore = Driver.Instance.FindElement(By.CssSelector("#menuContent-4 > ul > li:nth-child(4) > a"));
                IntegrationToursMore.Click();
                Thread.Sleep(500);

                phpTravels.Integrations();

                var IntegrationsCars = Driver.Instance.FindElement(By.CssSelector("#menuToggle-5 > button"));
                IntegrationsCars.Click();
                Thread.Sleep(500);

                var IntegrationCarsMore = Driver.Instance.FindElement(By.CssSelector("#menuContent-5 > ul > li.jfHeader-subMenuItem > a"));
                IntegrationCarsMore.Click();
                Thread.Sleep(500);

                phpTravels.Integrations();

                var IntegrationsMore = Driver.Instance.FindElement(By.CssSelector("#menuToggleWrapper > ul > li.jfHeader-subMenuItem.moreLinkItem > a"));
                IntegrationsMore.Click();
                Thread.Sleep(500);
            }
            catch
            {
                message += "ERROR!!! " + IntegrationsOptionsMessage;
            }

            message += IntegrationsOptionsMessage;

            return message;
        }
    }
}
