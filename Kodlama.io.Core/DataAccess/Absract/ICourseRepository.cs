﻿using Kodlama.io.Core.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Core.DataAccess.Absract
{
    public interface ICourseRepository
    {
        Course GetCourseById(int courseId);
        void CreateCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int courseId);
    }
}
