using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyecto
{
    public partial class frmCarreras : Form
    {
        clsCarreras carreras;
        int idCarrera;


        public frmCarreras()
        {
            InitializeComponent();
            cargarDataGrid();
        }
        public void cargarDataGrid()
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            // Permitir que las columnas se generen automáticamente según el DataSource
            dgvCarreras.AutoGenerateColumns = true;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Facilitar la selección por fila y deshabilitar selección múltiple
            dgvCarreras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarreras.MultiSelect = false;
            try
            {
                dgvCarreras.DataSource = carreras.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                carreras.NombreCarrera = txtNombreCarrera.Text;
                dgvCarreras.DataSource = carreras.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCarreras_SelectionChanged(object sender, EventArgs e)
        {

            // Proteger contra selección nula o estructura inesperada
            if (dgvCarreras.CurrentRow == null) return;
            if (dgvCarreras.CurrentRow.Cells.Count < 3) return;

            var cell0 = dgvCarreras.CurrentRow.Cells[0].Value;
            var cell1 = dgvCarreras.CurrentRow.Cells[1].Value;
            var cell2 = dgvCarreras.CurrentRow.Cells[2].Value;

            if (cell0 == null || cell0 == DBNull.Value) return;

            //este es el campo oculto que me servira de referencia para actualizar y eliminar
            if (!int.TryParse(cell0.ToString(), out idCarrera)) idCarrera = 0;

            //estos son visuales
            txtNombre.Text = cell1 == null || cell1 == DBNull.Value ? string.Empty : cell1.ToString();
            txtDescripcion.Text = cell2 == null || cell2 == DBNull.Value ? string.Empty : cell2.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (carreras == null) carreras = new clsCarreras();
                int tipoOperacion = idCarrera == 0 ? 0 : 1;

                carreras.IdCarrera = idCarrera;
                carreras.NombreCarrera = txtNombre.Text;
                carreras.Descripcion = txtDescripcion.Text;
                string msg = "";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("comfirmar que desea actualizar el dato selecionado", "Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = carreras.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = carreras.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }

                cargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idCarrera = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                carreras.IdCarrera = idCarrera;
                var resp = MessageBox.Show("¿Está seguro de eliminar la carrera seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    string msg = carreras.Eliminar();
                    MessageBox.Show(msg);
                    cargarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
