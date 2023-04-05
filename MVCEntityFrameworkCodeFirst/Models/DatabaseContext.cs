using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkCodeFirst.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Kisiler> Kisiler { get; set;}
        public DbSet<Adresler> Adresler { get; set;}

        public DatabaseContext()
        {
            Database.SetInitializer(new VeritabaniOlusturucu());
        }
    }

    public class VeritabaniOlusturucu:CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 1; i < 11; i++)
            {
                Kisiler kisi = new Kisiler();
                kisi.Ad = FakeData.NameData.GetFirstName();
                kisi.Soyad = FakeData.NameData.GetSurname();
                kisi.Yas = FakeData.NumberData.GetNumber(18, 65);
                context.Kisiler.Add(kisi);  
            }
            context.SaveChanges();

            List<Kisiler> kisilistesi = context.Kisiler.ToList();

            foreach (Kisiler item in kisilistesi)
            {
                for (int i = 0; i < 3; i++)
                {
                    Adresler adres = new Adresler();
                    adres.AdresTanim = FakeData.PlaceData.GetAddress();
                    adres.Kisi = item;
                    context.Adresler.Add(adres);
                }                
            }
            context.SaveChanges();

        }
    }

}