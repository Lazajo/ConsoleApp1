using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Persona
    {

    public virtual void MostrarInfo()
    {
        Console.WriteLine("Nuevos datos de la persona:  " + Nombre + "  " + Apellidos + ";  Edad: " + Edad.ToString());
    }
    public void CambiarNombre(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        this.MostrarInfo();
    }
}
}
