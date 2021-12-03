using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Final_Project.Data
{
    public class StudentsContextDAO : IStudentsContextDAO
    {

       private StudentsContext _context;
        public StudentsContextDAO(StudentsContext context) 
        {
            _context = context;
        }

        public int? Add(Students students)
        {
            var student= _context.Student.Where(x => x.FirstName.Equals(students.FirstName) && x.LastName.Equals(students.LastName)).FirstOrDefault();

            if (student != null)
                return null;

            try 
            {
                _context.Student.Add(students);
                _context.SaveChanges();
                return 1;
            }

            catch(Exception)
            {
                return 0;
            }
        }

        public List<Students> GetAllStudent()
        {
            return _context.Student.ToList();
        }

        public Students GetStudentById(int id)
        {
            return _context.Student.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveStudentById(int id)
        {
            var student = this.GetStudentById(id);
            if (student == null) return null;
            try
            {
                _context.Student.Remove(student);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception) 
            {
                return  0;
            }            
        }

        public int? UpdateStudent(Students student)
        {
            var studentToUpdate = this.GetStudentById(student.Id);

            if (studentToUpdate == null)
                return null;

            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;
            studentToUpdate.Birthday = student.Birthday;
            studentToUpdate.Year = student.Year;
            studentToUpdate.Major = student.Major;


            try
            {
                _context.Student.Update(studentToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
