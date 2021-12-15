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
    /// Creating entity Division make
    /// reference to Division table
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public int Id { set; get; }
        /// <summary>
        /// Position's Name
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { set; get; }
    }
}
