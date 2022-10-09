namespace PI4_Inleveropdracht_Web_application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Project Naam")]
        public string naam { get; set; }

        [StringLength(500)]
        [Display(Name ="Beschrijving")]
        public string beschrijving { get; set; }

        [StringLength(25)]
        [Display(Name ="Taal")]
        public string taal { get; set; }

        [UIHint("IsActive")]
        [Display(Name ="Actief")]
        public bool actief { get; set; }
    }
}
