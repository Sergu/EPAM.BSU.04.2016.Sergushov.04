using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    interface ICourseForTeacher
    {
        readonly string courseName;
        List<IStudent> students;
        Dictionary<IStudent, double> markedStudents;
    }
}
