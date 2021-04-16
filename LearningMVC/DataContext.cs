using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningMVC
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}