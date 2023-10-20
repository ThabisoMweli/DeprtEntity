using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeprtEntity.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [StringLength(50)]
        [Display(Name = "Department name")]
        public string DepartmentName { get; set; }

        public Manager Managers { get; set; }
        public int managerId { get; set; }
    }

    public class Manager
    {
        public int ID { get; set; }

        [Display(Name = "Last Name"), StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Column("FirstName"), Display(Name = "First Name"), StringLength(50, MinimumLength = 1)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date), Display(Name = "Hire Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstMidName + "  " + LastName; }
        }

    }
}