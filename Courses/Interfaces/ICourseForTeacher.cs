using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    interface ICourseForTeacher
    {
        List<IStudent> selectedStudents;
        List<IStudent> requestedStudents;
        Dictionary<IStudent, double> markedStudents;
    }
}
