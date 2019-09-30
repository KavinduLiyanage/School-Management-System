using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAO
{
    public class StudentData
    {
        public bool SaveStudent(StudentModel studentmodel)
        {
            bool result = false;
            try
            {
                using (var db = new SchoolManagementSystemDBEntities())
                {
                    var student = new Student()
                    {
                        SNAME = studentmodel.SName,
                        SEMAIL = studentmodel.SEmail,
                        SADDRESS = studentmodel.SAddress,
                        SGDNAME = studentmodel.SGDName,
                        SGDCONTACT = studentmodel.SGDContact,
                        SDOB = studentmodel.SDob,
                        SGENDER = studentmodel.SGender,
                        SPASSWORD = studentmodel.SEmail,
                        Grade = studentmodel.SGrade,
                        ClassName = studentmodel.SClass
                        
                    };
                    db.Students.Add(student);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}
