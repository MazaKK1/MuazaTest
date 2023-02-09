using OpenQA.Selenium;
using System.Net.Mail;

namespace MuazaTest
{
    public class Functions
    {
        public static string SendEmailAttachment(string subject, string body)
        {
            string message = "",
               username = "muaza.jagodic@outlook.com",
               password = "Munizatop22";

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.outlook.com");

                mail.From = new MailAddress("muaza.jagodic@outlook.com");
                mail.To.Add("muaza.jagodic@outlook.com");
                mail.Subject = subject;
                mail.Body = body;

                System.Net.Mail.Attachment attachment;

                DirectoryInfo d = new DirectoryInfo(@"C:/Screenshots/");
                FileInfo[] Files = d.GetFiles("*.jpeg", SearchOption.AllDirectories);

                foreach (FileInfo file in Files)
                {
                    attachment = new System.Net.Mail.Attachment(file.FullName);
                    mail.Attachments.Add(attachment);
                }

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }
            return message;
        }

        internal static void TakeScreenshot()
        {
            Random r = new Random();

            ((ITakesScreenshot)Driver.Instance).GetScreenshot().SaveAsFile("C:/Screenshots/" + "/Screenshot" + r.Next(0, 1000000) + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)") + ".png", ScreenshotImageFormat.Png);
        }
    }
}