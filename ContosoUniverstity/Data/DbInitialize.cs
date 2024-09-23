using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class DbInitialize
    {
        public static void Initialize(SchoolContext context)
        {
            //teeb kindlaks et andmebaas tehakse, või oleks olemas
            context.Database.EnsureCreated();

            //kui õpilaste tabelis juba on õpilasi, väljub funktsioonist
            if (context.Students.Any())
            {
                return;
            }
            //objekt õpilastega, mis lisatakse siis, kui õpilasi sisestatud ei ole
            var students = new Student[]
            {
                new Student {FirstMidName="Marko" , LastName="Vassiljev",EnrollmentDate=DateTime.Parse("2069-04-20")},
                new Student {FirstMidName="Meredith" , LastName="Alonso",EnrollmentDate=DateTime.Parse("2009-05-21")},
                new Student {FirstMidName="Adolf" , LastName="Berš",EnrollmentDate=DateTime.Parse("2007-09-25")},
                new Student {FirstMidName="Allan" , LastName="Lond",EnrollmentDate=DateTime.Parse("2054-12-31")},
                new Student {FirstMidName="James" , LastName="ProLegendary",EnrollmentDate=DateTime.Parse("2007-09-31")},
                new Student {FirstMidName="Yan" , LastName="LeagueRat",EnrollmentDate=DateTime.Parse("2002-09-25")},
                new Student {FirstMidName="Vassili" , LastName="Korbatšov",EnrollmentDate=DateTime.Parse("20021-5-01")},
                new Student {FirstMidName="Colt" , LastName="Yugugu",EnrollmentDate=DateTime.Parse("2012-01-23")},
                new Student {FirstMidName="Dyna" , LastName="Mike",EnrollmentDate=DateTime.Parse("2010-02-07")},
                new Student {FirstMidName="Baibai" , LastName="Deladela",EnrollmentDate=DateTime.Parse("1999-03-16")},
            };

            //iga õpilane lisatakse ükshaaval läbi foreach tsükli
            foreach (Student student in students)
            {
                context.Students.Add(student);
            }
            //ja andmebaasi muudatused salvestatakse
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050, Title="Keemia", Credits=3},
                new Course{CourseID=3212, Title="Matemaatika",Credits=3},
                new Course{CourseID=4041, Title="Saksa Keel",Credits=1},
                new Course{CourseID=1056, Title="Geograafia",Credits=2},
                new Course{CourseID=7544, Title="Calculus",Credits=2},
                new Course{CourseID=8264, Title="Trigonomeetria",Credits=3},
                new Course{CourseID=7467, Title="Muusika",Credits=3},
                new Course{CourseID=1111, Title="Eesti Keel",Credits=4},
            };
            foreach(Course course in courses)
            {
                context.Courses.Add(course);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                                new Enrollment{StudentID=1, CourseID=1050, Grade=Grade.A},
                new Enrollment{StudentID=1, CourseID=3212, Grade=Grade.C},
                new Enrollment{StudentID=1, CourseID=4041, Grade=Grade.B},

                new Enrollment{StudentID=2, CourseID=1056, Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=7544, Grade=Grade.F},
                new Enrollment{StudentID=2, CourseID=7544, Grade=Grade.F},

                new Enrollment{StudentID=3, CourseID=1111},

                new Enrollment{StudentID=4, CourseID=1111},
                new Enrollment{StudentID=4, CourseID=7467, Grade=Grade.F},

                new Enrollment{StudentID=5, CourseID=8264, Grade=Grade.C},

                new Enrollment{StudentID=6, CourseID=1111},

                new Enrollment{StudentID=7, CourseID=1050, Grade=Grade.A},

                new Enrollment{StudentID=10, CourseID=3212, Grade=Grade.A},
            };
            foreach (Enrollment enrollment in enrollments)
            {
                context.Enrollments.Add(enrollment);
            }
            context.SaveChanges();

            if (context.Departments.Any()) { return; }
            var departments = new Department[]
            {
                new Department
                {
                    Name = "InfoTechnology",
                    Budget = 0,
                    StartDate = DateTime.Parse("2024-09-01"),
                    FavoriteLesson = "Programming yeah yeah real",
                    InstructorID = 2,
                },
                 new Department
                {
                    Name = "SumTechnologyIG",
                    Budget = 0,
                    StartDate = DateTime.Parse("2024-09-01"),
                    FavoriteLesson = "I have no idea",
                    InstructorID = 1,
                },
                 new Department
                {
                    Name = "Military General George 202",
                    Budget = 0,
                    StartDate = DateTime.Parse("2024-11-01"),
                    FavoriteLesson = "Something bout military I think"
                }
            };
            context.Departments.AddRange(departments);
            context.SaveChanges();



        }
    } 
}
