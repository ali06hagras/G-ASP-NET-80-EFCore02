using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {

        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
    }
}
