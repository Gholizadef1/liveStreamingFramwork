using System.Collections.Generic;

namespace Chat
{
    public class Chat:Message
    {
        private List<Message> messageList { get; set; }
        private long stream_id { get; set; }
        private long messageCount { get; set; }

        public long Send_message(Message m)
        {
            messageCount = messageCount + 1 ;
            messageList.add(m);
            return messageList ;
        }  
    }
}
