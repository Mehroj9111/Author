namespace The_Author_and_Book_Classes;
public class Author
{
    private string _name;
    private string _email;
    private char _genter;

    public Author(string name, string email, char genter)
    {
       _name = name;
       _email = email;
       _genter = genter;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail()
    {
        System.Console.WriteLine($"{_email}");
    }
    public char GetGender()
    {
        return _genter;
    }
    public string ToString()
    {
        return $"{_name} {(_genter)} at {_email}";
    }

}