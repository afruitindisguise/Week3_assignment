namespace WEEk3_Assignment.models;
/// <summary>
/// model that manages Books
/// </summary>
 public class BookManagerService{
   public List<Book> Books { get; set; } = [];  
   /// <summary>
   /// adds a book to the Books list 
   /// </summary>
   public void AddBook(){
   }
   /// <summary>
   /// Removes book from the Books list
   /// </summary>
   public void RemoveBook(){

   }
   /// <summary>
   /// Shows Completet list of Books
   /// </summary>
   /// <returns>full list of books</returns>
   public string BookList(){
      return "";
   }
   /// <summary>
   /// finds a Book from the list bast
   /// </summary>
   /// <param name="id"></param>
   /// <returns>Book attached to Id</returns>
   public string FindBook(string id){
      return "";
   }
 }