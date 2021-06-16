using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devmon.Models
{
    public class AppDbContext:DbContext
    {
        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ms02>().ToTable("ms02");
            modelBuilder.Entity<ms02>(entity =>
            {
                entity.Property(e => e.id).HasColumnName("id");
                entity.Property(e => e.lokasi).HasColumnName("lokasi");
                entity.Property(e => e.ip).HasColumnName("ip");
                entity.Property(e => e.mac).HasColumnName("mac");
                entity.Property(e => e.sensorsuhu_in).HasColumnName("sensorsuhu_in");
                entity.Property(e => e.sensorsuhu_out).HasColumnName("sensorsuhu_out");

            });
            modelBuilder.Entity<ms02>().HasKey(e => new { e.id });

            modelBuilder.Entity<ms04>().ToTable("ms04");
            modelBuilder.Entity<ms04>(entity =>
            {
                entity.Property(e => e.id).HasColumnName("id");
                entity.Property(e => e.lokasi).HasColumnName("lokasi");
                entity.Property(e => e.ip).HasColumnName("ip");
                entity.Property(e => e.mac).HasColumnName("mac");
                entity.Property(e => e.sensorsuhu_in).HasColumnName("sensorsuhu_in");
                entity.Property(e => e.sensorsuhu_out).HasColumnName("sensorsuhu_out");
                entity.Property(e => e.voltage_ac).HasColumnName("voltage_ac");
                entity.Property(e => e.voltage_dc).HasColumnName("voltage_dc");
                entity.Property(e => e.ampere_ac).HasColumnName("ampere_ac");
                entity.Property(e => e.ampere_dc).HasColumnName("ampere_dc");
            });
            modelBuilder.Entity<ms04>().HasKey(e => new { e.id });

            modelBuilder.Entity<ms06>().ToTable("ms06");
            modelBuilder.Entity<ms06>(entity =>
            {
                entity.Property(e => e.id).HasColumnName("id");
                entity.Property(e => e.lokasi).HasColumnName("lokasi");
                entity.Property(e => e.ip).HasColumnName("ip");
                entity.Property(e => e.mac).HasColumnName("mac");
                entity.Property(e => e.voltage_ac).HasColumnName("voltage_ac");
                entity.Property(e => e.voltage_ac_2).HasColumnName("voltage_ac_2");
                entity.Property(e => e.voltage_dc).HasColumnName("voltage_dc");
                entity.Property(e => e.voltage_dc_2).HasColumnName("voltage_dc_2");
                entity.Property(e => e.ampere_ac).HasColumnName("ampere_ac");
                entity.Property(e => e.ampere_ac_2).HasColumnName("ampere_ac_2");
                entity.Property(e => e.ampere_dc).HasColumnName("ampere_dc");
                entity.Property(e => e.ampere_dc_2).HasColumnName("ampere_dc");

            });
            modelBuilder.Entity<ms06>().HasKey(e => new { e.id });


        }
        public virtual DbSet<ms02> ms_02 { get; set; }
        public virtual DbSet<ms04> ms_04 { get; set; }
        public virtual DbSet<ms06> ms_06 { get; set; }


    }

}
