using c_24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_24.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
    }
}
