﻿using System;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;

namespace SpartaAcademyHubWPF
{
    class Program
    {
        public string CoursesPrint()
        {

            using (var db = new AcademyHubContext())
            {


                var JoinQuery =
                //from order in db.Orders.Include(o => o.Customer)
                //where order.Freight > 750
                //select order;
                from Courses in db.Courses.Include(o => o.Academy)
                select Courses;


                foreach (var course in JoinQuery)
                {
                    if (course.Duration <= 1)
                    {
                        return $"Course name is {course.Coursename} and it takes {course.Duration} week to complete and it takes place at {course.Academy.Academyname}";
                    }
                    else
                    {
                        return $"Course name is {course.Coursename} and it takes {course.Duration} weeks to complete and it takes place at {course.Academy.Academyname}";
                    }

                }
                return "";

            }
        }
        public List<string> AcadList = new List<string>();
        public List<string> AcademiesMake()
        {
            using (var db = new AcademyHubContext())
            {


                var AcademyQuery =
                //from order in db.Orders.Include(o => o.Customer)
                //where order.Freight > 750
                //select order;
                (from Academies in db.Academies
                 select Academies.Academyname).ToList();

                //foreach (var academies in AcademyQuery)
                //{
                //    AcadList.Add($"{academies.Academyname}");
                //}

                var test = db.Academies.Select(x => x.Academyname).ToList();


                return AcademyQuery;

            }
        }

        public string AcademiesPrint()
        {
            foreach (var acads in AcadList)
            {
                return acads;
            }
            return "";
        }
    
    }
}
