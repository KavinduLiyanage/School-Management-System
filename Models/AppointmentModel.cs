using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AppointmentModel
    {
        public String AppointmentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required")]
        public String TeacherName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Reason is Required")]
        public String Reason { get; set; }

        public DateTime ADate { get; set; }

    }
}
