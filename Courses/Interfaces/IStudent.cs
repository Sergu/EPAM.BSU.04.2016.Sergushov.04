using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    public interface IStudent : IEquatable<IStudent>
    {
        string studentName { get; }
        void UpdateOnAcceptToCourse(List<ICourse> newCourses, List<ICourse> currentCourses);
        void UpdateOnFinishCourse(List<ICourse> currentCourses, Dictionary<ICourse, double> markedCourses);
        void UpdateOnCourseCreated(List<ICourse> newCourses);
    }
}
