using System;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    public partial class Connections
    {
        public int? AccountId { get; set; }
        public int? ConnectedTo { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Accounts ConnectedToNavigation { get; set; }
    }
}
