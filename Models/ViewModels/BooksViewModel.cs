namespace Mission11_Section03_Morey.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
