using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace BLL.Repositorio
{
    public class repoPersona
    {
        
          //si quiero que tenga usuarios ya cargados, los cargo en el contructor
        public repoPersona() 
        {
            personas.Add(new Persona() { id = 1, nombre = "Matias", apellido = "Canziani", edad = 31 });
            personas.Add(new Persona() { id = 2, nombre = "Amelie", apellido = "Canziani", edad = 18 });

        }
         

        //declaro la lista y con el new la dejo lsita para instanciar
        private List<Persona> personas = new List<Persona>();

        //Metodo para agregar personas y le digo que este listo para agregar una persona de TIPO Persona
        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        //Sobrecargo el metodo AgregarPersona
        public void agregarPersona(int id, string nombre, string apellido, int edad)
        {
            personas.Add(new Persona { id = id, nombre = nombre, apellido = apellido, edad = edad });
        }

        //creo el metodo que trae todas las personas
        public List<Persona> GetAll() 
        {
            return personas;
        }

        //Busqueda por ID
        public Persona GetByID (int id) 
        {
            return personas.Find(x => x.id == id);
        }

      //Eliminar Por ID
        public Persona DeleteFromID(int id)
        {
            Persona persona = personas.FirstOrDefault(x => x.id == id);
            personas.Remove(persona);

            return persona;
        }

        //Modificar Por ID
        /* public Persona ActualizarPersona(int id, string nombre, string apellido, int edad)
         {
             Persona persona = personas.FirstOrDefault(x => x.id == id);
             return persona;
         }*/
        public bool ActualizarPersona(int id, string nuevoNombre, string nuevoApellido, int nuevaEdad)
        {
            Persona persona = personas.FirstOrDefault(x => x.id == id);

            if (persona != null)
            {
                persona.nombre = nuevoNombre;
                persona.apellido = nuevoApellido;
                persona.edad = nuevaEdad;
                return true; // Indica que la actualización tuvo éxito
            }

            return false; // Indica que no se encontró una persona con el ID especificado
        }

       
    }
}
