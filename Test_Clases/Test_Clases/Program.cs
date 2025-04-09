// See https://aka.ms/new-console-template for more information

using Test_Clases;

Console.WriteLine("Hello, World!");

/*
 // manera de crear book1 con parametros
        Book book1 = new Book(); // aqui se crea un elemento "book1" de tipo Book
        book1.title = "Harry";   // Asi se asigna el title al book1
        book1.author = "JK";     // asignacion del nombre del autor
        book1.pages = 400;       // numero de paginas del libro

        Book book2 = new Book(); //Aqui se crea un book2 de tipo Book
        book2.title = "Rings";
        book2.author = "Tolkien";
        book2.pages = 700;
*/

// Manera mas eficiente de dar parametros a la clase
/*
Book book8 = new Book();

book8.title = "test";

        Book book3 = new Book("Harry Potter", "JK Rowling", 400);
        Book book4 = new Book("Lord of the Rings", "Tolkien", 700);

        book3.title = "Hobbit"; // de esta manera se puede cambiar la 
        //informacion dentro de la variable

        Console.WriteLine(book8.title); // Muestra en pantalla el titulo del libro 1
*/
/*
 // Recibir una entrada tecleada por el usuario y mostrarla en pantalla
        string entrada = Console.ReadLine();
        string entradaNumerica = Console.ReadLine();
        Console.WriteLine(entradaNumerica);
*/    

//crear clase estudiante y agregar una lista de varios estudiantes (max 5).
//imprimir el nombre de cada uno desde la lista

        Estudiante estudiante1 = new Estudiante(001, "Lissa", "Bueno", "8098098009", "Ingenieria Telematica");
        Estudiante estudiante2 = new Estudiante(002, "Pedro", "Perez", "8098098009", "Ingenieria Electronica");
        Estudiante estudiante3 = new Estudiante(003, "Marta", "Balbuena", "8098098009", "Ingenieria Civil");
        Estudiante estudiante4 = new Estudiante(004, "Jose", "Sanchez", "8098098009", "Ingenieria Electronica");
    
        
        List<Estudiante> listaEstudiante = new List<Estudiante> { };
        
        listaEstudiante.Add(estudiante1);
        listaEstudiante.Add(estudiante2);
        listaEstudiante.Add(estudiante3);
        listaEstudiante.Add(estudiante4);

       // Console.WriteLine(estudiante1.nombre);
 
        
        foreach (Estudiante estudiante in listaEstudiante) //no cuenta, usa el tipo de datos
        {
                Console.WriteLine(estudiante.nombre);
                // Console.WriteLine(estudiante);
        }

        for (int contador = 0; contador < listaEstudiante.Count; contador++) // el contador cuenta numeros
        {
                Console.WriteLine(listaEstudiante[contador].nombre);
                // Console.WriteLine(contador);
        }
        
        