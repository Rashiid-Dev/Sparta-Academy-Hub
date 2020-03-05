using System;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    public partial class Courses
    {
        public Courses()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int CourseId { get; set; }
        public string Coursename { get; set; }
        public int? StreamId { get; set; }
        public int? AcademyId { get; set; }
        public int? Duration { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual Academies Academy { get; set; }
        public virtual Stream Stream { get; set; }
        public virtual ICollection<Accounts> Accounts { get; set; }
    }
}
