namespace Polimorophism_Abstraction.Models;

public class Library
{
    private Book[] _books;
    public string[] Names;
    public Library(int size)
    {
        _books = new Book[size];
    }
    public Book this[int index]
    {
        get { 
        if (index< _books.Length&& index>=0)
            {
             return _books[index];
            }
            return null;
        }
        set {
            if (index < _books.Length && index >= 0)
            {
                _books[index] = value;
            }
        }
    }
   
}
