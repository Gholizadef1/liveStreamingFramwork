using System.Collections.Generic;

namespace StreamController
{
    public class StreamController
    {
        private string title { get; set; }
        private User admin { get; set; }
        private Time startTime { get; set; }
        private bool isPrivate { get; set; }
        private bool chatIsOn { get; set; }

        public void Start(Stream stream)
        {
            Console.WriteLine("a stream stared");
        }

        public void End(Stream stream)
        {
            Console.WriteLine("a stream ended");
        }
    }
}