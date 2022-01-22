using System.Collections.Generic;

namespace Stream
{
    public class Stream:User:Chat
    {
        private string title { get; set; }
        private User admin { get; set; }
        private Time startTime { get; set; }
        private long viewers {get; set;}
        private long likeCount{get; set;}
        private Chat chat {get; set;}     

        public long Send_like(User user)
        {
            likeCount = likeCount + 1 ;
            return likeCount ;
        }   
    }
}
