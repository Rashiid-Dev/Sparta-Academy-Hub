using System;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    public partial class Connections
    {
        public string AccountId { get; set; }
        public string ConnectedTo { get; set; }
        public int ConnectionId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Accounts ConnectedToNavigation { get; set; }
    }
}
