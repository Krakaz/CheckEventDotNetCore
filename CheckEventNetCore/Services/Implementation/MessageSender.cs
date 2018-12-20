using System;
using System.Linq;

namespace CheckEventNetCore.Services.Implementation
{
    internal class MessageSender : IMessageSender
    {
        public delegate string SendDelegate();
        private event SendDelegate SendMessage;
        public MessageSender(IServiceProvider serviceProvider)
        {
            System.Reflection.Assembly ass = System.Reflection.Assembly.GetEntryAssembly();

            foreach (System.Reflection.TypeInfo ti in ass.DefinedTypes)
            {
                if (ti.ImplementedInterfaces.Contains(typeof(IMessageSender))
                    && ti.FullName != this.GetType().ToString())
                {
                    this.SendMessage += (serviceProvider.GetService(Type.GetType(ti.FullName)) as IMessageSender).Send;
                }
            }
        }

        public string Send()
        {
            return this.SendMessage();
        }
    }
}
