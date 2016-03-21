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
        public string studentName { get; private set; }
        public IRepositoryForStudent repository { get; private set; }
        public List<ICourse> newCourses {get;private set;}
        public List<ICourse> currentCourses {get;private set;}
        public Dictionary<ICourse, double> markedCourses {get;private set;}
        public Student(string name, IRepositoryForStudent repository)
        {
            this.studentName = name;
            this.repository = repository;
            this.newCourses = new List<ICourse>();
            this.currentCourses = new List<ICourse>();
            this.markedCourses = new Dictionary<ICourse,double>();
        }
        public bool MakeRequestOnCourse(ICourse course)
        {
            if (newCourses.Contains(course))
            {
                return repository.AcceptStudentOnCourse((IStudent)this, course);
            }
            return false;
        }
        public void UpdateOnAcceptToCourse(List<ICourse> newCourses, List<ICourse> currentCourses)
        {
            this.newCourses = newCourses;
            this.currentCourses = currentCourses;
        }
        public void UpdateOnFinishCourse(List<ICourse> currentCourses, Dictionary<ICourse, double> markedCourses)
        {
            this.currentCourses = currentCourses;
            this.markedCourses = markedCourses;
        }
        public void UpdateOnCourseCreated(List<ICourse> newCourses)
        {
            this.newCourses = newCourses;
        }

        public bool Equals(IStudent other)
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
