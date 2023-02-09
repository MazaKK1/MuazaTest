using OpenQA.Selenium;

namespace MuazaTest
{
    public class radioSarajevo
    {
        public static string Function1(string RadioSa)
        {
            string message = "",
                pretragaMessage = "";

            try
            {
                var google = Driver.Instance.FindElement(By.Name("q"));
                google.Click();
                google.SendKeys(RadioSa);
                google.SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                var radioSa = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) div.yuRUbf a"));
                radioSa.Click();
                Thread.Sleep(1000);

                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver.Instance;
                jsExecutor.ExecuteScript("const elements = document.getElementsByClassName('google -auto- placed'); while (elements.length > 0) elements[0].remove();");
                jsExecutor.ExecuteScript("const elements2 = document.getElementsByClassName('adsbygoogle adsbygoogle-noablate'); while (elements2.length > 0) elements2[0].remove();");

                var radioSaNews = Driver.Instance.FindElement(By.CssSelector("#header div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(1)"));
                radioSaNews.Click();
                Thread.Sleep(1000);
            }
            catch
            {
                message += "ERROR!!! " + pretragaMessage;
            }

            message += pretragaMessage;

            return message;
        }

        public static string Function2(string Yes)
        {
            string message = "",
                businessMessage = "";

            try
            {
                var radioSaBusiness = Driver.Instance.FindElement(By.CssSelector("#header > div > nav > div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(2)"));
                radioSaBusiness.Click();
                Thread.Sleep(1000);
            }

            catch
            {
                message += "ERROR!!! " + businessMessage;
            }

            message += businessMessage;

            return message;
        }

        public static string Function3(string Yes)
        {
            string message = "",
                metromahalaMessage = "";

            try
            {
                var radioSaMetro = Driver.Instance.FindElement(By.CssSelector("#header > div > nav > div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(3)"));
                radioSaMetro.Click();
                Thread.Sleep(1000);
            }

            catch
            {
                message += "ERROR!!! " + metromahalaMessage;
            }

            message += metromahalaMessage;

            return message;
        }

        public static string Function4(string Yes)
        {
            string message = "",
               magazinMessage = "";

            try
            {
                var radioSaMagazin = Driver.Instance.FindElement(By.CssSelector("#header > div > nav > div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(4)"));
                radioSaMagazin.Click();
                Thread.Sleep(1000);
            }

            catch
            {
                message += "ERROR!!! " + magazinMessage;
            }

            message += magazinMessage;

            return message;
        }

        public static string Function5(string Yes)
        {
            string message = "",
                sportMessage = "";

            try
            {
                var radioSaSport = Driver.Instance.FindElement(By.CssSelector("#header > div > nav > div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(5)"));
                radioSaSport.Click();
                Thread.Sleep(1000);
            }

            catch
            {
                message += "ERROR!!! " + sportMessage;
            }

            message += sportMessage;

            return message;
        }

        public static string Function6(string Yes)
        {
            string message = "",
                autoMotoMessage = "";

            try
            {
                var radioSaAutoMoto = Driver.Instance.FindElement(By.CssSelector("#header > div > nav > div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(6)"));
                radioSaAutoMoto.Click();
                Thread.Sleep(1000);
            }

            catch
            {
                message += "ERROR!!! " + autoMotoMessage;
            }

            message += autoMotoMessage;

            return message;
        }

        public static string Function7(string Yes)
        {
            string message = "",
                multimediaMessage = "";

            try
            {
                var radioSaMultimedia = Driver.Instance.FindElement(By.CssSelector("#header > div > nav > div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(7)"));
                radioSaMultimedia.Click();
                Thread.Sleep(1000);
            }

            catch
            {
                message += "ERROR!!! " + multimediaMessage;
            }

            message += multimediaMessage;

            return message;
        }

        public static string Function8(string Yes)
        {
            string message = "",
                infoGrafMessage = "";

            try
            {
                var radioSaInfoGraf = Driver.Instance.FindElement(By.CssSelector("#header > div > nav > div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(8)"));
                radioSaInfoGraf.Click();
                Thread.Sleep(1000);
            }

            catch
            {
                message += "ERROR!!! " + infoGrafMessage;
            }

            message += infoGrafMessage;

            return message;
        }

        public static string Function9(string Yes)
        {
            string message = "",
                radioMessage = "";

            try
            {
                var radioSaRadio = Driver.Instance.FindElement(By.CssSelector("#header > div > nav > div.navbar-menu.hidden.p-0.lg\\:flex.h-14.lg\\:flex-grow.lg\\:items-center.lg\\:w-auto > div > div:nth-child(9)"));
                radioSaRadio.Click();
                Thread.Sleep(1000);
            }

            catch
            {
                message += "ERROR!!! " + radioMessage;
            }

            message += radioMessage;

            return message;
        }
    }
}