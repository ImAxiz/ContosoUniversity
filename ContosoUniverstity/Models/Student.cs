﻿using ContosoUniversity.Models;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        [Key] //primaarvõti
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment>?  Enrollments { get; set; }
    }
}