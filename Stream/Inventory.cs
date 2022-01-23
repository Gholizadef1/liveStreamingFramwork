using System.Collections.Generic;

namespace Inventory
{
    public class Inventory : streamSpec:Stream
    {
      
public List search(streamSpec searchSpec)
    {
        List matchingStreamSpec = new LinkedList();
        for (Iterator i = matchingStreamSpec.iterator();
        i.hasNext();)
        {
            Stream stream = (Stream)i.next();
            if (stream.getSpec().matches(searchSpec))
                matchingStreamSpec.add(stream);
        }
        return matchingStreamSpec;
        ...
}
}
...
}

       

        public void End(Stream stream)
{
    Console.WriteLine("a stream ended");
}
    }
}