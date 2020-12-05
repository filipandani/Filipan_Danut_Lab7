using Filipan_Danut_Lab2.Models;
using Filipan_Danut_Lab2.Views.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Filipan_Danut_Lab2.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Books.Any())
            {
                return; // BD a fost creata anterior
            }
            var books = new Books[]
            {
 new Books{Title="Baltagul",Author="Mihail Sadoveanu",Price=Decimal.Parse("22")},
 new Books{Title="Enigma Otiliei",Author="George Calinescu",Price=Decimal.Parse("18")},
 new Books{Title="Maytrei",Author="Mircea Eliade",Price=Decimal.Parse("27")},
 new Books{Title="Panza de paianjen",Author="Cella Serghi",Price=Decimal.Parse("45")},
 new Books{Title="Fata de hartie",Author="Guillame Musso",Price=Decimal.Parse("38")},
 new Books{Title="De veghe in lanul de secara",Author="J.D. Salinger",Price=Decimal.Parse("28")},
            };
            foreach (Books s in books)
            {
                context.Books.Add(s);
            }
            context.SaveChanges();
            var customers = new Customer[]
            {

 new Customer{CustomerID=1050,Name="Popescu Marcela",BirthDate=DateTime.Parse("1979-09-01")},
 new Customer{CustomerID=1045,Name="Mihailescu Cornel",BirthDate=DateTime.Parse("1969-07-08")},

 };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
            var orders = new Order[]
            {
 new Order{BookID=1,CustomerID=1050,OrderDate=DateTime.Parse("02-25-2020")},
 new Order{BookID=3,CustomerID=1045,OrderDate=DateTime.Parse("09-28-2020")},
 new Order{BookID=1,CustomerID=1045,OrderDate=DateTime.Parse("10-28-2020")},
 new Order{BookID=2,CustomerID=1050,OrderDate=DateTime.Parse("09-28-2020")},
 new Order{BookID=4,CustomerID=1050,OrderDate=DateTime.Parse("09-28-2020")},
 new Order{BookID=4,CustomerID=1050,OrderDate=DateTime.Parse("10-28-2020")},
            };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
            var publisher = new Publishers[]
            {
new Publishers{PublisherName="Humanitas", Adress="Str. Aviatorilor, nr. 40, Bucuresti"},
new Publishers{PublisherName="Nemira", Adress="Str. Plopilor, nr. 35, Ploiesti"},
new Publishers{PublisherName="Paralela 45", Adress="Str. Cascadelor, nr. 22, Cluj-Napoca"},
             };
            foreach (Publishers p in publisher)
            {
                context.Publishers.Add(p);
            }
            context.SaveChanges();
            var publishedbooks = new Views.Books.PublishedBooks[]
            {
 new Views.Books.PublishedBooks {BookID = books.Single(c => c.Title == "Maytrei" ).ID, PublisherID = publisher.Single(i => i.PublisherName == "Humanitas").ID},
 new Views.Books.PublishedBooks {BookID = books.Single(c => c.Title == "Enigma Otiliei" ).ID, PublisherID = publisher.Single(i => i.PublisherName == "Humanitas").ID},
 new Views.Books.PublishedBooks {BookID = books.Single(c => c.Title == "Baltagul" ).ID,PublisherID = publisher.Single(i => i.PublisherName =="Nemira").ID},
 new Views.Books.PublishedBooks {BookID = books.Single(c => c.Title == "Fata de hartie" ).ID, PublisherID = publisher.Single(i => i.PublisherName == "Paralela 45").ID},
 new Views.Books.PublishedBooks {BookID = books.Single(c => c.Title == "Panza de paianjen" ).ID, PublisherID = publisher.Single(i => i.PublisherName == "Paralela 45").ID},
 new Views.Books.PublishedBooks {BookID = books.Single(c => c.Title == "De veghe in lanul desecara" ).ID, PublisherID = publisher.Single(i => i.PublisherName == "Paralela45").ID},
            };
            foreach (Views.Books.PublishedBooks pb in publishedbooks)
            {
                //var entityEntry = context.PublishedBooks.Add(pb);
            }
            context.SaveChanges();
        }
    }
}
