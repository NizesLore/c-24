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
    
    public List<Course>  GetAll()
    {
        //business rules

        CourseDal courseDal=new CourseDal();
        return courseDal.GetAll();
       
        
    }


}
