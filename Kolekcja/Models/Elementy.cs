using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Kolekcja.Models
{
    public class Element
    {
        public int ID { get; set; }
        [Display(Name="Tytuł książki: ")]
        public string Tytul { get; set; }
        [Display(Name="Rok wydania: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy}",ApplyFormatInEditMode=true)]
        public DateTime RokWydania { get; set; }
        public string Gatunek { get; set; }
        public string Rodzaj { get; set; }
    }

    public class ElementyDBContext : DbContext
    {
        public DbSet<Element> Elementy { get; set; }
    }
}