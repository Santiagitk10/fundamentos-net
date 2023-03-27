//Comandos para crear una aplicación:

//dotnet new //Muestra la lista de los principales templates para crear las diferentes aplicaciones en .Net
//dotnet new --list //Para mostrar una lista completa de todos los templates disponibles
//dotnet new console //En este caso se escoge la creación de un app de consola
//dotnet run //para ejecutar el programa
//dotnet build //para construir el programa y ver que esté todo correcto
//dotnet restore //para restaurar todas las dependencias que tiene el proyecto
//dotnet watch run //cuando se hace un cambio en el proyecto vuelve a compilarse el proyecto y ejecutarse

using Humanizer;

Console.WriteLine("Por favor ingrese un nombre");
var nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cargo");
var cargo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola, Mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años");
