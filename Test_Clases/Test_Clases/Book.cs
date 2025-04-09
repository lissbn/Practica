// See https://aka.ms/new-console-template for more information
class Book // internal class ... solamente pueden acceder a la clase los archivos de la carpeta
// private trabaja solo dentro de la clase
// public funciona para acceder desde cualquier archivo donde hay una instancia de la clase
// static para acceder a las variables sin instancear  inicializar la clase
{
    public string title; // creacion del elemento público de la clase title
    public string author; // creacion del elemento público de la clase author
    public int pages; // creacion del elemento público de la clase pages

    public Book() // Este es un constructor. Puede recibir parametros
    {
    }// inicializar constructor sin parametros.
        
    public Book(string aTitle, string aAuthor, int aPages) // Este es un constructor. Puede recibir parametros
    {
        title = aTitle; // asignando los parametros a las variables
        author = aAuthor;
        pages = aPages;
       // Console.WriteLine(name);
    }
    
}