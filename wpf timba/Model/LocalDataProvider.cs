using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_timba.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Book> GetBooks()
        {
            return new Book[]
            {
                new Book{NameAvtor = "Николай Семенович Лесков", Izdatelstvo = "Николай Семенович Лесков", NameBook = "Левша", Year = 1881, Stranitsi = 279, Janr = "Художественный вымысел" },
                new Book { NameAvtor = ".Шарлотта Бронте Каррер", Izdatelstvo = " Смит Элдер и Ко", NameBook = "Джейн Эйр", Year = 1846, Stranitsi = 536, Janr = "Драма"},
                new Book {NameAvtor = " Шарлотта Бронте Каррер", Izdatelstvo = "Смит Элдер и Ко", NameBook = "Шерли", Year = 1849, Stranitsi = 498, Janr = "Психология"}
               
            };
        }
    }
}
