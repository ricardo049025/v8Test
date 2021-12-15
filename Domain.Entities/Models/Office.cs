using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    /// <summary>
    /// Ricardo Martinez.
    /// Creating Entity Office make reference
    /// to Office Table
    /// </summary>
    public class Office
    {
        /// <summary>
        /// Primary key
        /// </summary>
        [Key]
        public int Id { set; get; }
        /// <summary>
        /// Office's Name
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { set; get; }
    }
}
