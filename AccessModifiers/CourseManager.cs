using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class CourseManager
    {
        public void Add()
        {
            Course course = new Course(); // "Course" is an internal class. So you can use without referances
            course.Add();

            Student student = new Student();
            student.Save();
        }
    }
}
