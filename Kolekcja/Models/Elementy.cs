using System;
using System.Data.Entity;

namespace Kolekcja.Models
{
    public class Element
    {
        public int ID { get; set; }
        public string Tytul { get; set; }
        public DateTime RokWydania { get; set; }
        public string Gatunek { get; set; }
        public string Rodzaj { get; set; }
    }

    public class ElementyDBContext : DbContext
    {
        public DbSet<Element> Elementy { get; set; }
    }
}