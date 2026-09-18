using LinqToDB.Mapping;

namespace infra;

public class Author
{
    [PrimaryKey] 
    public String AuthorId { get; set; }
    public String AuthorName { get; set; }
    [Association(ThisKey = nameof(AuthorId), OtherKey = nameof(Book.BookId))]
    public List<Book> BooksWrittenByAuthor { get; set; }
}




public class AuthorDto
{
    public String AuthorId { get; set; }
    public String AuthorName { get; set; }
}