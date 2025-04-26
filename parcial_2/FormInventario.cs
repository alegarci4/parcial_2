using System;
using System.Linq;
using System.Windows.Forms;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;


namespace parcial_2
{

    public partial class FormInventario : Form
    {
        private InventarioService _inventarioService;
        private BloqueService _bloqueService;
        private JugadorService _jugadorService;

        public FormInventario()
        {
            InitializeComponent();

            var db = new DatabaseManager();
            _jugadorService = new JugadorService(db);
            _bloqueService = new BloqueService(db);
            _inventarioService = new InventarioService(db, _jugadorService, _bloqueService);

            comboBoxRarezas.Items.AddRange(new string[] { "Todos", "Común", "Raro", "Épico" });
            comboBoxRarezas.SelectedIndex = 0;
            comboBoxRarezas.SelectedIndexChanged += Filtrar;

            MostrarInventario("Todos");
        }


        private void Filtrar(object sender, EventArgs e)
        {
            string seleccion = comboBoxRarezas.SelectedItem.ToString();
            MostrarInventario(seleccion);
        }


        private void MostrarInventario(string rareza)
        {
            var inventario = _inventarioService.ObtenerTodos();

            if (rareza != "Todos")
            {
                var bloques = _bloqueService.BuscarPorRareza(rareza).Select(b => b.Id).ToList();
                inventario = inventario.Where(i => bloques.Contains(i.BloqueId)).ToList();
            }

            var vista = inventario.Select(i =>
            {
                var bloque = _bloqueService.ObtenerPorId(i.BloqueId);
                var jugador = _jugadorService.ObtenerPorId(i.JugadorId);

                return new
                {
                    Jugador = jugador?.Nombre ?? "Desconocido",
                    Nivel = jugador?.Nivel ?? 0,
                    Bloque = bloque?.Nombre ?? "Desconocido",
                    Tipo = bloque?.Tipo ?? "N/A",
                    Rareza = bloque?.Rareza ?? "N/A",
                    Cantidad = i.Cantidad
                };
            }).ToList();

            dataGridViewInventario.DataSource = vista;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
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

        private void comboBoxRarezas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }

}
