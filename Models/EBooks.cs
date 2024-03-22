using System.Runtime.CompilerServices;

namespace Mission11_Section03_Morey.Models
{
    public class EBooks : IBooks
    {
        private BookstoreContext _context;
        public EBooks(BookstoreContext temp) 
        { 
             _context = temp;
        }
        public new IQueryable<Book> Books => _context.Books;
    }
}
