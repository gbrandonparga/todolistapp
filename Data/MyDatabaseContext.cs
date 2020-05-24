using System;
using Microsoft.EntityFrameworkCore;

namespace ToDoListApp.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Todo> Todo { get; set; }
    }
}
