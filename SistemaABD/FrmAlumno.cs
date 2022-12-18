using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaABD
{
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.establecerConexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.guardarAlumnos(txtNombres, txtApellidos);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void dgvTotalAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.seleccionarAlumnos(dgvTotalAlumnos, txtID, txtNombres, txtApellidos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.modificarAlumnos(txtID, txtNombres, txtApellidos);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.eliminarAlumnos(txtID);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }
    }
}
