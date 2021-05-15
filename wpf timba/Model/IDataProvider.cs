using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_timba.Model
{
    interface IDataProvider
    {
        IEnumerable<Book> GetBooks();
    }
}
