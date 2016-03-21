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
        public Teacher CreateTeacher(string teacherName)
        {
            foreach(ITeacher teacher in teachers)
            {
                if(teacher.teacherName == teacherName)
                {
                    return null;
                }
            }
            Teacher newTeacher = new Teacher(teacherName,(IRepositoryForTeacher)this);
            teachers.Add((ITeacher)newTeacher);
            return newTeacher;
        }
        public Student CreateStudent(string studentName)
        {
            foreach(IStudent student in students)
            {
                if(student.studentName == studentName)
                {
                    return null;
                }
            }
            Student newStudent = new Student(studentName, (IRepositoryForStudent)this);
            students.Add((IStudent)newStudent);
            return newStudent;
        }

        public Repository() { }

        public bool CreateCourse(string courseName, ITeacher teacher)
        {
            Course newCourse = new Course(courseName, teacher);
            foreach (Course course in currentCourses)
            {
                if (course.Equals(newCourse))
                {
                    return false;
                }
            }
            currentCourses.Add(newCourse);
            NotifyAllStudentsOnCourseCreate();
            return true;
        }
        public bool AcceptStudentOnCourse(IStudent student, ICourse selectedCourse)
        {
            Course course = currentCourses.Find(x => x.Equals((Course)selectedCourse));
            if (course.Equals(null))
            {
                return false;
            }
            course.students.Add(student);
            NotifyStudentOnAccept(student);
            return true;
        }
        public bool FinishCourse(ICourseForTeacher course)
        {
            Course curCourse = course as Course;
            if(!curCourse.Equals(null))
            {
                if(currentCourses.Remove(curCourse))
                {
                    finishedCourses.Add(curCourse);
                    return true;
                }
            }
            return false;
             
        }
        public bool EstimateStudent(ICourseForTeacher course, IStudent student, ITeacher teacher, double mark)
        {
            Course curCourse = course as Course;
            if (!curCourse.Equals(null))
            {
                if(curCourse.students.Contains(student))
                {
                    curCourse.markedStudents.Add(student, mark);
                }
            }
            return false;
        }
        private void NotifyAllStudentsOnCourseCreate()
        {
            foreach(IStudent student in students)
            {
                List<ICourse> newCourses = new List<ICourse>();
                foreach(Course course in currentCourses)
                {
                    if (!course.students.Contains(student))
                    {
                        newCourses.Add(course);
                    }
                }
                student.UpdateOnCourseCreated(newCourses);
            }
        }
        private void NotifyStudentOnAccept(IStudent student)
        {
            List<ICourse> newCourses = new List<ICourse>();
            List<ICourse> presentCourses = new List<ICourse>();
            foreach(Course course in currentCourses)
            {
                if(course.students.Contains(student))
                {
                    presentCourses.Add((ICourse)course);
                }
                else
                {
                    newCourses.Add((ICourse)course);
                }
            }
            student.UpdateOnAcceptToCourse(newCourses,presentCourses);          
        }
        private void NotifyStudentsOnCourseFinished(ICourse course)
        {
            Course curCourse = course as Course;
            if(!curCourse.Equals(null))
            {
                foreach(IStudent student in curCourse.students)
                {
                    NotifyStudentOnCourseFinished(course,student);
                }
            }
        }
        private void NotifyStudentOnCourseFinished(ICourse course,IStudent student)
        {
            List<ICourse> curCourses = new List<ICourse>();
            Dictionary<ICourse, double> markedCourses = new Dictionary<ICourse, double>();
            foreach(Course curCourse in currentCourses)
            {
                if(curCourse.students.Contains(student))
                {
                    curCourses.Add(curCourse);
                }
            }
            foreach(Course curCourse in finishedCourses)
            {
                if(curCourse.markedStudents.ContainsKey(student))
                {
                    markedCourses.Add(course, curCourse.markedStudents[student]);
                }
            }
            student.UpdateOnFinishCourse(curCourses, markedCourses);
        }
    }
}
