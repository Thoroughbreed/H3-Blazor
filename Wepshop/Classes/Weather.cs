using System.Collections.Generic;

namespace Wepshop.Classes
{
    public class Forecast
    {
        public string day { get; set; }
        public string temperature { get; set; }
        public string wind { get; set; }
    }

    public class Weather
    {
        public string temperature { get; set; }
        public string wind { get; set; }
        public string description { get; set; }
        public List<Forecast> forecast { get; set; }
    }
}
    
