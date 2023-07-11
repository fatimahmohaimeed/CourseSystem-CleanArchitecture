using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Domain
{
    public class Coursee
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        //Many to Many Relation
        public IList<CourseRental> CourseRentals { get; set; }
    }
}
