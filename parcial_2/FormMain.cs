using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using parcial_2;
using Microsoft.Data.SqlClient;
using ClosedXML.Excel;// libreria para poder exportar las tablas a un documento excel

namespace parcial_2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonJugadores_Click(object sender, EventArgs e)
        {
            FormJugadores formJugadores = new FormJugadores();
            formJugadores.Show();
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            new FormInventario().Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Estás seguro que deseas exportar la tabla 'Jugadores' a Excel?", "Confirmar exportación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            using (var connection = new SqlConnection(@"Data Source=ALE_GARCIA\SQLEXPRESS;Initial Catalog=Parcial_2;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Jugadores", connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                using (var workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(table, "Jugadores");

                    var guardar = new SaveFileDialog();
                    guardar.Filter = "Excel (*.xlsx)|*.xlsx";
                    guardar.FileName = "TablaJugadores.xlsx";

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(guardar.FileName);
                        MessageBox.Show("¡Jugadores exportados con éxito!");
                    }
                }
            }
        }

        private void buttonExcelBloque_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Estás seguro que deseas exportar la tabla 'Bloques' a Excel?", "Confirmar exportación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            using (var connection = new SqlConnection(@"Data Source=ALE_GARCIA\SQLEXPRESS;Initial Catalog=Parcial_2;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Bloques", connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                using (var workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(table, "Bloques");

                    var guardar = new SaveFileDialog();
                    guardar.Filter = "Excel (*.xlsx)|*.xlsx";
                    guardar.FileName = "TablaBloques.xlsx";

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(guardar.FileName);
                        MessageBox.Show("¡Bloques exportados con éxito!");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          

        }
    }
}
