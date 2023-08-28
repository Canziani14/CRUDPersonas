using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        #region delegado edad
//defino el delegado para el evento y le digo que no va a devolver nada , pero que va a recibir la edad para verificar que sea mayor de 18
        public delegate void PersonaEsMenorDelegate(int edad);
//declaro el evento
        public event PersonaEsMenorDelegate esMenorEvent;
        #endregion

        #region propiedades
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        
        private int _edad;

        public int edad
        {
            get { return _edad; }
            set 
            {
                //en el set establezco la condicion de que sea mayor de 18 y llamo al evento si no se cumple
                if (value < 18)//value toma el valor ingresado y lo compara con 18
                {
                    esMenorBaseEvent(value); //si es menor de 18 disparo el evento y le paso la edad
                }
                else //si es mayor de 18 lo guardo
                {
                    _edad = value;
                }


            }

        }
        #endregion

        // declaracion evento para que pueda ser heredado por las hijas
        protected void esMenorBaseEvent(int edad)
        {
            if (esMenorEvent != null)
            {
                esMenorEvent(edad);
            }
        }

      
    }
}
