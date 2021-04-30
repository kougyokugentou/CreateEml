using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CreateEml
{
    class Program
    {
        static void Main(string[] args)
        {
            /* As reference.
            Attachment att = new Attachment(@"C:\devl\443-Files\Custodian Source\Documents\coc.pdf");
            List<Attachment> attachments = new List<Attachment>();
            attachments.Add(att);
            */

            var createEmail = new createEmail();

            string eml = createEmail.CreateEml("agent47@hammersrus.com", "brapp@enron.com", "Military Spending Budget Invoice",
                "Please find attached your invoice as requested. Ensure the DELIVERY ADDRESS for where you want your hammers sent is accurate.\n" +
                "Immediate payment of half the invoice is needed to execute manufacturing of the hammers. Please also note any special disposition instructions when payment is remitted.\n" +
                "Payment must be made in Bitcoin to Bitcoin Address: myeyDMQeqeDXbbhJhtA7NSvHA8vkzaoSrr.\n\r" +
                "Sincerely,\nAgent 47, HammersRus.\n\rHammersRus, dropping the hammer and dispensing indiscriminate justice since 1998."
                ,null,
                @"C:\devl\443-Files\Custodian Source\Documents\Outlook\");
            
            eml = createEmail.CreateEml("brapp@enron.com", "agent47@hammersrus.com", "Payment for hammers", 
                "I've sent you half the payment for those hammers I ordered, please proceed to execute manufacturing at your discretion. Here are my payment details:\n\r" +
                "PAYMENT FROM Bitcoin Address: n4kD8bt29izZUuxZVthXscSbTdQPoE5wX9\nPAYMENT TO Bitcoin Address: myeyDMQeqeDXbbhJhtA7NSvHA8vkzaoSrr\n" +
                "TRANSACTION ID: 9a2468889936b87b8d64211e1d2a36afebff6c73eaa8fa4a849cfe099076e723\nAMOUNT: 0.47 BTC\n\r - Bill"
                ,null,
                @"C:\devl\443-Files\Custodian Source\Documents\Outlook\");
        }
    }
}
