using c_24.DataAccess.Abstracts;
using c_24.DataAccess.Concretes;
using c_24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_24.Business;

public class CourseManager
{
    //dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        //business rules

        return _courseDal.GetAll();


    }


}
