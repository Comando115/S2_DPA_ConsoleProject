using S2_DPA_ConsoleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_DPA_ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nombreCurso = "Desarrollo Web";
            int edad = 20;
            double monto = 350.50;

            var nuevaEdad = 30;
            var nuevoMonto = 340.7;

            Console.WriteLine("El nombre del curso:  " + nombreCurso);

            var persona1 = new Persona();
            persona1.dni = "42474030";
            persona1.nombreCompleto = "Jose Luis Meza";
            persona1.telefono = 936846089;

            var persona2 = new Persona()
            {

                dni = "42454849",
                nombreCompleto = "Rocio Milla Obregon",
                telefono = 985698412
            };

            var persona3 = new Persona() { 
            
                dni = "47586956",
                nombreCompleto = "Betsy Perez Arriola",
                telefono = 987589632

            };

            var persona4 = new Persona("45781274","Carlos Villavicencio Quispe",986478589);

            var listadoPersona = new List<Persona>();
            listadoPersona.Add(persona1);
            listadoPersona.Add(persona2);
            listadoPersona.Add(persona3);
            listadoPersona.Add(persona4);

            foreach (var item in listadoPersona)
            {
                Console.WriteLine(item.nombreCompleto + " " +item.dni);
            }

            var busqueda = listadoPersona.Where(x => x.dni == "42474030").FirstOrDefault();

            Console.WriteLine("Se encontro a : "+ busqueda.nombreCompleto);
        }
    }
}
