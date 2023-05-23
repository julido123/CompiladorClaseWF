using CompiladorClaseWF.DataCache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompiladorClaseWF
{
    public partial class frmIngreso : Form
    {
        private codigoIngresoUsuario codigoTxtIngresoUsuario;

        public frmIngreso()
        {
            InitializeComponent();
            codigoTxtIngresoUsuario = codigoIngresoUsuario.ObtenerInstancia();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngresoInfo.Text = "";
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = openFileDialog1.FileName;

                // Leer todo el texto del archivo
                string contenidoArchivo = File.ReadAllText(nombreArchivo);

                // Establecer el contenido del archivo en el TextBox2
                txtIngresoInfo.Text = contenidoArchivo;
            }
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {
            codigoTxtIngresoUsuario.Codigo = txtIngresoInfo;
            frmTablasComponentes ventanaTablaComponentes = new frmTablasComponentes();
            ventanaTablaComponentes.ShowDialog();
        }
    }
}
