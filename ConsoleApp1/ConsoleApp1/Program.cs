// See https://aka.ms/new-console-template for more information+

//variables
int number = 4; //int para numeros enteros
long numberLong = 55; //long para numeros enteros mayores al limite de int 2,147,483,647
float floatNumber = 5.5f; // float para numeros decimales
double doubleNumber = 5.55f; // float para numeros decimales de mayor precision
string text = "hola"; //para texto o cadena de caracteres.
char character = 'a'; //para caracteres.
bool boolean = false; // para operaciones de verdadero y falso


//condicionales

if (boolean)
{
    Console.WriteLine("true!"); // si se cumple la condicion se imprime "true" en consola
}
else {
    Console.WriteLine("false!"); // si no se cumple la condicion se imprime "false" en consola
}

Console.WriteLine("Hello, World!"); // imprime Hello World en la consola


int i = 2; // variable int con numero entero

Console.WriteLine("Hello world! " + i); //print una frase y un int a la vez

    if (SecondTestFunction(i)){

        Console.WriteLine(" Test 2 con i Verdadero o menor que 100"); //probando la llamada a la funcion SecondTest con una condicional
    }else{

        Console.WriteLine(" Test 2 con i Falso o mayor que 100"); // en caso de que la condicional no se cumpla, se cumplira else
    }

    if((i < 10 && i == 5) || (i > 10 && i == 15)){ //uso de distintas condiciones a la vez

    Console.WriteLine("True"); // Si la condicion se cumple imprimir "True" 

    }

switch (i) // se toma el contenido de la variable i para saber qué caso es
{
    case 0:
        Console.WriteLine("i es 0"); // caso 0
        break;
    case 1:
        Console.WriteLine("i es 1"); // caso 1
        break;
    case 2:
        Console.WriteLine("i es 2"); // caso 2
        break;

    default:
        Console.WriteLine("no se cumplio ningun caso mencionado");
        break;
}


TestFunction(); // llamar la primera funcion
//bool b = SecondTestFunction(50); // llamar a la funcion y que su resultado se guarde en booleano b


void TestFunction() // el static significa que hay una sola funcion para cada instancia
{
    Console.WriteLine("Test 1!"); // comprobacion de que test funciona
}

bool SecondTestFunction(int i)
{
    Console.WriteLine("Test 2!"); // comprobacion de que SecondTest funciona
    return i < 100;               // retornara como valor si i es menor que 100 True
   
}


int[] intArray = new int[5] {1, 2, 3, 4, 5}; // arreglo de numeros

List<int> intlist = new List<int> {1, 2, 3, 6, 7}; // Lista es una coleccion que permite añadir y remover objetos dinamicamente
//intlist.Add(5);     // añadir el numero 5 al final
//intlist.Remove(2); // remover el 2

/* El primer elemento del arreglo y de la lista es 0,
 * al elegir un numero fuera del arreglo produce el error: System.ArgumentOutOfRangeException: 
 * 'Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')'

 * 
 */

Console.WriteLine("Primer elemento de la lista " + intlist[0]);
Console.WriteLine("ultimo elemento de la lista " + intlist[intlist.Count-1]);


foreach ( int elemento in intlist)
{

    Console.WriteLine(elemento); //inicia un contador p y por cada uno que haya en intlist este se imprime
}

for(int k = 0; k < intlist.Count; k++)
{
    Console.WriteLine(k + " " + intlist[k]); // agrega a la misma linea el indice k y el numero ubicado en el indice k por cada elemento en intlist
}

int u = 0; // inicia n nuevo contador u

while (u < 5) // bucle while, mientras u sea menor a 5 se sigue ejecutando la siguiente tarea
{
    u++; // aumenta el contador u por 1
}

u = 0; // reinicia el contador en 0

do
{
    u++;        // se ejecuta la tarea 1 vez y se confirma si se cumple la condicion, si no se ha cumplido se continua el bucle
}while(u < 5);


//Console.ReadKey(); // espera que el usuario presione alguna tecla

//List<int> intlist = new List<int> { 1, 2, 3, 6, 7 }; // Lista es una coleccion que permite añadir y remover objetos dinamicamente


List<int> numeros = new List<int> { };

// Contar los numeros de; 100 al 1
/*
for (int cont = 100; cont >= 1; cont--)
{
 //   numeros.Add(cont);
    Console.WriteLine(cont);
}
*/

/*
foreach (int o in numeros)
{
    Console.WriteLine(o); //inicia un contador p y por cada uno que haya en intlist este se imprime
}
*/
/*
// hacer funcion que tenga parametro int cantidad, y tener la sumatoria de los numeros del 1 al n


//Sumatoria(5);

string numeroRecibido = Console.ReadLine();
Console.WriteLine("se digito: " + numeroRecibido);
int convertidoaInt;
//= int.Parse(numeroRecibido);
int.TryParse(numeroRecibido, out convertidoaInt);
Console.WriteLine(Sumatoria(convertidoaInt));

int Sumatoria(int n)
{
    int suma = 0;

    for(int a=0; a <= n; a++)
    {
        suma = suma + a;
        //suma += a;
            
    }
    return suma;
}
*/
/*
// funcion calculadora , usar switch case
Calculadora(10, 2, "+");

int Calculadora(int primerNum, int segNum, string operacion)
{

    switch (operacion)
    {
        case "+":
            int suma = primerNum + segNum;
            Console.WriteLine(suma);
            return suma;
            break;
        case "-":        
            int resta = primerNum - segNum;
            Console.WriteLine(resta);
            return resta;
            break;
        case "*":
            int producto = primerNum * segNum;
            Console.WriteLine(producto);
            return producto;
            break;
        case "/":
            int division = primerNum / segNum;
            Console.WriteLine(division);
            return division;
            break;
        default:
            Console.WriteLine("No se escribio ningun caso programado.");
            return 0;
            break;

           
    }


}

*/
class MyClass // con este sea crea la clase MyClass que se vuelve una plantilla para los objetos que sean MyClass
{
    public float myfloat; // float en myClass
    int myInt;  // int en myClass

    public MyClass(float myfloat, int myInt) // crea un constructor  MyClass que se puede acceder a sus elementos en cualquier parte del codigo
    {
        this.myfloat = myfloat;
        this.myInt = myInt;
    }
}


//MyClass myClass = new MyClass(4.3f, 5);

//myClass.myfloat