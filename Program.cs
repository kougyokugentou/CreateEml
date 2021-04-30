using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEml
{
    class Program
    {
        static void Main(string[] args)
        {
            var createEmail = new createEmail();

            string eml = createEmail.CreateEml("brapp@enron.com", "agent47@hammersrus.com", "Payment for hammers", 
            "I've sent you half the payment for those hammers I ordered, please proceed to execute manufacturing at your discretion. Here are my payment details:\n\r" +
            "PAYMENT FROM Bitcoin Address: n4kD8bt29izZUuxZVthXscSbTdQPoE5wX9 ; PAYMENT TO Bitcoin Address: myeyDMQeqeDXbbhJhtA7NSvHA8vkzaoSrr ; " +
            "TRANSACTION ID: 9a2468889936b87b8d64211e1d2a36afebff6c73eaa8fa4a849cfe099076e723 ; AMOUNT: 0.47 BTC\n\r\n\r - Bill"
            ,null,
            @"C:\devl\443-Files\Custodian Source\Documents\Outlook\");
        }
    }
}
