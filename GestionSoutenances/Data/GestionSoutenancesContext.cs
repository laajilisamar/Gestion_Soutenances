using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionSoutenances.Models;

    public class GestionSoutenancesContext : DbContext
    {
        public GestionSoutenancesContext (DbContextOptions<GestionSoutenancesContext> options)
            : base(options)
        {
        }

        public DbSet<Enseignant> Enseignant { get; set; } = default!;

        public DbSet<Etudiant> Etudiant { get; set; } = default!;

        public DbSet<PFE> PFE { get; set; } = default!;

        public DbSet<PFE_Etudiant> PFE_Etudiant { get; set; } = default!;

        public DbSet<Societe> Societe { get; set; } = default!;
    }
