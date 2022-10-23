using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DarulAman.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

       
        public virtual DbSet<tbl_AccessLevel> tbl_AccessLevel { get; set; }
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_Book> tbl_Book { get; set; }
        public virtual DbSet<tbl_BookCategory> tbl_BookCategory { get; set; }
        public virtual DbSet<tbl_Contact> tbl_Contact { get; set; }
        public virtual DbSet<tbl_DeadRelative> tbl_DeadRelative { get; set; }
        public virtual DbSet<tbl_Decreased> tbl_Decreased { get; set; }
        public virtual DbSet<tbl_Donation> tbl_Donation { get; set; }
        public virtual DbSet<tbl_Event> tbl_Event { get; set; }
        public virtual DbSet<tbl_FAQs> tbl_FAQs { get; set; }
        public virtual DbSet<tbl_GeneralRegistrationForm> tbl_GeneralRegistrationForm { get; set; }
        public virtual DbSet<tbl_Institute> tbl_Institute { get; set; }
        public virtual DbSet<tbl_Marriage> tbl_Marriage { get; set; }
        public virtual DbSet<tbl_SchoolCourse> tbl_SchoolCourse { get; set; }
        public virtual DbSet<tbl_SchoolRegistration> tbl_SchoolRegistration { get; set; }
        public virtual DbSet<tbl_Slider> tbl_Slider { get; set; }
        public virtual DbSet<tbl_TeachingCourse> tbl_TeachingCourse { get; set; }
        public virtual DbSet<tbl_TeachingRegistration> tbl_TeachingRegistration { get; set; }
        public virtual DbSet<tbl_Team> tbl_Team { get; set; }
        public virtual DbSet<tbl_Volunteer> tbl_Volunteer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_AccessLevel>()
                .HasMany(e => e.tbl_Admin)
                .WithRequired(e => e.tbl_AccessLevel)
                .HasForeignKey(e => e.ACCESS_LEVEL_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_BookCategory>()
                .HasMany(e => e.tbl_Book)
                .WithRequired(e => e.tbl_BookCategory)
                .HasForeignKey(e => e.CATEGORY_FID)
                .WillCascadeOnDelete(false);

          
            modelBuilder.Entity<tbl_DeadRelative>()
                .HasMany(e => e.tbl_Decreased)
                .WithRequired(e => e.tbl_DeadRelative)
                .HasForeignKey(e => e.FUNERAL_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Donation>()
                .Property(e => e.AMOUNT)
                .HasPrecision(19, 4);
        }
    }
}
