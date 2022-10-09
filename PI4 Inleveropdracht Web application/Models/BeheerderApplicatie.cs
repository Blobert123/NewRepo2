namespace PI4_Inleveropdracht_Web_application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BeheerderApplicatie")]
    public partial class BeheerderApplicatie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BeheerderId { get; set; }

        public int ProjectId { get; set; }
    }
}
