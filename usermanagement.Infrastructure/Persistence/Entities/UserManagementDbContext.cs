using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace usermanagement.Infrastructure.Persistence.Entities
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options) : base(options)
        { 
             
        }

        public DbSet<User> Users { get; set; }
    }
}
