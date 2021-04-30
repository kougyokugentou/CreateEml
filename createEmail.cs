using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;

namespace CreateEml
{
    public class createEmail
    {
        /// <summary>
        /// Creates an eml file to be delivered with the default mail client
        /// </summary>
        /// <param name="from">address that sends the email</param>
        /// <param name="to">address to which send the email</param>
        /// <param name="subject">subject</param>
        /// <param name="body">body</param>
        /// <param name="attachments">list of attachments</param>
        /// <param name="destFolder">destination folder to store the file</param>
        /// <returns>The complete path of the newely generated EML file</returns>

        public static string CreateEml(string from,
                                       string to,
                                       string subject,
                                       string body,
                                       IEnumerable<Attachment> attachments,
                                       string destFolder)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                if (attachments != null)
                    foreach (var attachment in attachments)
                        mail.Attachments.Add(attachment);

                SmtpClient smtpClient = new SmtpClient
                {
                    PickupDirectoryLocation = destFolder,
                    DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory
                };
                smtpClient.Send(mail);
            }

            DirectoryInfo dir = new DirectoryInfo(destFolder);
            FileInfo file = dir.GetFiles("*.eml", SearchOption.TopDirectoryOnly).OrderByDescending(m => m.CreationTimeUtc).First();
            return file.FullName;
        }
    }
}
