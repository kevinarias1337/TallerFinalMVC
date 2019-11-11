using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR.Controlador;

namespace TallerFinal
{
    public partial class ReadCreateDeleteUpdate : Form
    {
        public ReadCreateDeleteUpdate()
        {
            InitializeComponent();
            btnactualizar.Enabled=false;
        }

        ClsControladorDTO clsControladorDTO = null;
        ClsControladorDAO clsControladorDAO = null;
        DataTable Dtt = null;

        private void Atraspng_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Dispose();
            menu.Show();
        }

        public void MostrarInventario()
        {
            clsControladorDTO = new ClsControladorDTO();
            clsControladorDAO = new ClsControladorDAO(clsControladorDTO);
            Dtt = new DataTable();
            Dtt = clsControladorDAO.MostrarInventario();

            if (Dtt.Rows.Count > 0)
            {
                dbinventario1.DataSource = Dtt;
            }
            else
            {
                MessageBox.Show("No hay registros.");
            }
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarInventario();
        }

        public void Guardar()
        {
            clsControladorDTO = new ClsControladorDTO();
            clsControladorDTO.setNombreproducto(txtnombreproducto.Text);
            clsControladorDTO.setPrecio(Convert.ToInt16(txtprecio.Text));
            clsControladorDTO.setDepartamento(txtdepartamento.Text);
            clsControladorDAO = new ClsControladorDAO(clsControladorDTO);

            clsControladorDAO.GuardarRegistro();
            MessageBox.Show("Registro guardado correctamente.");
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombreproducto.Text.Trim() == "" || txtdepartamento.Text.Trim() == "" || txtprecio.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de que todos los campos esten llenos para poder guardar los registros.");
            }
            else
            {
                MostrarInventario();
                Guardar();
                txtnombreproducto.Clear();
                txtprecio.Clear();
                txtdepartamento.Clear();
                txtnombreproducto.Focus();
            }
        }
        public void Eliminar()
        {
            clsControladorDTO = new ClsControladorDTO();
            clsControladorDTO.setIdproducto(Convert.ToInt16(txtid.Text));
            clsControladorDAO = new ClsControladorDAO(clsControladorDTO);

            clsControladorDAO.EliminarRegistro();
            MessageBox.Show("Registro eliminado correctamente.");
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim()=="")
            {
                MessageBox.Show("Asegurese de que la id ha sido ingresada para poder eliminar los registros.");
            }
            else
            {
                Eliminar();
                MostrarInventario();
                txtid.Clear();
                txtnombreproducto.Clear();
                txtprecio.Clear();
                txtdepartamento.Clear();
                txtnombreproducto.Focus();
                btnguardar.Enabled = true;
                txtdepartamento.Enabled = true;
                txtnombreproducto.Enabled = true;
                txtprecio.Enabled = true;
            }
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnombreproducto.Clear();
            txtprecio.Clear();
            txtdepartamento.Clear();
            txtnombreproducto.Focus();
            btnguardar.Enabled = true;
            txtdepartamento.Enabled = true;
            txtnombreproducto.Enabled = true;
            txtprecio.Enabled = true;
        }

        public void Actualizar()
        {
            clsControladorDTO = new ClsControladorDTO();
            clsControladorDTO.setIdproducto(Convert.ToInt16(txtid.Text));
            clsControladorDTO.setNombreproducto(txtnombreproducto.Text);
            clsControladorDTO.setPrecio(Convert.ToInt16(txtprecio.Text));
            clsControladorDTO.setDepartamento(txtdepartamento.Text);
            clsControladorDAO = new ClsControladorDAO(clsControladorDTO);

            clsControladorDAO.ActualizarRegistro();
            MessageBox.Show("Registro actualizado correctamente.");
        }

        private void Btnactualizar_Click(object sender, EventArgs e)
        {
            MostrarInventario();
            Actualizar();
            txtid.Clear();
            txtnombreproducto.Focus();
            btnguardar.Enabled = true;
            btnactualizar.Enabled = true;
            txtdepartamento.Enabled = true;
            txtnombreproducto.Enabled = true;
            txtprecio.Enabled = true;
        }

        private void Dbinventario1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Visible = true;
            txtid.Visible = true;
            txtid.Enabled = false;

            txtid.Text = dbinventario1.Rows[dbinventario1.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombreproducto.Text = dbinventario1.Rows[dbinventario1.CurrentRow.Index].Cells[1].Value.ToString();
            txtprecio.Text = dbinventario1.Rows[dbinventario1.CurrentRow.Index].Cells[2].Value.ToString();
            txtdepartamento.Text = dbinventario1.Rows[dbinventario1.CurrentRow.Index].Cells[3].Value.ToString();

            btnguardar.Enabled = false;           
            btneliminar.Enabled = true;
            btncancelar.Enabled = true;
            btnactualizar.Enabled = true;
        }

        private void Txtnombreproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorSintaxis.validacionLetras(sender, e);
        }

        private void Txtdepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorSintaxis.validacionLetras(sender, e);
        }

        private void Txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorSintaxis.validacionNumerica(sender, e );
        }
    }
}
