using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChomageLibrary.Entity
{
    [Table("APP_POSTULATION")]
    public class Postulation
    {
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [Key, Column("EMP_ID", Order = 0)]
        public int EmployeeId { get; set; }

        [ForeignKey("OfferId")]
        public Offer Offer { get; set; }

        [Key, Column("OFF_ID", Order = 1)]
        public int OfferId { get; set; }

        [Required]
        [Column("POS_DATE", TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [StringLength(255)]
        [Required]
        [Column("POS_STATUS")]
        public string Status { get; set; }

    }
}
