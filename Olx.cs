using OpenQA.Selenium;

namespace MuazaTest
{
    public class Olx
    {
        public static string Search(string pik)
        {
            string message = "",
                googleSearch = "";

            try
            {
                var google = Driver.Instance.FindElement(By.Name("q"));
                google.Click();
                google.SendKeys(pik);
                google.SendKeys(Keys.Enter);
                Thread.Sleep(500);

                var googleolx = Driver.Instance.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div[1]/a/h3"));
                googleolx.Click();
                Thread.Sleep(500);

                var googlepikCookies = Driver.Instance.FindElement(By.CssSelector("#cookiesBar > p > button"));
                googlepikCookies.Click();

                var googlepikVehicles = Driver.Instance.FindElement(By.CssSelector("#pocetna-meni-lijevo > li:nth-child(2)"));
                googlepikVehicles.Click();

                var googlepikMotocicles = Driver.Instance.FindElement(By.CssSelector("#katlijevo > li:nth-child(2)"));
                googlepikMotocicles.Click();
            }
            catch
            {
                message += "ERROR!!! " + googleSearch;
            }

            message += googleSearch;

            return message;
        }

        public static string Filters()
        {
            string message = "",
                olxMotocicleFilter = "";

            try
            {
                var motoState = Driver.Instance.FindElement(By.CssSelector("#pretragavozila > div > div.span10 > div > div:nth-child(1) > div:nth-child(1) > p:nth-child(2)"));
                motoState.Click();

                var motoManufacturer = Driver.Instance.FindElement(By.XPath("//*[@id=\"v_b\"]"));
                motoManufacturer.Click();
                var motoManufacturerSelect = Driver.Instance.FindElement(By.XPath("//*[@id=\"v_b\"]/optgroup[1]/option[5]"));
                motoManufacturerSelect.Click();

                var motoPriceMin = Driver.Instance.FindElement(By.XPath("//*[@id=\"od\"]"));
                motoPriceMin.Click();
                motoPriceMin.SendKeys("300");
                var motoPriceMax = Driver.Instance.FindElement(By.XPath("//*[@id=\"do\"]"));
                motoPriceMax.Click();
                motoPriceMax.SendKeys("900");

                var motoLocation = Driver.Instance.FindElement(By.CssSelector("#kanton"));
                motoLocation.Click();
                var motoLocationSelect = Driver.Instance.FindElement(By.XPath("//*[@id=\"kanton\"]/option[3]"));
                motoLocationSelect.Click();

                var motoAgeMin = Driver.Instance.FindElement(By.XPath("//*[@id=\"godiste_od\"]"));
                motoAgeMin.Click();
                motoAgeMin.SendKeys("2015");
                var motoAgeMax = Driver.Instance.FindElement(By.XPath("//*[@id=\"godiste_do\"]"));
                motoAgeMax.Click();
                motoAgeMax.SendKeys("2023");

                var motoKilometersMin = Driver.Instance.FindElement(By.XPath("//*[@id=\"kilometraza_od\"]"));
                motoKilometersMin.Click();
                var motoKilometersMinSelect = Driver.Instance.FindElement(By.XPath("//*[@id=\"kilometraza_od\"]/option[10]"));
                motoKilometersMinSelect.Click();

                var motoKilometersMax = Driver.Instance.FindElement(By.XPath("//*[@id=\"kilometraza_do\"]"));
                motoKilometersMax.Click();
                var motoKilometersMaxSelect = Driver.Instance.FindElement(By.XPath("//*[@id=\"kilometraza_do\"]/option[15]"));
                motoKilometersMaxSelect.Click();

                var motoFuel = Driver.Instance.FindElement(By.CssSelector("#pretragavozila > div > div.span10 > div > div.box.vozila-filter-gorivo > div.gors > p:nth-child(1)"));
                motoFuel.Click();

                var motoResults = Driver.Instance.FindElement(By.CssSelector("#pretragavozila > div > div.span10 > div > div:nth-child(6) > div > button"));
                motoResults.Click();
            }
            catch
            {
                message += "ERROR!!! " + olxMotocicleFilter;
            }

            message += olxMotocicleFilter;

            return message;
        }
    }
}