using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    /// <summary>
    /// Ricardo Martinez.
    /// Creating entity Salary make reference
    /// to the main table of the database where
    /// we insert the next salary of each employee
    /// </summary>
    public class Salary
    {
        /// <summary>
        /// Primary key
        /// </summary>
        [Key]
        public int Id { set; get; }
        /// <summary>
        /// Salary year
        /// </summary>
        [Required]
        public int Year { set; get; }
        /// <summary>
        /// Salary Month
        /// </summary>
        [Required]
        public int Month { set; get; }
        /// <summary>
        /// Employee Code
        /// </summary>
        [Required]
        [StringLength(15)]
        public string EmployeeCode { set; get; }
        /// <summary>
        /// Employe Name this value 
        /// must be unique
        /// </summary>
        [Required]
        [StringLength(30)]
        public string EmployeeName { set; get; }
        /// <summary>
        /// Employee Last Name
        /// </summary>
        [Required]
        [StringLength(30)]
        public string EmployeeSurname { set; get; }
        /// <summary>
        /// Employee Grade
        /// </summary>
        [Required]
        public int Grade { set; get; }
        /// <summary>
        /// Is the Begin Date of the 
        /// employee in the company
        /// </summary>
        [Required]
        public DateTime BeginDate { set; get; }
        /// <summary>
        /// Employee BirthDay
        /// </summary>
        [Required]
        public DateTime Birthday { set; get; }
        /// <summary>
        /// Employee Identification Number
        /// </summary>
        [Required]
        public string IdentificationNumber { set; get; }
        /// <summary>
        /// Employee Base Salary
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BaseSalary { set; get; }
        /// <summary>
        /// Employee Production Bonus
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductionBonus { set; get; }
        /// <summary>
        /// Employee Compensation Bonus
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CompensationBonus { set; get; }
        /// <summary>
        /// Employee Comission 
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Commission { set; get; }
        /// <summary>
        /// Employee Contribution
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Contributions { set; get; }
        /// <summary>
        /// Office where the employee Belong
        /// </summary>
        [Required]
        [ForeignKey("OfficeID")]
        public int OfficeID { set; get; }
        /// <summary>
        /// Foreign Key references to table 
        /// Division
        /// </summary>
        [Required]
        [ForeignKey("DivisionID")]
        public int DivisionID { set; get; }
        /// <summary>
        /// Foreing Key references to table
        /// Position
        /// </summary>
        [Required]
        [ForeignKey("PositionID")]
        public int PositionID { set; get; }

        public virtual Office Office { set; get; }
        public virtual Division Division { set; get; }
        public virtual Position Position { set; get; }

    }
}
