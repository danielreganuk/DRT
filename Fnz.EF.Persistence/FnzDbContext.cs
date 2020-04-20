﻿using DRT.Application.Interfaces;
using DRT.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DRT.Persistence
{
    public class FnzDbContext : DbContext, IFnzDbContext
    {
        public FnzDbContext()
        {
        }

        public FnzDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountUser> AccountUsers { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<CaseNote> CaseNotes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FnzDbContext).Assembly);
        }
    }
}