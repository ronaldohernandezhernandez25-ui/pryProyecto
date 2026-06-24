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
    public partial class frmTutor : Form
    {
        clsTutor tutor;
        int idTutor;
        public frmTutor()
        {
            InitializeComponent();
            CargarGrid();

        }
        public void CargarGrid()
        {
            tutor = new clsTutor();
            dgvTutor.DataSource = null;
            dgvTutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvTutor.DataSource = tutor.cargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarTutor_TextChanged(object sender, EventArgs e)
        {
            tutor = new clsTutor();
            dgvTutor.DataSource = null;
            dgvTutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutor.NombreTutor = txtBuscarTutor.Text;
                dgvTutor.DataSource = tutor.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarTutor_Click(object sender, EventArgs e)
        {
            try
            {
                tutor.IdTutor = idTutor;
                var resp = MessageBox.Show("Confirmar que se desea elminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    string msg = tutor.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarTutor_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idTutor == 0 ? 0 : 1;
                tutor.IdTutor = idTutor;
                tutor.NombreTutor = txtNombreTutor.Text;
                tutor.Parentesco = txtParentesco.Text;
                tutor.Direccion = txtDireccion.Text;
                tutor.Telefono = txtTelefono.Text;
                tutor.Correo = txtCorreo.Text;

                string msg = "";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("Confirmar que se desea actualizar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = tutor.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = tutor.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }


                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            idTutor = 0;
            txtNombreTutor.Clear();
            txtParentesco.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombreTutor.Focus();
        }

        private void dgvTutor_SelectionChanged(object sender, EventArgs e)
        {
            idTutor = int.Parse(dgvTutor.CurrentRow.Cells[0].Value.ToString());

            txtNombreTutor.Text = dgvTutor.CurrentRow.Cells[1].Value.ToString();
            txtParentesco.Text = dgvTutor.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvTutor.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvTutor.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dgvTutor.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
