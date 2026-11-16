using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18.Models
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
    }
}
