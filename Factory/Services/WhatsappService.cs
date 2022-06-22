using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Factory.Factory.Services
{
    internal class WhatsappService : ISenderFactory
    {
        public void Send(Message message)
        {
            Console.WriteLine($"{message.Texto}, enviada via WHATSAPP");
        }
    }
}
