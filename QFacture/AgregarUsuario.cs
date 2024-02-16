using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace QFacture
{
    public partial class AgregarUsuario : Form
    {
        BDAcceso conexion = new BDAcceso();
        public static int iduser = 0;
        public static int tipo = 0;
        public static string tipouser = null;

        public AgregarUsuario()
        {
            InitializeComponent();
            txtapellido.MaxLength = 50;
            txtnombre.MaxLength = 50;
            txtrfc.MaxLength = 15;
            txtdom.MaxLength = 100;
            txtCP.MaxLength = 5;
            txtuser.MaxLength = 50;
            txtpass.MaxLength = 50;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Nombre")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "Nombre";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if (txtapellido.Text == "Apellido")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.Black;
            }
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "Apellido";
                txtapellido.ForeColor = Color.Black;
            }
        }

        private void txtrfc_Enter(object sender, EventArgs e)
        {
            if (txtrfc.Text == "RFC")
            {
                txtrfc.Text = "";
                txtrfc.ForeColor = Color.Black;
            }
        }

        private void txtrfc_Leave(object sender, EventArgs e)
        {
            if (txtrfc.Text == "")
            {
                txtrfc.Text = "RFC";
                txtrfc.ForeColor = Color.Black;
            }
        }

        private void txtdom_Enter(object sender, EventArgs e)
        {
            if (txtdom.Text == "Domicilio Fiscal")
            {
                txtdom.Text = "";
                txtdom.ForeColor = Color.Black;
            }
        }

        private void txtdom_Leave(object sender, EventArgs e)
        {
            if (txtdom.Text == "")
            {
                txtdom.Text = "Domicilio Fiscal";
                txtdom.ForeColor = Color.Black;
            }
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Nombre de Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Nombre de Usuario";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnMuestra_Click(object sender, EventArgs e)
        {
            btnMuestra.Visible = false;
            btnNMuestra.Visible = true;
            txtpass.UseSystemPasswordChar = true;
        }

        private void btnNMuestra_Click(object sender, EventArgs e)
        {
            btnNMuestra.Visible = false;
            btnMuestra.Visible = true;
            txtpass.UseSystemPasswordChar = false;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text == "Nombre" || txtapellido.Text == "Apellido" || txtrfc.Text == "RFC" || txtdom.Text == "Domicilio Fiscal" 
                    || txtCP.Text == "Codigo Postal" || txtuser.Text == "Nombre de Usuario" || txtpass.Text == "Contraseña" || TiposUser.Text == "Tipo de Usuario")
                {
                    MessageBox.Show("Introduzca datos");
                }
                else
                {
                    try
                    {
                        if (tipouser == "Administrador")
                        {
                            tipo = 1;
                        }
                        else
                        {
                            tipo = 2;
                        }
                        conexion.abrir();
                        string aux = txtuser.Text;
                        string query = string.Format("INSERT INTO Usuario (\"NombreUsuario\", \"Contraseña\", \"IdTipo\")" +
                             "VALUES ('{0}', '{1}', '{2}');", txtuser.Text, txtpass.Text, tipo);

                        SqlCommand comando = new SqlCommand(query, conexion.Conectar);
                        comando.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand("SELECT IdUsuario FROM Usuario WHERE NombreUsuario = @NombreUsuario", conexion.Conectar);
                        cmd.Parameters.AddWithValue("NombreUsuario", aux);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            iduser = (int)reader["IdUsuario"];
                        }
                        reader.Close();

                        string query2 = string.Format("INSERT INTO DatosUsuario (\"Nombre\", \"Apellido\", \"RFC\", \"DomicilioFiscal\", \"CodigoPostal\", \"IdUsuario\")" +
                             "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", txtnombre.Text, txtapellido.Text, txtrfc.Text, txtdom.Text, txtCP.Text, iduser);

                        SqlCommand comando2 = new SqlCommand(query2, conexion.Conectar);
                        comando2.ExecuteNonQuery();

                        conexion.cerrar();
                        MessageBox.Show("Usuario Registrado Correctamente", "Registro");
                        this.Close();
                        conexion.cerrar();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("ERROR: " + er.Message);
                        conexion.cerrar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Introduzca Datos");
            }
        }


        public static void Letra(KeyPressEventArgs k)
        {
            if (Char.IsLetter(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsSeparator(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else
            {
                k.Handled = true;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra(e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra(e);
        }

        private void TiposUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = TiposUser.SelectedIndex;
            tipouser = TiposUser.Items[indice].ToString();
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        public static void Numeros(KeyPressEventArgs k)
        {
            if (Char.IsDigit(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsSeparator(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else
            {
                k.Handled = true;
            }
        }

        private void txtCP_Enter(object sender, EventArgs e)
        {
            if (txtCP.Text == "Codigo Postal")
            {
                txtCP.Text = "";
                txtCP.ForeColor = Color.Black;
            }
        }

        private void txtCP_Leave(object sender, EventArgs e)
        {
            if (txtCP.Text == "")
            {
                txtCP.Text = "Codigo Postal";
                txtCP.ForeColor = Color.Black;
            }
        }
    }
}
