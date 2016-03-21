using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    public interface ICourseForTeacher
    {
        string courseName { get; }
        List<IStudent> students { get; }
        Dictionary<IStudent, double> markedStudents { get; }
    }
}
