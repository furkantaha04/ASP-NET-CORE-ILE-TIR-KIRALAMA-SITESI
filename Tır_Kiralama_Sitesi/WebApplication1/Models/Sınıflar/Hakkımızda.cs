using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Sınıflar
{
    public class Hakkımızda
    {
        [Key]
        public int ID { get; set; }
        public  string fotoUrl { get; set; }
        public string  Aciklama { get; set; }

        public ICollection<yorumlar>Yorumlars { get; set; }
    }
}