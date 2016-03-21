using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    interface IRepositoryForStudent
    {
        bool AcceptStudentOnCourse(IStudent student, ICourse selectedCourse);
    }
}
