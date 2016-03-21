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
        bool FinishCourse(ICourseForTeacher course);
        bool EstimateStudent(ICourseForTeacher course, IStudent student, ITeacher teacher,double mark);
    }
}
