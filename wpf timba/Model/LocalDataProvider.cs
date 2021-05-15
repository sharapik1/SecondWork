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
                new Book{NameAvtor = "Рей Дуглас Бредбери", Izdatelstvo = "Баллантай книги", NameBook = "451 градус по Фаренгейту", Year = 1953, Stranitsi = 400, Janr = "Драма" },
                new Book { NameAvtor = "Джордж Рейн Толкин", Izdatelstvo = " George Allen", NameBook = "Властелин колец", Year = 1954, Stranitsi = 300, Janr = "Драма"},
                new Book {NameAvtor = "Джейн Остин Джеймс", Izdatelstvo = "Thomas Egerton", NameBook = "Гордость и предубеждение", Year = 1813, Stranitsi = 255, Janr = "Психология"}
               
            };
        }
    }
}
