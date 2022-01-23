using System.Collections.Generic;

namespace Channel
{
    public class Channel:User
    {
        private string name { get; set; }
        private User admin { get; set; }
        private long subscriber { get; set; }
    }
}
