using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChomageLibrary.Entity
{
    [Table("APP_FORMATION")]
    public class Formation
    {
        [Key]
        [Column("FOR_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [Column("EMP_ID")]
        public int EmployeeId { get; set; }

        [StringLength(255)]
        [Required]
        [Column("EXP_TITLE")]
        public string Title { get; set; }

        [Required]
        [Column("EXP_DATE", TypeName = "datetime2")]
        public DateTime Date { get; set; }

    }
}
