namespace WEEk3_Assignment.models;
/// <summary>
/// a model of a book
/// </summary>
public class Book{
  public string? Name { get; set; }
  public string? Author { get; set; }
  public string? Genre { get; set; }
  public string? Id { get; set; }

  public Book(string name, string author, string genre, string id){
    Name = name;
    Author = author;
    Genre = genre;
    Id = id;
  }
}