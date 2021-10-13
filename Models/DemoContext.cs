﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options):base(options)
        {

        }

        public DbSet<RegisterModel> Register { get; set; }
        
    }
}
