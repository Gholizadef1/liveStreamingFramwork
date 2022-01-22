using System.Collections.Generic;

namespace Message
{
    public class Message:User
    {
        private User user { get; set; }
        private Time send_time { get; set; }
        private string message { get; set; }

    }
}
