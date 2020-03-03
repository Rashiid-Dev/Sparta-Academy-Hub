using System;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    public partial class Stream
    {
        public Stream()
        {
            Courses = new HashSet<Courses>();
        }

        public int StreamId { get; set; }
        public string Streamname { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}
