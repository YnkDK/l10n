using DataAccess.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using NJsonSchema.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data
{
    public class L10nContext : DbContext
    {
        public L10nContext([NotNull] DbContextOptions<L10nContext> options) : base(options)
        {
        }

        public DbSet<Locale> Locales { get; set; }
        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locale>().ToTable(nameof(Locale));
            modelBuilder.Entity<Localization>().ToTable(nameof(Localization));
            modelBuilder.Entity<Organization>().ToTable(nameof(Organization));
            modelBuilder.Entity<Phrase>().ToTable(nameof(Phrase));
            modelBuilder.Entity<User>().ToTable(nameof(User));
        }
    }
}
