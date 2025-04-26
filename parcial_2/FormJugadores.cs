using System;
using System.Windows.Forms;
using System.Linq;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;

namespace parcial_2
{
    public partial class FormJugadores : Form
    {

        DatabaseManager db = new DatabaseManager();
        JugadorService servicio;


        public FormJugadores()
        {
            InitializeComponent();
            servicio = new JugadorService(db);
            CargarJugadores();
        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.Nombre = textBoxNombre.Text;
            jugador.Nivel = int.Parse(textBoxNivel.Text);
            jugador.FechaCreacion = DateTime.Now;

            servicio.Crear(jugador);
            MessageBox.Show("Jugador agregado.");
            CargarJugadores();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            var jugador = servicio.ObtenerTodos().FirstOrDefault(j => j.Nombre == nombre);

            if (jugador != null)
            {
                servicio.Eliminar(jugador.Id);
                MessageBox.Show("Jugador eliminado.");
                CargarJugadores();
            }
            else
            {
                MessageBox.Show("Jugador no encontrado.");
            }
        }


        // Mostrar jugadores en el grid
        private void CargarJugadores()
        {
            dataGridViewJugadores.DataSource = null;
            dataGridViewJugadores.DataSource = servicio.ObtenerTodos();
        }



        private void dataGridViewJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxNombre.Text = dataGridViewJugadores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                textBoxNivel.Text = dataGridViewJugadores.Rows[e.RowIndex].Cells["Nivel"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buscar si el formulario principal ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormMain)
                {
                    form.Show();     // Muestra el formulario principal si está oculto
                    form.BringToFront(); // Lo trae al frente
                    break;
                }
            }

            this.Close(); // Cierra el inventario
        }
    }
    
}
