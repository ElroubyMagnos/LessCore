using ElroubyLessCore.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElroubyLessCore
{
    public class lesscore: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\lesscore.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<FileSave> Files { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
