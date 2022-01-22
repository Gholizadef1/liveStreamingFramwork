using System.Collections.Generic;

namespace StreamSpec
{
    public class StreamSpec:User:Category
    {
        private string title { get; set; }
        private User admin { get; set; }
        private Time startTime { get; set; }   
        private Category category{get; set;}
    }
}
