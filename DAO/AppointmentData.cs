using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAO
{
    public class AppointmentData
    {

        public bool SaveAppointment(AppointmentModel appointmentmodel)
        {
            bool result = false;
            try
            {
                using (var db = new SchoolManagementSystemDBEntities())
                {
                    var appointment = new SAppointment
                    {
                        teacherName = appointmentmodel.TeacherName,
                        reason = appointmentmodel.Reason,
                        time = appointmentmodel.ADate
                    };
                    db.SAppointments.Add(appointment);
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
