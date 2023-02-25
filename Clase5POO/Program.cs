using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5POO
{
    internal class Program
    {
        interface ICajero1
        {
            void tarjetas();
            void Bonos();
            int calculo();
        }

        interface ICajero2
        {
            void Creditos();
            void Hipotecas();
        }
        class Caja
        {
            public Caja() { }
            public void AbrirCaja() { }
            public void CierreCaja() { }

        }

        class Cajero1 : Caja, ICajero1
        { 
            public Cajero1() { }

            public void tarjetas() { }
            public void Bonos() { }

            public int calculo() { return 0; }
            public void servicios_publicos() { }
        }

        class Cajero2 : Caja, ICajero2
        {
            public Cajero2() { }
            public void Creditos() { }
            public void Hipotecas() { } 
        }

        enum Categoria
        {
           amarillo, 
           rojo,
           verde
        }

        class Persona
        {
            public string cedula { get; set; }
            public string nombre { get; set; }

            public Persona(string ced, string nomb) {
                cedula = ced;
                nombre = nomb;
            }
        }

        static void Main(string[] args)
        {
            HashSet<string> Tablahash = new HashSet<string>();
            Tablahash.Add("valor");

            foreach (var item in Tablahash)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, Persona> Dicpersona = new Dictionary<int, Persona>();
           ;
            Dicpersona.Add(1, new Persona("4","Margarita"));

            foreach (var persona in Dicpersona)
            {
                Console.WriteLine($"Llave {persona.Key} Cedula: {persona.Value.cedula} Nombre: {persona.Value.nombre}");
            }
            string nombre = "alex";


            Console.WriteLine($"yo me llamo {nombre}" );


            Console.WriteLine("*********************************");
            
          Dictionary<string, string> paises = new Dictionary<string, string>();
            paises.Add("USA", "Estados unidos");
            paises.Add("CR", "Costa Rica");
            paises.Add("CO", "Colombia");

            foreach (var pais in paises)
            {
                Console.WriteLine($"Llave: {pais.Key} Nombre: {pais.Value}");
            }

            Dictionary<int, String> Estudiantes = new Dictionary<int, String>()
            {

                { 1, "Juan"},
                { 2, "MAria"},
                {3,"Tito" }
            };

            string resultado = "";

            //foreach (KeyValuePair<int,string> alumnos in Estudiantes)
            //{
            //    Console.WriteLine($"Llave : {alumnos.Key} Nombre: {alumnos.Value}");
            //}

            if (Estudiantes.TryGetValue(4, out resultado))
            {
                Console.WriteLine(resultado);
            }

            Console.Read();

        }
    }
}
