namespace Test_Clases;

public class Database
{
// CRUD Create, Read, Update, Delete
// hacer una clase llamada Database, campo lista de estudiantes con 2 estudiantes
// en la lista, 
// una funcion para crear estudiantes
// funcion para listar estudiantes
// funcion para cambiar nombre al estudiante por uno diferente
// borrar un estudiante dado un ID
// las funciones son clases. Cuando una funcion esta dentro de una clase se llama
// metodo
// Inicializar listas en el constructor



    List<Estudiante> listaEstudiantes = new List<Estudiante>(); // se inicializa una lista de Estudiantes
                                                                // para poder manejarla desde Database

    

    public Database()
    {
        Estudiante student1 = new Estudiante("40", "Juan", "Perez", "5559512368","Medicina");
        Estudiante student2 = new Estudiante("50", "Maria", "Rosa", "9998887777","Estomatologia");
        listaEstudiantes.Add(student1);
        listaEstudiantes.Add(student2);
    } // Aqui se agregan 2 estudiantes por parametros a la lista de estudiantes
    

    public void AddStudent() // funcion para añadir un nuevo estudiante
    {
        Estudiante element = new Estudiante(); // Se crea una variable de tipo Estudiante llamada elemet
        Console.WriteLine("Crear estudiante:"); // Le indica al usuario la funcion a realizar
        Console.WriteLine("Escriba el nombre que desea agregar: ");
        string newName = Console.ReadLine(); // Toma la entrada del usuario
        element.nombre = newName; // guarda la informacion dada por el usuario en la variable element

        Console.WriteLine("Escriba el apellido que desea agregar: ");
        string newLastName = Console.ReadLine();
        element.apellido = newLastName;

        Console.WriteLine("Escriba el telefono que desea agregar: ");
        string newPhone = Console.ReadLine();
        element.telefono = newPhone;

        Console.WriteLine("Escriba la carrera del estudiante que desea agregar: ");
        string newCareer = Console.ReadLine();
        element.carrera = newCareer;

        Console.WriteLine("Escriba el id que desea agregar: ");
        string newId = Console.ReadLine();
        element.id = newId;
        listaEstudiantes.Add(element); // Al tener todos los datos se agrega element a la lista de estudiantes
    }

    public void DeleteStudent() // funcion para borrar un estudiante
    {
        Console.WriteLine("Ingrese el Id del estudiante que desea eliminar: ");
        string idRecibido = Console.ReadLine(); // aqui se guarda el Id escrito por el usuario

        for(int contador = 0; contador < listaEstudiantes.Count; contador++) // bucle for y .Count para
                                                                             // contar la cantidad de elementos en la lista
        {
            if (listaEstudiantes[contador].id == idRecibido) // cuando se encuentre  un id igual al dado por el usuario se
                                                             // se cumplira esta condicion y se realizara la funcion de este
            
            {
                listaEstudiantes.Remove(listaEstudiantes[contador]);  // se usa .Remove para eliminar el estudiante en el indice encontrado
            }
        }
    }

    public void ReadStudent() // Funcion para leer todos los estudiantes
    {
        foreach (Estudiante student in listaEstudiantes)  // bucle para contar dentro de la lista
        {
            
            Console.WriteLine( "id: "+ student.id); // muestra la informacion del estudiante en que se encuentra el indice contador
            Console.WriteLine("Nombre: " + student.nombre);
            Console.WriteLine("Apellido:" + student.apellido);
            Console.WriteLine("Telefono:" + student.telefono);
            Console.WriteLine("Carrera:" + student.carrera);
            Console.WriteLine(".......................................................................");
        }
    }

    public void ChangeNameofStudent() // funcion para cambiar el nombre de un estudiante
    {
        Console.WriteLine("Estudiantes de la lista:");
        foreach (Estudiante estudiante in listaEstudiantes)  // primero muestra los nombres de los estudiantes actualmente
        {
                
            Console.WriteLine(estudiante.nombre);
        }

        Console.WriteLine("Escriba el nombre que desea cambiar: ");
        string nombreRecibido1 = Console.ReadLine();
 
        for (int contador = 0; contador < listaEstudiantes.Count; contador++)    //busca un estudiante con el mismo nombre en la lista
        {
           
            if (listaEstudiantes[contador].nombre == nombreRecibido1) 
            {
               
                Console.WriteLine("Escriba el nuevo nombre: "); 
                string nombreNuevo= Console.ReadLine(); // recibe el nuevo nombre que tendra el estudiante
                listaEstudiantes[contador].nombre = nombreNuevo; // ingresa el nuevo nombre en donde se encontraba el anterior
            }
        }

        Console.WriteLine("Estudiantes de la lista");
        foreach (Estudiante estudiante in listaEstudiantes) 
        {
                
            Console.WriteLine(estudiante.nombre);
        }
    }
}
//