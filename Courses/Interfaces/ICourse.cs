using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    interface ICourse
    {
        readonly string courseName;
        readonly ITeacher teacher;
    }
}
