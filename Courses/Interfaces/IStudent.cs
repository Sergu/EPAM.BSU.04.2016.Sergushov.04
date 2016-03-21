using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    interface IStudent : IEquatable<IStudent>
    {
        readonly string studentName;
        void UpdateOnAcceptToCourse(List<ICourse> newCourses, List<ICourse> currentCourses);
        void UpdateOnFinishCourse(List<ICourse> currentCourses, Dictionary<ICourse, double> markedCourses);
        void UpdateOnCourseCreated(List<ICourse> newCourses);
    }
}
