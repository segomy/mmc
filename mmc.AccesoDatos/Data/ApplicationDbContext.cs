﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static mmc.AccesoDatos.Data.ApplicationDbContext;
using mmc.Modelos;
using mmc.Modelos.ConsultasMovil;

namespace mmc.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Modelo> Modelos { get; set; }

        public DbSet<Serie> Serie { get; set; }

        public DbSet<UsuarioAplicacion> UsuarioAplicacion{get; set;}



    }
}
