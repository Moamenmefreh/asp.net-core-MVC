using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Center.Models
{
    public class MatrialsRecord
    {
        [ForeignKey(nameof(Student)),Key]
        public int StudentId { get; set; }
        public bool Arabic { get; set; }
        public bool English { get; set; } 
        public bool Math { get; set; }
        public bool Physics { get; set; }

        public bool Biology { get; set; }
    }
}
