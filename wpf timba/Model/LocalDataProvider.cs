using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_timba.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<BookJanr> GetBookJanrs()
        {
            return new BookJanr[]
            {
                new BookJanr {Title = "Роман"},
                new BookJanr {Title = "Психология" }
            };
        }

        public IEnumerable<Book> GetBooks()
        {
            return new Book[]
            {
                new Book{NameAvtor = "А.С.Пушкин", Izdatelstvo = "А.С.Пушкин", NameBook = "Евгений Онегин", Year = 1881, Stranitsi = 279, Janr = "Роман" },
                new Book { NameAvtor = ".Шарлотта Бронте Каррер", Izdatelstvo = " Смит Элдер и Ко", NameBook = "Джейн Эйр", Year = 1846, Stranitsi = 536, Janr = "Роман"},
                new Book {NameAvtor = " Шарлотта Бронте Каррер", Izdatelstvo = "Смит Элдер и Ко", NameBook = "Шерли", Year = 1849, Stranitsi = 498, Janr = "Комедия"}
               
            };
        }
    }
}
