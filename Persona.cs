using System;


namespace ConsoleApp1
{ 

    public class Persona
{
    //private string nombre;
    //private string apellidos;

    private DateTime fechaNacimiento;


    //constructor: metodo publico sin valor de retorno y con el mismo nombre que la clase
    // se utiliza para iniciar todo necesario de la clase
    public Persona()
    {
        Nombre = "Sin nombre";
        Apellidos = "Sin apellidos";
        fechaNacimiento = new DateTime(1900, 1, 1);
    }
    // segundo constructor
    public Persona(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }
    // tercer constructor
    public Persona(string nombre, string apellidos, DateTime fechanacimiento)
        : this(nombre, apellidos)
    // este constructor llama al anterior para no repetir código
    {
        //Nombre = nombre;
        //Apellidos = apellidos;
        this.fechaNacimiento = fechanacimiento;
    }
    public string Nombre { get; set; }

    public string Apellidos { get; set; }

    public string Direccion { get; set; }


    public int Edad
    {
        get
        {
            return (int)(DateTime.Today.Subtract(fechaNacimiento).Days / 365.25);
        }
    }


    public virtual void MostrarInfo()
    {
        Console.WriteLine("Datos de la persona:  " + Nombre + "  " + Apellidos + ";  Edad: " + Edad.ToString());
    }
    public void CambiarNombre(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        this.MostrarInfo();
    }
}

}