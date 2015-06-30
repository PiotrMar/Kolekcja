using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Kolekcja.Models
{
    public class Element
    {
        public int ID { get; set; }
        [Display(Name="Tytuł książki: ")]
        [StringLength(60, MinimumLength=3)]
        public string Tytul { get; set; }
        [Display(Name="Autor/Artysta/Reżyser: ")]
        public string Autor { get; set; }
        [Display(Name="Rok wydania: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy}",ApplyFormatInEditMode=true)]
        public DateTime RokWydania { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(45)]
        [Display(Name="Gatunek: ")]
        public string Gatunek { get; set; }
        [Display(Name="Rodzaj: ")]
        public string Rodzaj { get; set; }
    }

    public class ElementyDBContext : DbContext
    {
        public DbSet<Element> Elementy { get; set; }
    }
}