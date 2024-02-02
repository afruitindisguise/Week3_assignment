///<summary>instantiates 2 Books and the Books list, also runs the Service Method<\summary>
///<author>Nathan Straus<\author>
using WEEk3_Assignment.models;
Book book1 = new Book("Moby-Dick", "Herman Melville", "Adventure fiction", "0001");
Book book2 = new Book("Odyssey", "Homer", "Epic", "0002");
BookManagerService Books = new BookManagerService {
    Books = [book1,book2],
};
Books.Service();
