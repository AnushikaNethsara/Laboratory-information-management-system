using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Medi_Help
{
    class Message
    {
        private string messageText;
        private string messageId;
        private string messageType;
        public Message(string messageId,string messageText, string messageType)
        {
            this.MessageText = messageText;
            this.MessageId = messageId;
            this.MessageType = messageType;
        }


        


        public string MessageId { get => messageId; set => messageId = value; }
        public string MessageText { get => messageText; set => messageText = value; }
        public string MessageType { get => messageType; set => messageType = value; }
    }
}
