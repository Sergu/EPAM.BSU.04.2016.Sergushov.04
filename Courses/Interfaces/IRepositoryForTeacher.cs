using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    interface IRepositoryForTeacher
    {
        bool CreateCourse(string courseName, ITeacher teacher);
        bool FinishCourse(ICourse course);
        bool EstimateStudent(ICourse course, IStudent student, ITeacher teacher);
        bool EcceptStudentOnCourse(ICourse course, IStudent student, ITeacher teacher);
    }
}
