using The_Author_and_Book_Classes;
var Aut = new Author("Mehroj","Hakimov@gmail.com", 'm' );  
System.Console.WriteLine(Aut.ToString());

var bok = new Book("Alifbo", Aut , 3.22, 5 );
System.Console.WriteLine(bok.ToString());