using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models.Sınıflar
{
    public class Context:DbContext
    {

        public DbSet<Admin> Admins { get; set; }
        public DbSet<adress> Adresses { get; set; }
        public DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public DbSet<İletişim> İletişims { get; set; }
        public DbSet<yorumlar> Yorumlars { get; set; }
    }
}