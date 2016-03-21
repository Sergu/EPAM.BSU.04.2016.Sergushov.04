using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    interface ITeacher
    {
        readonly string teacherName;
        void UpdateOnAcceptToCourse(List<ICourseForTeacher> currentCourses);
    }
}
