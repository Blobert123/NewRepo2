namespace PI4_Inleveropdracht_Web_application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Beheerder")]
    public partial class Beheerder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Beheerder ID")]
        public int BeheerderId { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name ="Naam")]
        public string BeheerderNaam { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Display(Name ="Wachtwoord ")]
        public string BeheerderWachtwoord { get; set; }
    }
}
