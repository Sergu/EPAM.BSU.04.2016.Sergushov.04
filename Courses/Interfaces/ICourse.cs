﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Interfaces
{
    public interface ICourse
    {
        string courseName { get; }
        ITeacher teacher { get; }
    }
}
