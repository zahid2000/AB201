namespace WebAPIAB201.Entities.Dtos.Books;

public class UpdateBookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
}
