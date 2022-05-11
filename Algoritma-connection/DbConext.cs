using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_connection
{
    public class Book : IComparable<Book>
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Book? other)
        {
            Book deger = other as Book;
            int sonuc = 0;
            if (deger != null)
            {
                sonuc = Price.CompareTo(deger.Price);
            }
            return sonuc;
        }

        /*
        public int CompareTo(object? obj)
        {
            Book deger=obj as Book;
            int sonuc = 0;
            if (deger != null)
            {
                sonuc = Price.CompareTo(deger.Price);
            }
            return sonuc;
        } */
    }
    public class DbConext :DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DELL\SQLEXPRESS;Initial Catalog=nTierDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
