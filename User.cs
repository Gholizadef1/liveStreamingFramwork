using System.Collections.Generic;

namespace User
{
    public class User
    {
        private string Username { get; set; }
        private string EmailAddress { get; set; }
        private virtual List<Channel> channelList { get; set; }
        private UserType userType { get; set; }

        public void WatchAStream(Stream stream)
        {
            Console.WriteLine("a stream play");
        }
    }
}