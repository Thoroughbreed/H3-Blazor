using System.Reflection.Metadata;
using System.Security.Authentication;

namespace Wepshop.Classes
{
    public class CustomerDTO
    {
        public string name { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string eMail { get; set; }

        public int orders { get; set; }

        public int id { get; set; }
    }
}