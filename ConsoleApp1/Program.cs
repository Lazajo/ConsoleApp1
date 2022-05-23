using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona persona1 = new Persona();
            ////persona.Nombre = "Ruben";
            ////persona.Apellidos = "Lázaro López";
            //persona1.MostrarInfo();

            //Persona persona2 = new Persona("Ruben", "Lázaro López"); 
            //persona2.MostrarInfo();

            //Persona persona3 = new Persona("Ruben", "Lázaro López", new DateTime(1968, 11, 13));
            //persona3.MostrarInfo();

            //Alumno alumno = new Alumno();
            //alumno.Nombre = "Alumno 1";
            //alumno.Apellidos = "apellidos";
            //alumno.MostrarInfo();

            //Profesor profesor = new Profesor();
            //profesor.Nombre = "Profesor 1";
            //profesor.Apellidos = "apellidos";
            //profesor.MostrarInfo();



            //Profesor.ObtenerTexto();

            //Director.ObtenerTexto();

            //Funciones.ObtenerTexto();

            for (int i = 0; i < 10; i++)
            {
                Contadores contador = new Contadores();
                Console.WriteLine("Nuevo contador instanciadas = " + contador.Contador.ToString());
                Console.WriteLine("Nuevo contador estaico = " + Contadores.ContadorEstatico.ToString());
            }

            



            //Alumno alumno = new Alumno("Jose", "Perez", "Aula 1");
            //Console.WriteLine("Nombre: " + alumno.Nombre + alumno.Apellidos + " en el aula: " + alumno.Aula);


            //Profesor profesor = new Profesor();

            //Director director = new Director();
            ////por herencia tiene todo de las clases Profesor y Persona, más lo suyo
            //director.Despacho = "Despacho rojo";


            //persona.CambiarNombre("Pepe", "Perez");

            /*
            Animal animal = new Animal();
            animal.EstablecerEspecie("perro");
            Console.WriteLine("Especie:  " + animal.Especie);
            Console.WriteLine("Subespecie:  " + animal.SubeEspecie);
            */
        }
        class Animal
        {
            private string Nombre { get; set;  }
            public string Especie { get; set; }
            public string SubeEspecie { get; set; }

            public void MostrarDatos()
            {
                
            }
            public void EstablecerEspecie(string nuevaEspecie)
            {
                Especie = DefinirEspecie();
                SubeEspecie = DefinirEspecie();

                // función local: no lleva accesibilidad
                // a la cual sólo tiene acceso en el ambito definida
                string DefinirEspecie()
                {
                    if (nuevaEspecie == "perro")
                        return "Dog";
                    else if (nuevaEspecie == "gato")
                        return "Cat";
                    else
                        return "Desconocido";
                }
            }


        }

        //herencia de la clase Persona
        class Alumno : Persona
        {
            // hereda todas propiedades y metodos de la clase Persona

            //Y podría usar los constructores tambien:
            public Alumno()
                : base()
            {
            }
            public Alumno(string nombre, string apellidos, string aula)
                :base(nombre, apellidos)
            {
                Aula = aula;
            }

            public string[] ListaAsignaturas { get; set; }
            public string Aula { get; set; }
        
            public override void MostrarInfo()
            {
                Console.WriteLine("El nombre del alumno es:  " + Nombre + "  " + Apellidos + ";  Edad: " + Edad.ToString());
            }


        }
        
        //herencia de la clase Persona
        class Profesor : Persona
        {
            public string Asignatura { get; set; }
            public bool JefeEstudios { get; set; }
            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine("El nombre del profesor es:  " + Nombre + "  " + Apellidos + ";  Edad: " + Edad.ToString());
            }
            public static string ObtenerTexto()
            {
                return "Texto";
            }
        }

        class Director : Profesor
        {
            public string Despacho { get; set; }

            public static string ObtenerTexto()
            {
                return "Texto";
            }
        }

        static class Funciones
        {
            public static string ObtenerTexto()
            {
                return "Texto";
            }
        }
        class Contadores
        {
            public int Contador { get; set; }
            public static int ContadorEstatico { get; set; }
            public Contadores()
            {
                Contador++;
                ContadorEstatico++;
            }
        }
    }
}

