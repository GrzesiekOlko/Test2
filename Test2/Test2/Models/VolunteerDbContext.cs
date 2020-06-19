using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class VolunteerDbContext : DbContext
    {
        public DbSet<Volunteer> Volunteers{get;set;}
        public DbSet<Volunteer_Pet> Volunteer_Pets { get; set; }
        public DbSet<Pet> Pets { get; set; }

        public DbSet<BreedType> BreedTypes { get; set; }

        public VolunteerDbContext() { 
        
        }

        public VolunteerDbContext(DbContextOptions options):base(options) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Volunteer>(opt =>
            {
                opt.HasKey(p => p.IdVolunteer);
                opt.Property(p => p.IdVolunteer).ValueGeneratedOnAdd();

                opt.Property(p => p.Name).HasMaxLength(80).IsRequired();

                opt.Property(p => p.Surname).HasMaxLength(80).IsRequired();

                opt.Property(p => p.Phone).HasMaxLength(30).IsRequired();

                opt.Property(p => p.Address).HasMaxLength(100).IsRequired();

                opt.Property(p => p.Email).HasMaxLength(80).IsRequired();

                opt.HasOne(p => p.IdVolunteer).WithMany(p => p.volunteers).HasForeingKey(p => p.IdVolunteer);

                opt.HasMany(p => p.IdSupervisor).WithOne(p => p.IdVolunteer).HasForeingKey(p => p.IdSupervisor);
            });

            modelBuilder.Entity<Pet>(opt =>
            {
                opt.HasKey(p => p.IdPet);
                opt.Property(p => p.IdPet).ValueGeneratedOnAdd();
                opt.Property(p => p.Name).HasMaxLength(80).IsRequired();
                opt.HasOne(p => p.IdPet).WithMany(p => p.pets).HasForeingKey(p => p.IdPet);

            });
            modelBuilder.Entity<BreedType>(opt => {
                opt.HasKey(p => p.IdBreedType);
                opt.Property(p => p.IdBreedType).ValueGeneratedOnAdd();

                opt.Property(p => p.Name).HasMaxLength(50).IsRequired();

                opt.Property(p => p.Description).HasMaxLength(500);
            });
            modelBuilder.Entity<Volunteer_Pet>(opt =>
            {

            });
        }
    }
}
