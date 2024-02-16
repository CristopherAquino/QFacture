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
    public partial class ConsultaF : Form
    {
        public ConsultaF()
        {
            InitializeComponent();
        }

        //public int IdUsuario = Login.iduser;
        BDAcceso conexion = new BDAcceso();
        DataSet resultado = new DataSet();
        DataView filtro;

        public void leer_datos(ref DataSet dstprincipal, string tabla)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Consulta", conexion.Conectar);
            //cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            try
            {
                conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void ConsultaF_Load(object sender, EventArgs e)
        {
            try
            {
                this.leer_datos(ref resultado, "buscar");
                this.filtro = ((DataTable)resultado.Tables["buscar"]).DefaultView;
                this.TablaBuscar.DataSource = filtro;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string salida = "";
                string[] palabras = this.txtBuscar.Text.Split(' ');
                foreach (string palabra in palabras)
                {
                    if (salida.Length == 0)
                    {
                        salida = "(DomicilioReceptor LIKE '%" + palabra + "%' OR NombreReceptor LIKE '%" + palabra + "%' " +
                            "OR RFCReceptor LIKE '%" + palabra + "%' OR RFCReceptor LIKE '%" + palabra + "%' OR Folio LIKE '%" + palabra + "%'  OR SerieFiscal  LIKE '%" + palabra + "%')";
                    }
                    else
                    {
                        salida += " AND (DomicilioReceptor LIKE '%" + palabra + "%' OR NombreReceptor LIKE '%" + palabra + "%' " +
                            "OR RFCReceptor LIKE '%" + palabra + "%'OR Folio LIKE '%" + palabra + "%'  OR Folio LIKE '%" + palabra + "%'  OR SerieFiscal  LIKE '%" + palabra + "%')";
                    }
                }

                this.filtro.RowFilter = salida;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar Folio, Serie Fiscal, Domicilio Fiscal, RFC o Nombre del Receptor")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar Folio, Serie Fiscal, Domicilio Fiscal, RFC o Nombre del Receptor";
                txtBuscar.ForeColor = Color.Black;
            }
        }
    }
}
