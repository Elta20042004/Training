using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyTest
{
    class Library
    {

    }

    class CourseGrade : IComparable         // kursovaya ocenka
    {
        public int Grade { get; set; }             //ocenka
        public int Credits { get; set; }           //bally

        public int CompareTo(object obj)
        {
            CourseGrade kursovayaRabota = obj as CourseGrade;
            if (this.Grade == kursovayaRabota.Grade)
            {
                if (this.Credits > kursovayaRabota.Credits)
                {
                    return 1;
                }

                return -1;

            }
            if (this.Grade > kursovayaRabota.Grade)
            {
                return 1;
            }
            if (this.Grade < kursovayaRabota.Grade)
            {
                return -1;
            }
            return 0;
        }
    }

    class Student : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CourseGrade CourseGrade { get; set; }

        public int CompareTo(object obj)
        {
            Student newStudent = obj as Student;
            int k = this.CourseGrade.CompareTo(newStudent.CourseGrade);
            return k;
        }
    }

    class StudentIDComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Student student = x as Student;
            Student student2 = y as Student;

            int k = student.Id.CompareTo(student2.Id);
            return k;
        }
    }

    class StudentGradeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Student student = x as Student;
            Student student2 = y as Student;

            int k = student.CourseGrade.CompareTo(student2.CourseGrade);
            return k;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Alex = new Student();
            CourseGrade kurs = new CourseGrade();
            Alex.CourseGrade = kurs;
            Alex.Id = 3434;
            Alex.Name = "Cherny";
            kurs.Grade = 5;
            kurs.Credits = 5;
           

            Student Avi = new Student();
            CourseGrade kurs2 = new CourseGrade();
            Avi.CourseGrade = kurs2;
            Avi.Id = 5636;
            Avi.Name = "Popov";
            kurs2.Grade = 5;
            kurs2.Credits = 3;

           
            //int b = Alex.CompareTo(Avi);
            //int c = idComparer.Compare(Alex, Avi);
            Student[] students=new []
            {
               Alex, 
               Avi, 
            };
            Array.Sort(students);
        }
    }
}
