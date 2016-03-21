using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    interface IStudent
    {
        readonly string studentName;
        void Update(List<ICourse> requestCourses, List<ICourse> currentCourses, Dictionary<ICourse, double> markedCourses);
    }
}
