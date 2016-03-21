using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Interfaces;

namespace Courses
{
    public class Student : IStudent
    {
        public readonly string studentName;
        public readonly Repository repository;
        private List<ICourse> requestCourses;
        private List<ICourse> currentCourses;
        private Dictionary<ICourse, double> markedCourses;
        public Student(string name, Repository repository)
        {
            this.studentName = name;
            this.repository = repository;
        }
        public bool Equals(Student other)
        {
            if (other == null)
            {
                return false;
            }
            if (this.studentName == other.studentName)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Student student = obj as Student;
            if (student == null)
                return false;
            return Equals(student);
        }
    }
}
