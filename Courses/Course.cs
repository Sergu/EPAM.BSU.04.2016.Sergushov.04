using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Interfaces;

namespace Courses
{
    public class Course : ICourse , ICourseForTeacher
    {
        public readonly string courseName;
        public readonly ITeacher teacher;
        public List<IStudent> selectedStudents { get; private set; }
        public List<IStudent> requestedStudents { get; private set; }
        public Dictionary<IStudent, double> markedStudents { get; private set; }
        private bool isFinished = false;
        private Repository repository;
        public Course(string name, Teacher teacher, Repository repository)
        {
            this.courseName = name;
            this.teacher = teacher;
            this.repository = repository;
            
        }
        public bool LeaveRequest(IStudent NewStudent)
        {
            foreach (Student student in selectedStudents)
            {
                if (student.Equals(NewStudent))
                {
                    Notify();
                    requestedStudents.Add(NewStudent);
                }
            }
            selectedStudents.Add(NewStudent);
            return true;
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
