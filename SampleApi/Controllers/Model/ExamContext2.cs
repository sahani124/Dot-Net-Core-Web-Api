using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers.Model
{
    public class ExamContext2 : DbContext
    {
        //db connection string to use
        public ExamContext2(DbContextOptions<ExamContext2> options) : base(options)
        {
        }
        public DbSet<Isyslookupparam> Isyslookupparam { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
