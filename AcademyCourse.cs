using OpenQA.Selenium;

namespace MuazaTest
{
    public class AcademyCourse
    {
        public static void SignUp()
        {
            var google = Driver.Instance.FindElement(By.Name("q"));
            google.Click();
            google.SendKeys("academy 387");
            google.SendKeys(Keys.Enter);

            var googleAcademy387 = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) div.yuRUbf h3"));
            googleAcademy387.Click();

            var googleAcademy387Recent = Driver.Instance.FindElement(By.CssSelector("li.category-filters__list-item.active a"));
            googleAcademy387Recent.Click();

            var googleAcademy387IT = Driver.Instance.FindElement(By.CssSelector("div.row.category-filters-section.hidden-xs.hidden-sm.hidden-md li:nth-child(2) a"));
            googleAcademy387IT.Click();

            var googleAcademy387Languages = Driver.Instance.FindElement(By.CssSelector("div.row.category-filters-section.hidden-xs.hidden-sm.hidden-md li.category-filters__list-item.active a"));
            googleAcademy387Languages.Click();

            var googleAcademy387HR = Driver.Instance.FindElement(By.CssSelector("div.row.category-filters-section.hidden-xs.hidden-sm.hidden-md li:nth-child(4) a"));
            googleAcademy387HR.Click();

            var googleAcademy387STEM = Driver.Instance.FindElement(By.CssSelector("div.row.category-filters-section.hidden-xs.hidden-sm.hidden-md li:nth-child(5) a"));
            googleAcademy387STEM.Click();

            var googleAcademy387Other = Driver.Instance.FindElement(By.CssSelector("div.row.category-filters-section.hidden-xs.hidden-sm.hidden-md li:nth-child(6) a"));
            googleAcademy387Other.Click();                       
        }
    }
}