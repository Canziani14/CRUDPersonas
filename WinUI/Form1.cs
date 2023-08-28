using BLL.Repositorio;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //declaro la variable persona tipo Persona para poder usar sus propiedades
        Persona persona; 

        //instancio el repositorio de personas para poder usar los metodos
        repoPersona repoPersona= new repoPersona();

        //el boton listar Personas va a mostrar a todas las personas en el dtg
        private void btnListarPersonas_Click(object sender, EventArgs e)
        {
            dgPersonas.DataSource = repoPersona.GetAll(); 
        }

        //el boton agregar persona agrega una nueva persona a la lista
        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            persona = new Persona(); //creo una nueva persona tipo Persona que declare al principio
            persona.esMenorEvent += Persona_esMenorEvent;//asigno el evento siempre antes de asignar valores
            //completo las propiedades de persona usando lo que esta escrito en los txt
            persona.id = int.Parse(txtID.Text);
            persona.nombre= txtNombre.Text;
            persona.apellido = txtApellido.Text;
            persona.edad = int.Parse(txtEdad.Text); 
            //si la persona es mayor de 18 lo guarda en el dg
            if (persona.edad > 0 )//> 0 porque cuando hace el set, si no cumple que sea mayor de 18 le asigna edad = 0, entonces si es mayor a 0 paso el evento correctamente
            {
                repoPersona.AgregarPersona(persona);
            }

            RefrescarLista();
        }

        //declaro funcion refrescar dg
        private void RefrescarLista()
        {
            dgPersonas.DataSource = null;
            dgPersonas.DataSource = repoPersona.GetAll();
                
        }

        //se crea automaticamente cuando hago el += y le digo que salte un mensaje de error
        private void Persona_esMenorEvent(int edad)
        {
            MessageBox.Show($"Usted no puede registrar este usuario porque es menor de edad. Edad:{edad}");
        }

        //Busqueda por ID
         private void btnBusquedaPorID_Click(object sender, EventArgs e)
         {
            var persona = repoPersona.GetByID(int.Parse(txtBuscarPorID.Text));
            dgPersonas.DataSource = new List<Persona> { persona };
         }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var persona = repoPersona.DeleteFromID(int.Parse(txtIDaEliminar.Text));
            dgPersonas.DataSource = new List<Persona> { persona };
            MessageBox.Show($"el ID: {persona.id}, se elimino correctamente");
        }

        //Modificacion por ID
         private void btnActualizarPersona_Click(object sender, EventArgs e)
         {
            Persona personaActualizada = repoPersona.GetByID(int.Parse(txtID.Text));
            repoPersona.ActualizarPersona(int.Parse(txtID.Text), txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text));
            // Actualiza los campos en tu formulario con los nuevos valores
            txtID.Text = personaActualizada.id.ToString();
            txtNombre.Text = personaActualizada.nombre;
            txtApellido.Text = personaActualizada.apellido;
            txtEdad.Text = personaActualizada.edad.ToString();

            MessageBox.Show($"Usuario con ID:{personaActualizada.id} modificado correctamente");

            RefrescarLista();
        }
      
       



    }
}
