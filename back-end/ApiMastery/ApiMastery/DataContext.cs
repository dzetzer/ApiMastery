﻿using ApiMastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery
{
    public class DataContext : DbContext
    {
        public DbSet<Series> Series { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ApiMastery;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Series>().HasData(
                new Series(1,"TestSeries")
            );
            modelBuilder.Entity<Game>().HasData(
                new Game(1,"TestGame",1)
            );
            modelBuilder.Entity<Comment>().HasData(
                new Comment(1, "TestComment", "TestBody", 1)
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
