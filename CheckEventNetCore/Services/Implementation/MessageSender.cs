namespace CheckEventNetCore.Services.Implementation
{
    internal class MessageSender : IMessageSender
    {
        public delegate string SendDelegate();
        private event SendDelegate SendMessage;
        public MessageSender(MessageLogger messageLogger)
        {
            this.SendMessage += (new SmsMessageSender(messageLogger)).Send;
            this.SendMessage += (new EmailMessageSender(messageLogger)).Send;
        }

        public string Send()
        {
            return this.SendMessage();
        }
    }
}
