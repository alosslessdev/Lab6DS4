using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class FormAniadirLibro : Form
    {
        private FBiblioteca dgvExternoAqui;

        public FormAniadirLibro(FBiblioteca dgvExterno)
        {
            InitializeComponent();
            dgvExternoAqui = dgvExterno;

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            ConexionBaseDeDatos conexionBaseDeDatos = new ConexionBaseDeDatos();
            if (txtAutor.Text == "" || txtTitulo.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Por favor rellene los campos");
            }else {
                conexionBaseDeDatos.InsertDatos(txtAutor.Text, txtTitulo.Text, Convert.ToInt16(txtCantidad.Text));
                FBiblioteca fBiblioteca = new FBiblioteca();
                dgvExternoAqui.RefrescarDataGridView(true);
                this.Hide();
            }
            
        }
    }
}
