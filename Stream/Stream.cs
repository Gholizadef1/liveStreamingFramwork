using System.Collections.Generic;
using System;

namespace Stream
{
    public class Stream : User:Chat
    {
        private string title { get; set; }
    private User admin { get; set; }
    private Time startTime { get; set; }
    private long viewers { get; set; }
    private long likeCount { get; set; }
    private Chat chat { get; set; }

    public long SendLike(User user)
    {
        List<string> userLiked = new List<string>();
        foreach (var i in userLiked)
        {
            userLiked.Add(user.userName);
        }

        if (!userLiked.Contains(user.userName))
        {
            likeCount = likeCount + 1;
            return likeCount;
        };

    }
}
}

