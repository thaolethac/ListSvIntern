﻿using ListSvIntern.Models;
using Microsoft.EntityFrameworkCore;

namespace ListSvIntern.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        
        public DbSet<Student> Students { get; set; }
    }
}
