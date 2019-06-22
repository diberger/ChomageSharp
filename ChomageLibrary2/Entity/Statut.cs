using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChomageLibrary.Entity
{
    [Table("APP_STATUT")]
    public class Statut
    {
        [Key]
        [Column("STA_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        [Column("STA_LABEL")]
        public string Label { get; set; }

        public ICollection<Offer> Offers { get; set; }

    }
}
