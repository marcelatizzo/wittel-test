﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web.SPA.serverapp.models
{
    public partial class dbCoreContext : DbContext
    {
        public virtual DbSet<User> User { get; set; }

        public dbCoreContext(DbContextOptions<dbCoreContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-7OJNKVF;Database=dbCore;Trusted_Connection=True;");
            //}
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.Property(e => e.Nome).HasMaxLength(150);
        //    });
        //}
    }
}
