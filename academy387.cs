using Microsoft.VisualBasic;
using OpenQA.Selenium;

namespace MuazaTest
{
    public class Academy387
    {
        public static void FindQAAutomaionTest()
        {
            var google = Driver.Instance.FindElement(By.Name("q"));
            google.Click();
            google.SendKeys("Academy387");
            google.SendKeys(Keys.Enter);

            var googleAcademy387 = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) div.yuRUbf h3"));
            googleAcademy387.Click();

            var googleAcademy387Search = Driver.Instance.FindElement(By.Id("main-search-input"));
            googleAcademy387Search.Click();
            googleAcademy387Search.SendKeys("QA");
            googleAcademy387Search.SendKeys(Keys.Enter);

            var googleAcademy387FilterAllCategories = Driver.Instance.FindElement(By.CssSelector("#category_id"));
            googleAcademy387FilterAllCategories.Click();

            var googleAcademy387FilterIT = Driver.Instance.FindElement(By.CssSelector("#category_id option:nth-child(2)"));
            googleAcademy387FilterIT.Click();

            var googleAcademy387FilterLecturers = Driver.Instance.FindElement(By.CssSelector("#lecturer_id"));
            googleAcademy387FilterLecturers.Click();

            var googleAcademy387FilterNemanja = Driver.Instance.FindElement(By.CssSelector("#lecturer_id > option:nth-child(225)"));
            googleAcademy387FilterNemanja.Click();

            var googleAcademy387FilterPriceMin = Driver.Instance.FindElement(By.CssSelector("#price_min"));
            googleAcademy387FilterPriceMin.Click();
            googleAcademy387FilterPriceMin.SendKeys("50");

            var googleAcademy387FilterPriceMax = Driver.Instance.FindElement(By.CssSelector("#price_max"));
            googleAcademy387FilterPriceMax.Click();
            googleAcademy387FilterPriceMax.SendKeys("500");

            var googleAcademy387ShowResult = Driver.Instance.FindElement(By.CssSelector("input.btn.btn-green.btn-block"));
            googleAcademy387ShowResult.Click();

        }

        public static void Contacts()
        {
            var academy387Contact = Driver.Instance.FindElement(By.CssSelector("li:nth-child(6)"));
            academy387Contact.Click();
        }

        public static void Clients()
        {
            var academy387Clients = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 li:nth-child(5)"));
            academy387Clients.Click();
        }

        public static void Blog()
        {
            var academy387Blog = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 li:nth-child(4)"));
            academy387Blog.Click();
        }

        public static void Events()
        {
            var academy387Events = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 li:nth-child(3)"));
            academy387Events.Click();
        }

        public static void Lecturers()
        {
            var academy387Lecturers = Driver.Instance.FindElement(By.CssSelector("ul.nav.navbar-nav.navbar-right li:nth-child(2)"));
            academy387Lecturers.Click();

            var academy387LecturersLetterN = Driver.Instance.FindElement(By.CssSelector("li:nth-child(14)  a"));
            academy387LecturersLetterN.Click();

            var academy387LecturersNemanja = Driver.Instance.FindElement(By.CssSelector("#lecturers-container > div > div:nth-child(11) > div"));
            academy387LecturersNemanja.Click();
        }
    }
}