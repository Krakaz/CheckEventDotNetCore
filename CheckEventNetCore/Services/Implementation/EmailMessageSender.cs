using System;
using System.Text;

namespace CheckEventNetCore.Services.Implementation
{
    internal class EmailMessageSender : IMessageSender
    {
        private readonly StringBuilder _messageLog;
        public EmailMessageSender(MessageLogger messageLogger)
        {
            this._messageLog = messageLogger.GetMessageLog();
        }
        public string Send()
        {
            var message = "Sent by Email";
            this._messageLog.Append(message);
            this._messageLog.Append(Environment.NewLine);
            return message;
        }
    }
}
