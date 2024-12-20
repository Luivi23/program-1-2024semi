﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_academico.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey(e => e.idAlumno);
            modelBuilder.Entity<Docente>().HasKey(e => e.idDocente);
            modelBuilder.Entity<Matricula>().HasKey(e => e.idMatricula);
            //Relacion de matricula hacia alumnos de uno a muchos.
            modelBuilder.Entity<Matricula>()
                .HasOne(m=> m.Alumno)
                .WithMany(a => a.Matriculas)
                .HasForeignKey(m => m.idAlumno)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
