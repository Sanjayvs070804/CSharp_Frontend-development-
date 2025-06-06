using Microsoft.EntityFrameworkCore;
using System;
using VisitorManagementSystem.Models;
using VisitorManagementSystem.Models.Entites;

namespace VisitorManagementSystem.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<VisitorRequest> visitorRequests { get; set; }
        public object VisitorRequest { get; internal set; }
    }
}
