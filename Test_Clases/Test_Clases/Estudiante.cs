namespace Test_Clases;

public class Estudiante
{
    // 
    public int id { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string telefono { get; set; }
    public string carrera { get; set; }


    public Estudiante(int aId, string aNombre, string aApellido, string aTelefono, string aCarrera)
    {
        id = aId;
        nombre = aNombre;
        apellido = aApellido;
        telefono = aTelefono;
        carrera = aCarrera; 
    }

    
}