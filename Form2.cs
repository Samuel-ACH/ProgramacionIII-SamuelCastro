using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Entidades;


namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        UsuarioDA usuarioDA = new UsuarioDA();
        string operacion = string.Empty;
        Usuario user = new Usuario();


        private void Form2_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
           DatosDGV.DataSource = usuarioDA.ListarUsuarios();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";

        }
        private void HabilitarControles()
        {
            txtusuario.Enabled = true;
            txtnombre.Enabled = true;
            txtcontraseña.Enabled = true;
           
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void DesabilitarControles()
        {
            txtusuario.Enabled = false;
            txtnombre.Enabled = false;
            txtcontraseña.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void LimpiarControles()
        {
            txtusuario.Clear();
            txtusuario.Text = "";
            txtcontraseña.Text = string.Empty;
            txtnombre.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            user.IdUsuario = txtusuario.Text;
            user.Nombre = txtnombre.Text;
            user.Clave = txtcontraseña.Text;
           

            if (operacion == "Nuevo")
            {
                bool inserto = usuarioDA.InsertarUsuario(user);

                if (inserto)
                {
                    MessageBox.Show("Usuario Creado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Crear");
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }
}
