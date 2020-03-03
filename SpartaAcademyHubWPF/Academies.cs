using System;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    public partial class Academies
    {
        public Academies()
        {
            Courses = new HashSet<Courses>();
        }

        public int AcademyId { get; set; }
        public string Academyname { get; set; }
        public int? LocationId { get; set; }

        public virtual Locations Location { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
    }
}
