﻿using Microsoft.EntityFrameworkCore;
using WebAPIG3.APIG3.Models;

namespace WebAPIG3.APIG3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Ciudad> Ciudades { get; set; }
        public virtual DbSet<Depto> Deptos { get; set; }
    }
}
