// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


        Book book1 = new Book(); // aqui se crea un elemento "book1" de tipo Book
        book1.title = "Harry";   // Asi se asigna el title al book1
        book1.author = "JK";     // asignacion del nombre del autor
        book1.pages = 400;       // numero de paginas del libro

        Book book2 = new Book(); //Aqui se crea un book2 de tipo Book
        book2.title = "Rings";
        book2.author = "Tolkien";
        book2.pages = 700;


        Console.WriteLine(book1.title); // Muestra en pantalla el titulo del libro 1