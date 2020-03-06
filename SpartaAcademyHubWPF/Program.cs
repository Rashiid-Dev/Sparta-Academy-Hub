using System;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    public class Program
    {
        public List<string> CoursesPrint()
        {

            using (var db = new AcademyHubContext())
            {
                var JoinQuery =
                (from Courses in db.Courses.Include(o => o.Academy)
                 where Courses.Academy.Academyname == "Birmingham Academy"
                 select Courses.Coursename + " Course will take place at " + Courses.Academy.Academyname + " and it will take " + Courses.Duration + " week to complete.").ToList();
                return JoinQuery;

            }
        }

        // Creates a list from all the academies in the database and returns it
        public List<string> AcadList = new List<string>();
        public List<string> AcademiesMake()
        {
            using (var db = new AcademyHubContext())
            {


                var AcademyQuery =
                (from Academies in db.Academies
                 select Academies.Academyname).ToList();

                var test = db.Academies.Select(x => x.Academyname).ToList();


                return AcademyQuery;

            }
        }
    }    
}
