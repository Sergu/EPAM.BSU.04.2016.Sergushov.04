using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Interfaces;

namespace Courses
{
    public class Teacher : ITeacher
    {
        public readonly string teacherName;
        public readonly Repository repository;
        private List<ICourse> currentCourses;
        public Teacher(string name, Repository repository)
        {
            this.teacherName = name;
            this.repository = repository;
        }
        public void AddCourse(string courseName)
        {


        }
    }
}
