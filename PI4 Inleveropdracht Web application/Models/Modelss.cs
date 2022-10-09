using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PI4_Inleveropdracht_Web_application.Models
{
    public partial class Modelss : DbContext
    {
        public Modelss()
            : base("name=Modelss")
        {
        }

        public virtual DbSet<Applicatie> Applicaties { get; set; }
        public virtual DbSet<Beheerder> Beheerders { get; set; }
        public virtual DbSet<BeheerderApplicatie> BeheerderApplicaties { get; set; }
        public virtual DbSet<BeheerderProject> BeheerderProjects { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectApplicatie> ProjectApplicaties { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicatie>()
                .Property(e => e.naam)
                .IsUnicode(false);

            modelBuilder.Entity<Applicatie>()
                .Property(e => e.beschrijving)
                .IsUnicode(false);

            modelBuilder.Entity<Beheerder>()
                .Property(e => e.BeheerderNaam)
                .IsUnicode(false);

            modelBuilder.Entity<Beheerder>()
                .Property(e => e.BeheerderWachtwoord)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.naam)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.beschrijving)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.taal)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentNaam)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentWachtwoord)
                .IsUnicode(false);
        }
    }
}
