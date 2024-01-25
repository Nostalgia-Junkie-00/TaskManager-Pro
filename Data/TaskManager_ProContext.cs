using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager_Pro.Models;

namespace TaskManager_Pro.Data
{
    public class TaskManager_ProContext : DbContext
    {
        public TaskManager_ProContext (DbContextOptions<TaskManager_ProContext> options)
            : base(options)
        {
        }

        public DbSet<TaskManager_Pro.Models.Task> Task { get; set; } = default!;
    }
}
