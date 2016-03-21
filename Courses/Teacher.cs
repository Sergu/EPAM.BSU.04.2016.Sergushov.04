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
        public string teacherName { get; private set; }
        public IRepositoryForTeacher repository { get; private set; }
        private List<ICourseForTeacher> currentCourses = new List<ICourseForTeacher>();
        public Teacher(string name, IRepositoryForTeacher repository)
        {
            this.teacherName = name;
            this.repository = repository;
        }
        public bool CreateCourse(string courseName)
        {
            return repository.CreateCourse(courseName, (ITeacher)this);
        }
        public bool FinishCourse(ICourseForTeacher course)
        {
            return repository.FinishCourse(course);
        }
        public bool EstimateStudentByMark(ICourseForTeacher course, IStudent student, ITeacher teacher, double mark)
        {
            return repository.EstimateStudent(course, student, teacher, mark);
        }
    }
}
