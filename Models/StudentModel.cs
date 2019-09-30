using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class StudentModel
    {
        public int SID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required")]
        [RegularExpression(@"^([a-zA-Z0-9]+|[a-zA-Z0-9]+\s{1}[a-zA-Z0-9]{1,}|[a-zA-Z0-9]+\s{1}[a-zA-Z0-9]{3,}\s{1}[a-zA-Z0-9]{1,})$", ErrorMessage = "Invalid Name")]
        public string SName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is Required")]
        public string SGender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is Required")]
        public string SAddress { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is Required")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Invalid Email")]
        public string SEmail { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Guardian Name is Required")]
        [RegularExpression(@"^([a-zA-Z0-9]+|[a-zA-Z0-9]+\s{1}[a-zA-Z0-9]{1,}|[a-zA-Z0-9]+\s{1}[a-zA-Z0-9]{3,}\s{1}[a-zA-Z0-9]{1,})$", ErrorMessage = "Invalid Guardian Name")]
        public string SGDName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Guardian Contact is Required")]
        [RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", ErrorMessage = "Invalid Contact Number")]
        public string SGDContact { get; set; }

        public DateTime SDob { get; set; }

        public string SPassword { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Grade is Required")]
        public string SGrade { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Class is Required")]
        public string SClass { get; set; }
    }
}
