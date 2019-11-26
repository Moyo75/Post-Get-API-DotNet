using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myAPIApp.Models
{
    public class TodoItemDbContext : DbContext
    {
        public TodoItemDbContext(DbContextOptions<TodoItemDbContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItem { get; set; }
    }
}
