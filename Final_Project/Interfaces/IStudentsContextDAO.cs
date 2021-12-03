using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;


namespace Final_Project.Data
{
    public interface IStudentsContextDAO
    {
        List<Students> GetAllStudent();
       Students GetStudentById(int id);
        int?  RemoveStudentById(int id);
        int? UpdateStudent(Students student);
        int? Add(Students students);
    }

}