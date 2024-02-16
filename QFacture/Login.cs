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
    public partial class Login : Form
    {
        BDAcceso conexion = new BDAcceso();
        public static int iduser = 0;
        public static string Estado = null;
        public static int idtipo = 0;

        public Login()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Black;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registro Registrarse = new Registro();
            Registrarse.Show();
        }

        public void login(string user, string password)
        {
            try
            {

                conexion.abrir();
                SqlCommand cmde = new SqlCommand("SELECT Estado, IdTipo FROM Usuario WHERE NombreUsuario = @NombreUsuario", conexion.Conectar);
                cmde.Parameters.AddWithValue("NombreUsuario", user);
                SqlDataReader readere = cmde.ExecuteReader();
                if (readere.Read())
                {
                    Estado = (string)readere["Estado"];
                    idtipo = (int)readere["IdTipo"];
                }
                readere.Close();

                if (Estado == "Activo")
                {

                    SqlCommand cmd = new SqlCommand("SELECT NombreUsuario, Contraseña FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña", conexion.Conectar);
                    cmd.Parameters.AddWithValue("NombreUsuario", user);
                    cmd.Parameters.AddWithValue("Contraseña", password);
                    SqlCommand cmd3 = new SqlCommand("SELECT IdUsuario FROM Usuario WHERE NombreUsuario = @NombreUsuario", conexion.Conectar);
                    cmd3.Parameters.AddWithValue("NombreUsuario", user);
                    SqlDataReader reader3 = cmd3.ExecuteReader();
                    if (reader3.Read())
                    {
                        iduser = (int)reader3["IdUsuario"];
                    }
                    reader3.Close();

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        Interfaz gui = new Interfaz();
                        gui.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrecta", "Datos Incorrectos");
                        conexion.cerrar();
                    }
                }
                else
                {
                    MessageBox.Show("El Usuario Esta Dado de Baja","Usuario");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                conexion.cerrar();
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != "Usuario")
                {
                    lbMsgU.Visible = false;
                    if (txtpass.Text != "Contraseña")
                    {
                        lbMsgP.Visible = false;
                        login(txtUser.Text, txtpass.Text);
                    }
                    else msgErrorP("Ingrese Contraseña");
                }
                else msgErrorU("Ingrese Nombre de Usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void msgErrorU(string msg)
        {
            lbMsgU.Text = msg;
            lbMsgU.Visible = true;
        }

        private void msgErrorP(string msg)
        {
            lbMsgP.Text = msg;
            lbMsgP.Visible = true;
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtpass_Leave(this, new EventArgs());
                btnAcceder.PerformClick();
            }
        }
    }
}
