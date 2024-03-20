using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers.Model
{
    public class ExamContext : DbContext
    {
        //db connection string to use
        public ExamContext(DbContextOptions<ExamContext> options) : base(options)
        {
        }
        public DbSet<CndPer> CndPer { get; set; }
        public DbSet<ApiResult> ApiResult { get; set; }
        public DbSet<ExmCentreList> ExmCentreList { get; set; }
        public DbSet<Isyslookupparam> Isyslookupparam { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CndPer>().HasNoKey();
            modelBuilder.Entity<ApiResult>().HasNoKey();
            modelBuilder.Entity<ExmCentreList>().HasNoKey();
        }
    }
}
