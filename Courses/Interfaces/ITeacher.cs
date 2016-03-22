using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    public interface ITeacher
    {
        string teacherName { get; }

        //realize : void UpdateOnAcceptStudent(List<ICourseForTeacher> courses);

        //realize : void UpdateOnCourseFinish(List<ICourseForTeacher> courses);

        //realize : void UpdateOnMarkedStudent(List<ICourseForTeacher> courses);
    }
}
