using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace WEEk3_Assignment.models;
/// <summary>
/// model that manages Books
/// </summary>
 public class BookManagerService{
   public List<Book> Books { get; set; } = [];
   private string PromptCheck(string prompt){
      string? result = "";
      do
      {
         Console.WriteLine($"Please enter {prompt}:");
         result = Console.ReadLine();
      } while (result == "" || result.GetType() == null);
      return result;
   }
   /// <summary>
   /// adds a book to the Books list 
   /// </summary>
   public void AddBook() {
      string? name = "";
      string? author = "";
      string? genre = "";
      string? Id = "";
      name = PromptCheck("Book's name");
      author = PromptCheck("Book's author");
      genre = PromptCheck("Book's genre");
      Id = PromptCheck("Book's Id");
      Book book = new Book(name, author, genre, Id);
      Books.Add(book);
   }
   /// <summary>
   /// Removes book from the Books list
   /// </summary>
   public void RemoveBook(){
      Console.WriteLine("Enter Book's Id");
      string? id = Console.ReadLine();
      int i = 0;
      bool deleted = false;
      foreach(Book book in Books){
         if(id == book.Id){
            Books.Remove(Books[i]);
            deleted = true;
            break;
         }else{
            i++;
         }
      }
      if(deleted == false){
         Console.WriteLine("ERROR: BOOK NOT FOUND");
      }
   }
   /// <summary>
   /// Loops through and "prints" each book in the Books list
   /// </summary>
   public void BookList(){
      foreach(Book book in Books){
         Console.WriteLine($"Name:{book.Name}; Author:{book.Author}; Genre:{book.Genre}; ID:{book.Id}");
      }
   }
   /// <summary>
   /// finds a Book from the list using its ID
   /// </summary>
   /// <returns>Book attached to Id</returns>
   public string FindBook(){
      Console.WriteLine("Enter Book's Id");
      string? id = Console.ReadLine();
      string result = "";
      foreach(Book book in Books){
         if(id == book.Id){
            result = $"Id{book.Id} =[{book.Name}:{book.Author}:{book.Genre}]";
            break;
         }else{
            result = "ERROR: BOOK NOT FOUND";
         }
      }
      return result;
   }
   /// <summary>
   /// Loops through methods until told to stop
   /// </summary>
   public void Service(){
      string? input = "";
      do{
         Console.WriteLine("What would you like to do:\n:AddBook?\n:RemoveBook?\n:BookList?\n:FindBook?\n:or Exit?");
         input = Console.ReadLine();
         if (input == "AddBook"){
            AddBook();
            continue;
         }
         else if (input == "RemoveBook")
         {
            RemoveBook();
            continue;
         }
         else if (input == "BookList")
         {
            BookList();
            continue;
         }
         else if (input == "FindBook"){
            Console.WriteLine(FindBook());
            continue;
         }else if (input != "Exit"){
            Console.WriteLine("thats not an option\n!please input the exact option name!");
         }
      } while (input != "Exit");
   }
 }