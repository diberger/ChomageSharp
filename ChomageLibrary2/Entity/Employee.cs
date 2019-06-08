using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChomageLibrary.Entity
{
    [DataContract]
    [Table("APP_EMPLOYEE")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EMP_ID")]
        public int Id { get; set; }

        [DataMember]
        [StringLength(50)]
        [Required]
        [Column("EMP_FIRSTNAME")]
        public string FirstName { get; set; }

        [DataMember]
        [StringLength(50)]
        [Required]
        [Column("EMP_LASTNAME")]
        public string LastName { get; set; }

        [Required]
        [Column("EMP_BIRTHDATE", TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter valid integer Number")]
        [Required]
        [Column("EMP_SENIORITY")]
        public int Seniority { get; set; }

        [StringLength(255)]
        [Required]
        [Column("EMP_BIOGRAPHY")]
        public string Biography { get; set; }

        public ICollection<Experience> Experiences { get; set; }

        public ICollection<Formation> Formations { get; set; }

        public ICollection<Postulation> Postulations { get; set; }

        public Employee(string firstName, string lastName, DateTime birthDate, int seniority, string biography)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Seniority = seniority;
            this.Biography = biography;
        }

        public Employee()
        {
        }
    }
}
