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
    public partial class InfoUser : Form
    {
        BDAcceso conexion = new BDAcceso();
        public static string id;


        public InfoUser()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario usuario = new AgregarUsuario();
            usuario.Show();
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'qfactureDataSet1.informacion' Puede moverla o quitarla según sea necesario.
            try
            {
                conexion.abrir();
                this.informacionTableAdapter.Fill(this.qfactureDataSet1.informacion);
                conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = TablaUsuarios.CurrentRow.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                txtApellido.Text = TablaUsuarios.CurrentRow.Cells["apellidoDataGridViewTextBoxColumn"].Value.ToString();
                txtRFC.Text = TablaUsuarios.CurrentRow.Cells["rFCDataGridViewTextBoxColumn"].Value.ToString();
                txtDomicilio.Text = TablaUsuarios.CurrentRow.Cells["domicilioFiscalDataGridViewTextBoxColumn"].Value.ToString();
                txtCP.Text = TablaUsuarios.CurrentRow.Cells["codigoPostalDataGridViewTextBoxColumn"].Value.ToString();
                txtUser.Text = TablaUsuarios.CurrentRow.Cells["nombreUsuarioDataGridViewTextBoxColumn"].Value.ToString();
                txtPass.Text = TablaUsuarios.CurrentRow.Cells["contraseñaDataGridViewTextBoxColumn"].Value.ToString();
                id = TablaUsuarios.CurrentRow.Cells["idUsuarioDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show("Error","Selección"+ x.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();
                SqlCommand sql1 = new SqlCommand("UPDATE Usuario SET NombreUsuario = @NombreUsuario, Contraseña = @Contraseña WHERE IdUsuario = @IdUsuario", conexion.Conectar);
                sql1.Parameters.AddWithValue("@NombreUsuario", txtUser.Text);
                sql1.Parameters.AddWithValue("@Contraseña", txtPass.Text);
                sql1.Parameters.AddWithValue("@IdUsuario", id);
                sql1.ExecuteNonQuery();

                SqlCommand sql = new SqlCommand("UPDATE DatosUsuario SET Nombre = @Nombre, Apellido = @Apellido, RFC = @RFC, " +
                    "DomicilioFiscal = @DomicilioFiscal, CodigoPostal = @CodigoPostal WHERE IdUsuario = @IdUsuario", conexion.Conectar);
                sql.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                sql.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                sql.Parameters.AddWithValue("@RFC", txtRFC.Text);
                sql.Parameters.AddWithValue("@DomicilioFiscal", txtDomicilio.Text);
                sql.Parameters.AddWithValue("@CodigoPostal", txtCP.Text);
                sql.Parameters.AddWithValue("@IdUsuario", id);
                sql.ExecuteNonQuery();

                conexion.cerrar();
            }
            catch(Exception x)
            {
                MessageBox.Show("Error: "+x.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Estado = "Inactivo";
                conexion.abrir();
                SqlCommand sql2 = new SqlCommand("UPDATE Usuario SET Estado = @Estado WHERE IdUsuario = @IdUsuario", conexion.Conectar);
                sql2.Parameters.AddWithValue("@Estado", Estado);
                sql2.Parameters.AddWithValue("@IdUsuario", id);
                sql2.ExecuteNonQuery();
                conexion.cerrar();

                MessageBox.Show("El Usuario Se Dio De Baja Correctamente","Baja");
            }
            catch (Exception m)
            {
                MessageBox.Show("Error al Dar de Baja: " + m.Message);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                string Estado = "Activo";
                conexion.abrir();
                SqlCommand sql2 = new SqlCommand("UPDATE Usuario SET Estado = @Estado WHERE IdUsuario = @IdUsuario", conexion.Conectar);
                sql2.Parameters.AddWithValue("@Estado", Estado);
                sql2.Parameters.AddWithValue("@IdUsuario", id);
                sql2.ExecuteNonQuery();
                conexion.cerrar();

                MessageBox.Show("El Usuario Se Activo Correctamente", "Activar");
            }
            catch (Exception m)
            {
                MessageBox.Show("Error al Activar: " + m.Message);
            }
        }
    }
}
