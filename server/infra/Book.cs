using LinqToDB.Mapping;

namespace infra;

public class Book
{
    [PrimaryKey]public string BookId { get; set; }
    public string BookTitle { get; set; }
    public int NumberOfPages { get; set; }
    public String AuthorId { get; set; }
    [Association(ThisKey = nameof(AuthorId), OtherKey = nameof(Author.AuthorId))]
    public Author Author { get; set; }
}

public class Author
{
    [PrimaryKey] 
    public String AuthorId { get; set; }
    public String AuthorName { get; set; }
    [Association(ThisKey = nameof(AuthorId), OtherKey = nameof(Book.BookId))]
    public List<Book> BooksWrittenByAuthor { get; set; }
}
