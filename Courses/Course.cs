using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Interfaces;

namespace Courses
{
    public class Course : ICourse , ICourseForTeacher,IEquatable<Course>
    {
        public string courseName { get; private set; }
        public ITeacher teacher { get; private set; }
        public List<IStudent> students { get; private set; }
        public Dictionary<IStudent, double> markedStudents { get; private set; }
        private bool isFinished = false;
        public Course(string name, ITeacher teacher)
        {
            this.courseName = name;
            this.teacher = teacher;            
        }
        public bool Equals(Course other)
        {
            if (other == null)
            {
                return false;
            }
            if (this.courseName == other.courseName)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Course course = obj as Course;
            if (course == null)
                return false;
            return Equals(course);
        }
        
    }
}
