using Poc.Factory.Enum;
using Poc.Factory.Factory.Services;

namespace Poc.Factory.Factory
{
    public class SenderFactory
    {

        public SenderFactory()
        {

        }

        public ISenderFactory GetSenderFactory(SenderEnum senderEnum)
        {

            //todo: Implementar via IoC
            switch (senderEnum)
            {
                case SenderEnum.whatsapp:
                    return new WhatsappService();

                case SenderEnum.sms:
                    return new SmsService();

                case SenderEnum.email:
                    return new EmailService();
               
                default:
                    throw new ArgumentException("Not defined Sender");

            }
        }
    }
}
