using System;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    public partial class Accounts
    {
        public Accounts()
        {
            ConnectionsAccount = new HashSet<Connections>();
            ConnectionsConnectedToNavigation = new HashSet<Connections>();
        }

        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string MiddleNames { get; set; }
        public string AcademyRole { get; set; }
        public int? AcademyId { get; set; }
        public int? CourseId { get; set; }

        public virtual Academies Academy { get; set; }
        public virtual Courses Course { get; set; }
        public virtual ICollection<Connections> ConnectionsAccount { get; set; }
        public virtual ICollection<Connections> ConnectionsConnectedToNavigation { get; set; }
    }
}
