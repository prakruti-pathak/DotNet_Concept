using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    /// <summary>
    /// Example of Abstraction
    /// </summary>
    public class EmailService
    {
        private void Connect()
        {
            Console.WriteLine("Connecting....");
        }
        private void Authenticate()
        {
            Console.WriteLine("Authenticate....");
        }
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("SendEmail....");
            Disconnect();
        }
        private void Disconnect()
        {
            Console.WriteLine("Disconnecting....");
        }
    }
}
