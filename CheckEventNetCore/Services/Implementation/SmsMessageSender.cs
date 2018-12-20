using System;
using System.Text;

namespace CheckEventNetCore.Services.Implementation
{
    internal class SmsMessageSender : IMessageSender
    {
        private readonly StringBuilder _messageLog;

        public SmsMessageSender(MessageLogger messageLogger)
        {
            this._messageLog = messageLogger.GetMessageLog();
        }
        public string Send()
        {
            var message = "Sent by SMS";
            this._messageLog.Append(message);
            this._messageLog.Append(Environment.NewLine);
            return message;
        }
    }
}
