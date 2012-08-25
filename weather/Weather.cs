using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weather
{
    public class XMLfromsite
    {
        public static void getWeather(string city)
        {
            try
            {
                XmlDocument weather = new XmlDocument();
                weather.Load(string.Format("http://www.google.com/ig/api?weather={0}", city));

            }
            catch
            {

                System.Console.Beep();
            }
        }

    }
}
