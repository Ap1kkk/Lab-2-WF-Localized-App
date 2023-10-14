using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Firm
    {
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string Region { get; private set; }
        public string Town { get; private set; }
        public string Street { get; private set; }
        public string PostIndex { get; private set; }
        public DateTime StartDate { get; private set; }
        public string Email { get; private set; }
        public string WebsiteUrl { get; private set; }

        public Dictionary<string, string> UserFields { get; private set; }


    }
}
