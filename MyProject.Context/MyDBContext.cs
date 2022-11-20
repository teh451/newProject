using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Context
{
    public class MyDBContext:DbContext
    {
        public DbSet<Role> MyProperty { get; set; }
    }
}
