using _01DiyetProjesi.DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Context.EF
{
    public class EfDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }
        public DbSet<DiyetTablosu> DiyetTablolari { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HALITERMET;Trusted_Connection=true;database=diyetdb;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
