using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QFacture
{
    public partial class InfoAdmin : Form
    {
        BDAcceso conexion = new BDAcceso();

        public InfoAdmin()
        {
            InitializeComponent();
            txtapellido.MaxLength = 50;
            txtnombre.MaxLength = 50;
            txtrfc.MaxLength = 15;
            txtdom.MaxLength = 100;
            txtpass.MaxLength = 50;

            try
            {
                int usuario = Login.iduser;
                conexion.abrir();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Apellido, RFC, DomicilioFiscal, CodigoPostal, Contraseña FROM informacion WHERE IdUsuario = @IdUsuario", conexion.Conectar);
                cmd.Parameters.AddWithValue("IdUsuario", usuario);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtnombre.Text = (string)reader["Nombre"];
                    txtapellido.Text = (string)reader["Apellido"];
                    txtrfc.Text = (string)reader["RFC"];
                    txtdom.Text = (string)reader["DomicilioFiscal"];
                    txtCP.Text = (string)reader["CodigoPostal"];
                    txtpass.Text = (string)reader["Contraseña"];
                }
                reader.Close();
                conexion.cerrar();
            }
            catch (Exception ini)
            {
                MessageBox.Show("Error: " + ini.Message);
            }
        }

        private void btnNMuestra_Click(object sender, EventArgs e)
        {
            btnNMuestra.Visible = false;
            btnMuestra.Visible = true;
            txtpass.UseSystemPasswordChar = false;
        }

        private void btnMuestra_Click(object sender, EventArgs e)
        {
            btnMuestra.Visible = false;
            btnNMuestra.Visible = true;
            txtpass.UseSystemPasswordChar = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();
                int usuario = Login.iduser;
                SqlCommand sql = new SqlCommand("UPDATE DatosUsuario SET Nombre=@Nombre, Apellido=@Apellido, RFC=@RFC, " +
                    "DomicilioFiscal=@DomicilioFiscal, CodigoPostal = @CodigoPostal WHERE IdUsuario=@IdUsuario", conexion.Conectar);
                sql.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                sql.Parameters.AddWithValue("@Apellido", txtapellido.Text);
                sql.Parameters.AddWithValue("@RFC", txtrfc.Text);
                sql.Parameters.AddWithValue("@DomicilioFiscal", txtdom.Text);
                sql.Parameters.AddWithValue("@CodigoPostal", txtCP.Text);
                sql.Parameters.AddWithValue("@IdUsuario", usuario);
                sql.ExecuteNonQuery();

                SqlCommand sql2 = new SqlCommand("UPDATE Usuario SET Contraseña=@Contraseña " +
                    "WHERE IdUsuario=@IdUsuario", conexion.Conectar);
                sql2.Parameters.AddWithValue("@Contraseña", txtpass.Text);
                sql2.Parameters.AddWithValue("@IdUsuario", usuario);
                sql2.ExecuteNonQuery();
                conexion.cerrar();
            }
            catch (Exception ini)
            {
                MessageBox.Show("Error: " + ini.Message);
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra(e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra(e);
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }
    }
}
