namespace Kolekcja.Migrations
{
    using Kolekcja.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Kolekcja.Models.ElementyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Kolekcja.Models.ElementyDBContext context)
        {
            context.Elementy.AddOrUpdate (i => i.Tytul,

                new Element
                {
                    Tytul = "Jedz i biegaj",
                    Autor= "Scott Jurek",
                    RokWydania = DateTime.Parse("2005-01-01"),
                    Gatunek = "Poradnik",
                    Rodzaj = "Ksi¹¿ka"
                },

                new Element
                {
                    Tytul = "Oppenheimer",
                    Autor = "Kai Bird",
                    RokWydania = DateTime.Parse("2000-01-01"),
                    Gatunek = "Biografia",
                    Rodzaj = "Ksi¹¿ka"
                },

                new Element
                {
                    Tytul = "TDD",
                    Autor = "Kent Beck",
                    RokWydania = DateTime.Parse("2009-01-01"),
                    Gatunek = "Poradnik",
                    Rodzaj = "Ksi¹¿ka"
                },

                new Element
                {
                    Tytul = "Frida Kahlo",
                    Autor = "Frank Miller",
                    RokWydania = DateTime.Parse("1997-01-01"),
                    Gatunek = "Album",
                    Rodzaj = "Ksi¹¿ka"
                }


             );
        }
    }
}
