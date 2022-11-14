namespace The_Author_and_Book_Classes;
public class Book 
{
  private string _namebook;
  private Author _author;
  private double _price;
  private int _qty;
  public Book(string namebook,Author author, double price, int qty) 
  {
    _namebook = namebook;
    _author = author;
    _price = price;
    _qty = qty;
  }
  public string GetName()
  {
    return _namebook;
  }
  public Author GetAuthor()
  {
    return _author;
  }
  public double GetPrice()
  {
    return _price;
  }
  public void SetPrice(double price)
  {
    _price = price ;
  }
public int GetQty()
{
    return _qty;
}
public void SetQty(int qty )
{
    _qty = qty;
}
 public string ToString()
    {
        return $"{_namebook} by {_author.ToString()}";
    }

}