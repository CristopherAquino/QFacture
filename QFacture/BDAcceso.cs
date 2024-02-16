using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QFacture
{
    public class BDAcceso
    {
        string BD =  @"Data Source=LAPTOP-EB6DF00N\SQLEXPRESS;Initial Catalog=Qfacture;Integrated Security=True";
        public SqlConnection Conectar = new SqlConnection();
        SqlDataReader dr;
        
        public BDAcceso()
        {
            Conectar.ConnectionString = BD;
        }

        public void abrir()
        {
            try
            {
                Conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Conexion a la base de datos");
            }
        }

        public void cerrar()
        {
                Conectar.Close();
        }

        public void autocompletar(TextBox box)
        {
            try
            {
                Conectar.Open();
                SqlCommand sql = new SqlCommand("SELECT RFCReceptor FROM Receptor", Conectar);
                dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    box.AutoCompleteCustomSource.Add(dr["RFCReceptor"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo autocompletar: "+ex.ToString());
            }
            finally
            {
                Conectar.Close();
            }
        }
    }
}
