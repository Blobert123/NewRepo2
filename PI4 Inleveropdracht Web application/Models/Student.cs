namespace PI4_Inleveropdracht_Web_application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Studentnummer")]
        public int StudentId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name ="Naam")]
        public string StudentNaam { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Display(Name ="Wachtwoord ")]
        public string StudentWachtwoord { get; set; }
    }
}
