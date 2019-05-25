using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChomageLibrary.Entity
{
    [Table("APP_OFFER")]
    public class Offer
    {
        [Key]
        [Column("OFF_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        [Column("OFF_TITLE")]
        public string Title { get; set; }

        [Required]
        [Column("OFF_DATE", TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Required]
        [Column("OFF_SALARY")]
        public string Salary { get; set; }

        [StringLength(255)]
        [Required]
        [Column("OFF_DESCRIPTION")]
        public string Description { get; set; }

        [ForeignKey("StatutId")]
        public Statut Statut { get; set; }

        [Column("STA_ID")]
        public int StatutId { get; set; }

        [StringLength(255)]
        [Required]
        [Column("OFF_RESPONSIBLE")]
        public string Responsible { get; set; }
        public ICollection<Postulation> Postulations { get; set; }
    }
}
