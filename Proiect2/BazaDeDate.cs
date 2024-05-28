using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2
{
    
    internal class Utilizator
    {
        public int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    internal class Produs
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Maxim 30 caractere")]
        public string Denumire { get; set; }
        [MaxLength(200, ErrorMessage = "Maxim 200 caractere")]
        public string DescriereProdus { get; set; }
        public DateTime DataIntrare { get; set; }
        public DateTime DataValabilitate { get; set; }
        public int Cantitate { get; set; }
    }

    internal class IstoricVanzari
    {
        public int id { get; set; }
        public int id_user { get; set; }
        public string denumireProdus { get; set; }
        public int canitate { get; set; }
    }

    class MyDbContext : DbContext
    {
        public DbSet<Utilizator> Utilizatori { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<IstoricVanzari> Istoric { get; set; }
    }
}
