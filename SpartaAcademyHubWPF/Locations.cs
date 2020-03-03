using System;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    public partial class Locations
    {
        public Locations()
        {
            Academies = new HashSet<Academies>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }

        public virtual ICollection<Academies> Academies { get; set; }
    }
}
