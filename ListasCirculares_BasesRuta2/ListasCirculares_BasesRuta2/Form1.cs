using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCirculares_BasesRuta2
{
    public partial class Form1 : Form
    {
        Ruta route = new Ruta();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            route.Agregar(new Base(txtNuevaBase.Text, Convert.ToInt32(txtMinutosBaseAnterior.Text))); 
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            txtInformacion.Text = route.Listar();
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            route.AgregarInicio(new Base(txtNuevaBase.Text, Convert.ToInt32(txtMinutosBaseAnterior.Text)));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (route.Buscar(txtNuevaBase.Text) != null)

                txtInformacion.Text = route.Buscar(txtNuevaBase.Text).ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           if(route.Eliminar(txtNuevaBase.Text))
            {
                txtInformacion.Text = route.Listar();
            }
           
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            if(route.EliminarInicio() == true)
            {
                txtInformacion.Text = route.Listar();
            }
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            if (route.EliminarUltima() == true)
            {
                txtInformacion.Text = route.Listar();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int posicion = Convert.ToInt32(txtPosicionBaseNuevaInsertar.Text);

            route.Insertar(new Base(txtNuevaBase.Text, Convert.ToInt32(txtMinutosBaseAnterior.Text)), posicion);

            txtInformacion.Text = route.Listar();
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            txtInformacion.Text = route.RecorridoFinal(txtBaseName.Text, dtpHoraInicio.Value, dtpHoraFin.Value);
        }
    }
}
