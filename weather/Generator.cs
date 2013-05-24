using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weather
{
    public class Generator
    {
        public static Guid getRandomGuid()
        {
            Guid result = Guid.NewGuid();
            return result;
        }
    }
}
