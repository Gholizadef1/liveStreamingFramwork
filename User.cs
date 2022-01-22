using System.Collections.Generic;

namespace User
{
    public class User:Channel:UserType:Stream
    {
        private string Username { get; set; }
        private string EmailAddress { get; set; }
        private string Password {get; set;}
        private virtual List<Channel> followed_channelList { get; set; } //channels which this user follows
        private UserType userType { get; set; } // admin or viewer

        public void WatchAStream(Stream stream)
        {
            Console.WriteLine("a stream play");
        }
    }
}
