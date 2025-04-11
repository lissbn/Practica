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


 // Recibir una entrada tecleada por el usuario y mostrarla en pantalla
        string entrada = Console.ReadLine();
        string entradaNumerica = Console.ReadLine();
        Console.WriteLine(entradaNumerica);
    
*/
//crear clase estudiante y agregar una lista de varios estudiantes (max 5).
//imprimir el nombre de cada uno desde la lista
/*
       Estudiante estudiante1 = new Estudiante("001", "Lissa", "Bueno", "8098098009", "Ingenieria Telematica");
       Estudiante estudiante2 = new Estudiante("002", "Pedro", "Perez", "8098098009", "Ingenieria Electronica");
       Estudiante estudiante3 = new Estudiante("003", "Marta", "Balbuena", "8098098009", "Ingenieria Civil");
       Estudiante estudiante4 = new Estudiante("004", "Jose", "Sanchez", "8098098009", "Ingenieria Electronica");
       Estudiante estudianteNuevo = new Estudiante();

       List<Estudiante> listaEstudiante = new List<Estudiante> { };

       listaEstudiante.Add(estudiante1);
       listaEstudiante.Add(estudiante2);
       listaEstudiante.Add(estudiante3);
       listaEstudiante.Add(estudiante4);


       // Console.WriteLine(estudiante1.nombre);


       foreach (Estudiante estudiante in listaEstudiante) //no cuenta, usa el tipo de datos
       {
         //li      Console.WriteLine(estudiante.nombre);
               // Console.WriteLine(estudiante);
       }

       for (int contador = 0; contador < listaEstudiante.Count; contador++) // el contador cuenta numeros
       {
               Console.WriteLine(listaEstudiante[contador].nombre);
               // Console.WriteLine(contador);
       }

       Console.WriteLine("Escriba su nombre: ");
       string nombre = Console.ReadLine();
       Console.WriteLine("Nombre ingresado: " + nombre);



       foreach (Estudiante estudiante in listaEstudiante) //no cuenta, usa el tipo de datos
       {
               if (estudiante.nombre == nombre)
               {
                       Console.WriteLine(estudiante.id);
                       Console.WriteLine(estudiante.nombre);
                       Console.WriteLine(estudiante.apellido);
                       Console.WriteLine(estudiante.telefono);
                       Console.WriteLine(estudiante.carrera);
               }

       }





// En base al nombre, elimine el estudiante, e imprimir la nueva lista


       Console.WriteLine("Escriba el nombre: ");
       string nombreTest = Console.ReadLine();

       for (int contador = 0; contador < listaEstudiante.Count; contador++)
       {

               if (listaEstudiante[contador].nombre == nombreTest)
               {

                       listaEstudiante.Remove(listaEstudiante[contador]); // no se puede eliminar elementos de una lista en un foreach
                                                                          //  en la que accedes a foreach, porque esa lista se esta usando para iterar
                       //     Console.WriteLine(estudiante.nombre);
               }
       }

       Console.WriteLine("Estudiantes de la lista");
       foreach (Estudiante estudiante in listaEstudiante) //no cuenta, usa el tipo de datos
       {

               Console.WriteLine(estudiante.nombre);
               // Console.WriteLine(estudiante);
       }


// Cambiar el nombre al estudiante

       Console.WriteLine("Estudiantes de la lista:");
       foreach (Estudiante estudiante in listaEstudiante) //no cuenta, usa el tipo de datos
       {

               Console.WriteLine(estudiante.nombre);
       }

       Console.WriteLine("Escriba el nombre que desea cambiar: ");
       string nombreRecibido1 = Console.ReadLine();

       for (int contador2 = 0; contador2 < listaEstudiante.Count; contador2++)
       {

               if (listaEstudiante[contador2].nombre == nombreRecibido1)
               {
                       Console.WriteLine("Escriba el nuevo nombre: ");
                       string nombreNuevo= Console.ReadLine();
                     //  list[someIndex].SomeProperty = someValue;
                       listaEstudiante[contador2].nombre = nombreNuevo;
               }
       }

       Console.WriteLine("Estudiantes de la lista");
       foreach (Estudiante estudiante in listaEstudiante)
       {

               Console.WriteLine(estudiante.nombre);
       }


//Crear nuevo estudiante con todos los parametros

       Console.WriteLine("Escriba el nombre que desea agregar: ");
       string nombreRecibido2 = Console.ReadLine();
       estudianteNuevo.nombre = nombreRecibido2;

       Console.WriteLine("Escriba el apellido que desea agregar: ");
       string apellidoRecibido = Console.ReadLine();
       estudianteNuevo.apellido = apellidoRecibido;

       Console.WriteLine("Escriba el telefono que desea agregar: ");
       string telefonoRecibido = Console.ReadLine();
       estudianteNuevo.telefono = telefonoRecibido;

       Console.WriteLine("Escriba la carrera del estudiante que desea agregar: ");
       string carreraRecbida = Console.ReadLine();
       estudianteNuevo.carrera = carreraRecbida;

       Console.WriteLine("Escriba el id que desea agregar: ");
       string idRecibido = Console.ReadLine();
       estudianteNuevo.id = idRecibido;

       listaEstudiante.Add(estudianteNuevo);

       Console.WriteLine("Estudiantes de la lista");
       foreach (Estudiante estudiante in listaEstudiante)
       {
               Console.WriteLine(estudiante.id);
               Console.WriteLine(estudiante.nombre);
               Console.WriteLine(estudiante.apellido);
               Console.WriteLine(estudiante.telefono);
               Console.WriteLine(estudiante.carrera);
               Console.WriteLine("........................................");

       }
*/
// crud create, read, update, delete

        Database database = new Database();
        
        bool showFullData = false;

        database.ReadStudentalt(true);  
        database.AddStudent();
        Console.WriteLine("Desea mostrar solo los nombres de los estudiante? (n) Desea mostrar todos los datos de los estudiantes? (s): ");
        string respuesta1 = Console.ReadLine();
        if (respuesta1 == "s")
        {
          //      showFullData = true;
                database.ReadStudentalt(true);  
        }
        else
        {
            //    showFullData = false;
                database.ReadStudentalt(false);  
        }
        
        database.DeleteStudent();
        Console.WriteLine(
                "Desea mostrar solo los nombres de los estudiante? (n) Desea mostrar todos los datos de los estudiantes? (s): ");
        string respuesta2 = Console.ReadLine();
        if (respuesta2 == "s")
        {
                showFullData = true;
        }
        else
        {
                showFullData = false;
        }
        database.ReadStudentalt(showFullData);  
        database.ChangeNameofStudent();
        Console.WriteLine(
                "Desea mostrar solo los nombres de los estudiante? (n) Desea mostrar todos los datos de los estudiantes? (s): ");
        string respuesta3 = Console.ReadLine();
        if (respuesta3 == "s")
        {
                showFullData = true;
        }
        else
        {
                showFullData = false;
        }
        database.ReadStudentalt(showFullData);     
