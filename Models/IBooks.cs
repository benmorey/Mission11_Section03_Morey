namespace Mission11_Section03_Morey.Models
{
    public interface IBooks
    {
        public IQueryable<Book> Books {  get; }
    }
}
