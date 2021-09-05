﻿namespace Radex.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Threading.Tasks;

    public class Db : DbContext
    {
        public Db()
        {

        }

        public Db(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server =.; Database = Radex; Integrated Security=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{


        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
