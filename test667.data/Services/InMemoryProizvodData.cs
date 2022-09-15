using System;
using System.Collections.Generic;
using System.Linq;
using test667.data.Models;

namespace test667.data.Services
{
    public class InMemoryProizvodData : IProizvodData
    {
        List<Proizvod> proizvodi;

        public InMemoryProizvodData()
        {
            proizvodi = new List<Proizvod>()
            {
                new Proizvod { Id = 1, ime = "Kestrel", kratok_opis = "Lorem_Ipsum kratko", dolg_opis = "Dolgo Lorep ipsuuuuuuuuuum" , prospekt_link = "https://www.maganmak.com.mk" , upatstvo_link = "https://www.maganmak.com.mk" , slika = "https://maganmak.com.mk/wp-content/uploads/2020/03/kestrel-140x300.png" , kategorija = Kategorija.Zastita_Rastenija },
                new Proizvod { Id = 2, ime = "Aviator", kratok_opis = "Lorem_Ipsum kratko", dolg_opis = "Dolgo Lorep ipsuuuuuuuuuum", prospekt_link = "https://www.maganmak.com.mk", upatstvo_link = "https://www.maganmak.com.mk", slika = "https://maganmak.com.mk/wp-content/uploads/2020/03/aviator.png", kategorija = Kategorija.Zastita_Rastenija },
                new Proizvod { Id = 3, ime = "Yara Mila Komplex", kratok_opis = "Lorem_Ipsum kratko", dolg_opis = "Dolgo Lorep ipsuuuuuuuuuum", prospekt_link = "https://www.maganmak.com.mk", upatstvo_link = "https://www.maganmak.com.mk", slika = "https://image.shutterstock.com/image-vector/none-vector-hand-drawn-illustration-260nw-1504674191.jpg", kategorija = Kategorija.Ishrana_Rastenija },
            };
        }

        public void Add(Proizvod proizvod)
        {
            proizvodi.Add(proizvod);
            proizvod.Id = proizvodi.Max(p => p.Id) + 1;
        }

        public void Update (Proizvod proizvod)
        {
            var existing = Get(proizvod.Id);
            if (existing != null)
            {
                existing.ime = proizvod.ime;
                existing.kategorija = proizvod.kategorija;
                existing.kratok_opis = proizvod.kratok_opis;
                existing.dolg_opis = proizvod.dolg_opis;
                existing.slika = proizvod.slika;
                existing.prospekt_link = proizvod.prospekt_link;
                existing.upatstvo_link= proizvod.upatstvo_link;
            }
        }

        public Proizvod Get(int id)
        {
            return proizvodi.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Proizvod> GetAll()
        {
            return proizvodi.OrderBy(r => r.ime);
        }

        public void Delete(int id)
        {
            var proizvod = Get(id);
            if (proizvod != null)
            {
                proizvodi.Remove(proizvod);
            }
        }
    }
}
