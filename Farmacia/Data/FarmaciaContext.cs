using Farmacia.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;

namespace Farmacia.Data
{
    public class FarmaciaContext
    {
        public FarmaciaContext(DbContextOptions<FarmaciaContext> options) : base(options)
        {
            
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Provider> Provider { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>().HasData(
                new Provider()
                {
                    Id = 1,
                    GradeName = "Primero",
                    Section = 'A'
                },
                new Provider()
                {
                    Id = 2,
                    GradeName = "Primero",
                    Section = 'B'
                });
            modelBuilder.Entity<Producto>().HasData(
                new Producto()
                {
                    StudentId = 1,
                    StudentName = "Marcela Padilla",
                    DateOfBirth = new DateTime(2018, 12, 23),
                    GradeId = 1
                },
                new Producto()
                {
                    StudentId = 2,
                    StudentName = "Leonardo Amador",
                    DateOfBirth = new DateTime(2019, 7, 25),
                    GradeId = 2
                },
                new Producto()
                {
                    StudentId = 3,
                    StudentName = "Karla Reyes",
                    DateOfBirth = new DateTime(2017, 6, 5),
                    GradeId = 1
                });
        }
    }
}
