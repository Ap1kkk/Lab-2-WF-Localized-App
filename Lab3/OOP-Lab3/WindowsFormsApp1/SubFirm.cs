using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SubFirm
    {
        public string Name { get; private set; }
        public string BossName { get; private set; }
        public string OfficialBossName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public SubFirmType Type { get; private set; }
        public List<Contact> Contacts { get; private set; }
    }
}
