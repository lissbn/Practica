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



    List<Estudiante> listaEstudiantes = new List<Estudiante>();

    

    public Database()
    {
        Estudiante student1 = new Estudiante("40", "Juan", "Perez", "5559512368","Medicina");
        Estudiante student2 = new Estudiante("50", "Maria", "Rosa", "9998887777","Estomatologia");
        listaEstudiantes.Add(student1);
        listaEstudiantes.Add(student2);
    }
    

    public void AddStudent()
    {
        Estudiante element = new Estudiante();
        Console.WriteLine("Crear estudiante:");
        Console.WriteLine("Escriba el nombre que desea agregar: ");
        string newName = Console.ReadLine();
        element.nombre = newName;

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
        listaEstudiantes.Add(element);
    }

    public void DeleteStudent()
    {
        Console.WriteLine("Ingrese el Id del estudiante que desea eliminar: ");
        string idRecibido = Console.ReadLine();

        for(int i = 0; i < listaEstudiantes.Count; i++)
        {
            if (listaEstudiantes[i].id == idRecibido)
            {
                listaEstudiantes.Remove(listaEstudiantes[i]); 
            }

        }
    }

    public void ReadStudent()
    {
        foreach (Estudiante student in listaEstudiantes) 
        {
            
            Console.WriteLine( "id: "+ student.id);
            Console.WriteLine("Nombre: " + student.nombre);
            Console.WriteLine("Apellido:" + student.apellido);
            Console.WriteLine("Telefono:" + student.telefono);
            Console.WriteLine("Carrera:" + student.carrera);
            Console.WriteLine(".......................................................................");
        }
    }

    public void ChangeNameofStudent()
    {
        Console.WriteLine("Estudiantes de la lista:");
        foreach (Estudiante estudiante in listaEstudiantes) 
        {
                
            Console.WriteLine(estudiante.nombre);
        }

        Console.WriteLine("Escriba el nombre que desea cambiar: ");
        string nombreRecibido1 = Console.ReadLine();
 
        for (int contador = 0; contador < listaEstudiantes.Count; contador++)    
        {
           
            if (listaEstudiantes[contador].nombre == nombreRecibido1)
            {
               
                Console.WriteLine("Escriba el nuevo nombre: ");
                string nombreNuevo= Console.ReadLine();
                listaEstudiantes[contador].nombre = nombreNuevo; 
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