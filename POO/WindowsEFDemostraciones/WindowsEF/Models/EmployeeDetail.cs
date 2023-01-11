using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("EmployeeDetail")]
    public class EmployeeDetail
    {
        [Key, ForeignKey("Employee")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId
        {
            get;
            set;
        }
        [StringLength(10)]
        public string Gender
        {
            get;
            set;
        }
        [StringLength(255)]
        public string EmailAddress
        {
            get;
            set;
        }
        [StringLength(50)]
        public string PhoneNumber
        {
            get;
            set;
        }
        public  Employee Employee
        {
            get;
            set;
        }
    }


}
