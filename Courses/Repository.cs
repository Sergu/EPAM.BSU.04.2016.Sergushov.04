using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Interfaces;

namespace Courses
{
    public class Repository : IRepository
    {
        private List<IStudent> students = new List<IStudent>();
        private List<ITeacher> teachers = new List<ITeacher>();
        private List<Course> currentCourses = new List<Course>();
        private List<Course> finishedCourses = new List<Course>();
        public Repository(List<Student> students, List<Teacher> teachers)
        {
            this.students = students;
            this.teachers = teachers;
        }
        public Teacher CreateTeacher(string teacherName)
        {
            foreach(ITeacher teacher in teachers)
            {
                if(teacher.teacherName == teacherName)
                {
                    return null;
                }
            }
            Teacher newTeacher = new Teacher(teacherName,()this);
            return Teacher()
        }
        public Repository() { }

        public bool CreateCourse(string courseName, Teacher teacher)
        {
            Course newCourse = new Course(courseName, teacher, this);
            foreach (Course course in currentCourses)
            {
                if (course.Equals(newCourse))
                {
                    return false;
                }
            }
            currentCourses.Add(newCourse);
            notifyStudents();
            return true;
        }
    }
}
