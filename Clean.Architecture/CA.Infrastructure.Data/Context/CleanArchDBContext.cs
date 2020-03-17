using CA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Infrastructure.Data.Context
{
    public class CleanArchDBContext: DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public CleanArchDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
