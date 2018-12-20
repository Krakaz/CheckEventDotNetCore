using System.Text;

namespace CheckEventNetCore.Services
{
    public class MessageLogger
    {
        private StringBuilder messageLog = new StringBuilder();

        public StringBuilder GetMessageLog() => messageLog;
    }
}
