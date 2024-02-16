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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace QFacture
{
    public partial class CapturarF : Form
    {
        BDAcceso conexion = new BDAcceso();
        public static int folio = 1001;
        public static string NIF = null;
        public static string moneda = null;
        public static string rfcr = null;
        public static double impu = 0;
        public static double descuent = 0;

        //pdf
        public static int i = 0;
        public string filename = "";
        public CapturarF()
        {
            InitializeComponent();

            try
            {
                conexion.autocompletar(txtRFCReceptor);
                int usuario = Login.iduser;
                conexion.abrir();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Apellido, RFC, DomicilioFiscal, CodigoPostal FROM DatosUsuario" +
                    " WHERE IdUsuario = @IdUsuario", conexion.Conectar);

                cmd.Parameters.AddWithValue("@IdUsuario", usuario);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nomcliente = (string)reader["Nombre"];
                    string apecliente = (string)reader["Apellido"];
                    txtCliente.Text = nomcliente + " " + apecliente;
                    txtRFC.Text = (string)reader["RFC"];
                    txtDomicilio.Text = (string)reader["DomicilioFiscal"];
                    txtCP.Text = (string)reader["CodigoPostal"];
                }
                reader.Close();

                SqlCommand cmdR = new SqlCommand("SELECT COUNT(*) FROM Factura", conexion.Conectar);
                int cant = Convert.ToInt32(cmdR.ExecuteScalar());
                int t = folio + cant;
                txtFolio.Text = Convert.ToString(t);
                
                conexion.cerrar();
            }
            catch (Exception ini)
            {
                MessageBox.Show("Error de Inicialización: ","Error" + ini.Message);
                conexion.cerrar();
            }
        }

        public double subt = 0;
        public double subtaux = 0;
        public double total = 0;
        public double res = 0;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                res = (double)TablaCrear.CurrentRow.Cells["SubtotalT"].Value;
                TablaCrear.Rows.RemoveAt(TablaCrear.CurrentRow.Index);
                total -= res;
                txtTotal.Text = Convert.ToString(total);

            }
            catch (Exception)
            {
                MessageBox.Show("Error: No Hay Datos");
            }
        }

        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(TablaCrear.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(TablaCrear);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < TablaCrear.ColumnCount; i++)
            {
                datatable.AddCell(TablaCrear.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < TablaCrear.Rows.Count; i++)
            {
                for (j = 0; j < TablaCrear.Columns.Count; j++)
                {
                    if (TablaCrear[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(TablaCrear[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;

        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra(e);
        }

        private void txtReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra(e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtDescripcion.Text == string.Empty || txtCantidad.Text == string.Empty || txtPrecio.Text == string.Empty || txtDescuento.Text == string.Empty || txtImpuesto.Text == string.Empty)
                {
                    MessageBox.Show("Introduzca Todos Los Datos Del Concepto");
                }
                else
                {
                    int cant = Convert.ToInt32(txtCantidad.Text);
                    double pre = Convert.ToDouble(txtPrecio.Text);
                    double desc = Convert.ToDouble(txtDescuento.Text);
                    double imp = Convert.ToDouble(txtImpuesto.Text);

                    double calimp = (imp * 0.01) * (pre*cant);
                    double caldesc = (desc * 0.01) * (pre * cant);
                    subtaux += (pre * cant);
                    subt = (cant * pre) + calimp - caldesc;

                    impu = impu + calimp;
                    descuent = descuent + caldesc;
                    TablaCrear.Rows.Add(txtDescripcion.Text, txtCantidad.Text, txtPrecio.Text, txtDescuento.Text, txtImpuesto.Text, subt);
                }
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Datos del Concepto No Validos","Datos");
            }
        }

        private void TablaCrear_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                total += subt;
                txtTotal.Text = "$" + Convert.ToString(total);
                txtDescripcion.Clear();
                txtCantidad.Clear();
                if (!txtDescuento.Text.Equals("0"))
                {
                    txtDescuento.Text = "0";
                }
                else
                {
                    txtDescuento.Text = "0";
                }
                txtImpuesto.Clear();
                txtPrecio.Clear();

            }
            catch (Exception sum)
            {
                MessageBox.Show("Error al Agregar Datos a Tabla: ","Error" + sum.Message);
            }
        }

        public void tabla()
        {
            SqlCommand agregar = new SqlCommand("INSERT INTO Concepto VALUES (@Descripcion, @Cantidad, @Precio, @Descuento, @Impuesto, @Folio)", conexion.Conectar);

            try
            {
                string dato = string.Empty;
                foreach (DataGridViewRow data in TablaCrear.Rows)
                {
                    dato = data.Cells["DescripcionT"].Value.ToString();
                }

                if (dato == string.Empty)
                {
                    MessageBox.Show("Introduzca Conceptos");
                }
                else
                {
                    foreach (DataGridViewRow row in TablaCrear.Rows)
                    {
                        agregar.Parameters.Clear();

                        string desc = row.Cells["DescripcionT"].Value.ToString();
                        string cant = row.Cells["CantidadT"].Value.ToString();
                        string prec = row.Cells["PrecioT"].Value.ToString();
                        string descuen = row.Cells["DescuentoT"].Value.ToString();
                        string impu = row.Cells["ImpuestoT"].Value.ToString();
                        string fol = txtFolio.Text;

                        int c = int.Parse(cant);
                        double p = double.Parse(prec);
                        int d = int.Parse(descuen);
                        int i = int.Parse(impu);

                        agregar.Parameters.AddWithValue("@Descripcion", desc);
                        agregar.Parameters.AddWithValue("@Cantidad", c);
                        agregar.Parameters.AddWithValue("@Precio", p);
                        agregar.Parameters.AddWithValue("@Descuento", d);
                        agregar.Parameters.AddWithValue("@Impuesto", i);
                        agregar.Parameters.AddWithValue("@Folio", fol);

                        agregar.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception con)
            {
                MessageBox.Show("Error al Agregar Datos de Tabla a BD: "+con.Message);
            }
        }

        private void TablaCrear_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                TablaCrear.Rows[e.RowIndex].ErrorText = "Todos Los Campos Son Obligatorios";
                e.Cancel = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = string.Empty;
                foreach (DataGridViewRow data in TablaCrear.Rows)
                {
                    dato = data.Cells["DescripcionT"].Value.ToString();
                }

                if (txtFolio.Text == string.Empty || txtCliente.Text == string.Empty || txtRFC.Text == string.Empty ||
                    txtDomicilio.Text == string.Empty || txtCP.Text == string.Empty || txtNIF.Text == "Seleccionar" ||
                    txtRFCReceptor.Text == string.Empty || txtCPR.Text == string.Empty ||
                    txtReceptor.Text == string.Empty || txtDomicilioReceptor.Text == string.Empty || txtSerie.Text == string.Empty ||
                    txtMoneda.Text == "Seleccionar" || dato == string.Empty)
                {
                    MessageBox.Show("Introduzca Todos Los Datos");
                }
                else
                {
                    string num = txtFolio.Text;
                    string serie = txtSerie.Text;
                    string emi = txtCliente.Text;
                    string rfc = txtRFC.Text;
                    string dom = txtDomicilio.Text;
                    string fechao = txtFechaOperacion.Value.ToString();
                    string fechae = txtFechaExpedicion.Value.ToString();
                    string receptor = txtReceptor.Text;
                    string RFCReceptor = txtRFCReceptor.Text;
                    string domrecep = txtDomicilioReceptor.Text;
                    string t = txtTotal.Text;
                    int usuario = Login.iduser;

                    conexion.abrir();
                    try
                    {
                        SqlCommand cmdr = new SqlCommand("SELECT RFCReceptor FROM Receptor WHERE RFCReceptor = @RFCReceptor", conexion.Conectar);
                        cmdr.Parameters.AddWithValue("@RFCReceptor", RFCReceptor);
                        SqlDataReader readern = cmdr.ExecuteReader();
                        if (readern.Read())
                        {
                            rfcr = (string)readern["RFCReceptor"];
                        }
                        readern.Close();
                    }
                    catch(Exception d)
                    {
                        MessageBox.Show("Reader"+d.Message);
                    }

                    try
                    {
                        if (txtRFCReceptor.Text != rfcr)
                        {
                            string query = string.Format("INSERT INTO Receptor (\"RFCReceptor\", \"NombreReceptor\", \"DomicilioReceptor\", \"CodigoPostalReceptor\")" +
                                " VALUES ('{0}', '{1}', '{2}', '{3}');", this.txtRFCReceptor.Text, this.txtReceptor.Text, this.txtDomicilioReceptor.Text, this.txtCPR.Text);
                            SqlCommand comando = new SqlCommand(query, conexion.Conectar);
                            comando.ExecuteNonQuery();
                        }
                    }
                    catch(Exception a)
                    {
                        MessageBox.Show("if" + a.Message);
                    }

                    try
                    {
                        string query2 = string.Format("INSERT INTO Factura (\"Folio\", \"SerieFiscal\", \"FechaOperacion\", " +
                            "\"FechaExpedicion\", \"NIF\", \"TipoMoneda\", \"Total \", \"IdUsuario\", \"RFCReceptor\")" +
                         " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
                         this.txtFolio.Text, this.txtSerie.Text, fechao, fechae, NIF,
                             moneda, this.txtTotal.Text, usuario, this.txtRFCReceptor.Text);
                        SqlCommand comando2 = new SqlCommand(query2, conexion.Conectar);
                        comando2.ExecuteNonQuery();
                    }
                    catch (Exception envi)
                    {
                        MessageBox.Show("Error Datos Factura: " + envi.Message);
                    }
                    tabla();
                    MessageBox.Show("Tu Factura Ha Sido Guardada");
                    aPDF();
                    
                    int nf = int.Parse(txtFolio.Text);
                    nf = nf + 1;
                    txtFolio.Text = Convert.ToString(nf);
                    clear();
                    
                }
            }
            catch (Exception env)
            {
                MessageBox.Show("Error al Guardar Factura: " + env.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void txtNIF_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = txtNIF.SelectedIndex;
            NIF = txtNIF.Items[indice].ToString();
        }

        public void clear()
        {
            TablaCrear.Rows.Clear();
            TablaCrear.Refresh();
            txtRFCReceptor.Clear();
            txtReceptor.Clear();
            txtSerie.Clear();
            txtTotal.Clear();
            txtNIF.Text = "Seleccionar";
            txtMoneda.Text = "Seleccionar";
            txtDomicilioReceptor.Clear();
            txtCPR.Clear();
        }

        private void txtMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = txtMoneda.SelectedIndex;
            moneda = txtMoneda.Items[indice].ToString();
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void txtCPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void txtImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        public void aPDF()
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = @"C:";
                save.Title = "Guardar Reporte";
                save.DefaultExt = "pdf";
                save.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
                save.FilterIndex = 2;
                save.RestoreDirectory = true;
                string filename = "";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    filename = save.FileName;
                }

                if (filename.Trim() != "")
                {
                    FileStream file = new FileStream(filename,
                    FileMode.OpenOrCreate,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, file);
                    doc.Open();

                    var fontcolour = new BaseColor(0, 122, 204);

                    doc.Add(new Paragraph("QFACTURE", FontFactory.GetFont("ARIAL", 24, iTextSharp.text.Font.BOLD, fontcolour)));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Paragraph("Emisor: " + txtCliente.Text));
                    doc.Add(new Paragraph("RFC: " + txtRFC.Text));
                    doc.Add(new Paragraph("Domicilio Fiscal: " + txtDomicilio.Text));
                    doc.Add(new Paragraph("Código Postal: " + txtCP.Text));

                    Paragraph fol = new Paragraph("Folio: " + txtFolio.Text);
                    fol.Alignment = 2;
                    doc.Add(fol);
                    Paragraph serfis = new Paragraph("Serie Fiscal: " + txtSerie.Text);
                    serfis.Alignment = 2;
                    doc.Add(serfis);
                    Paragraph fecop = new Paragraph("Fecha de Operación: " + txtFechaOperacion.Text);
                    fecop.Alignment = 2;
                    doc.Add(fecop);
                    Paragraph fecex = new Paragraph("Fecha de expedición: " + txtFechaExpedicion.Text);
                    fecex.Alignment = 2;
                    doc.Add(fecex);
                    doc.Add(new Paragraph("Receptor: " + txtReceptor.Text));
                    doc.Add(new Paragraph("RFC: " + txtRFCReceptor.Text));
                    doc.Add(new Paragraph("Domicilio Fiscal: " + txtDomicilioReceptor.Text));
                    doc.Add(new Paragraph("Código Postal: " + txtCPR.Text));
                    doc.Add(new Paragraph("NIF: " + NIF));
                    doc.Add(new Paragraph("Tipo de moneda: " + moneda));

                    PdfPTable concepto = new PdfPTable(5);

                    PdfPCell Descr = new PdfPCell(new Phrase("Descripción"));
                    PdfPCell Can = new PdfPCell(new Phrase("Cantidad"));
                    PdfPCell Pre = new PdfPCell(new Phrase("Precio unitario"));
                    PdfPCell Descu = new PdfPCell(new Phrase("Descuento"));
                    PdfPCell Imp = new PdfPCell(new Phrase("Impuesto"));

                    concepto.AddCell(Descr);
                    concepto.AddCell(Can);
                    concepto.AddCell(Pre);
                    concepto.AddCell(Descu);
                    concepto.AddCell(Imp);

                    for (int o = 0; o < TablaCrear.RowCount; o++)
                    {
                        String x = TablaCrear.Rows[o].Cells[0].Value.ToString();
                        Descr = new PdfPCell(new Paragraph(x));
                    }
                    for (int o = 0; o < TablaCrear.RowCount; o++)
                    {
                        String x = TablaCrear.Rows[o].Cells[1].Value.ToString();
                        Can = new PdfPCell(new Paragraph(x));
                    }
                    for (int o = 0; o < TablaCrear.RowCount; o++)
                    {
                        String x = TablaCrear.Rows[o].Cells[2].Value.ToString();
                        Pre = new PdfPCell(new Paragraph(x));
                    }
                    for (int o = 0; o < TablaCrear.RowCount; o++)
                    {
                        String x = TablaCrear.Rows[o].Cells[3].Value.ToString();
                        Descu = new PdfPCell(new Paragraph(x));
                    }
                    for (int o = 0; o < TablaCrear.RowCount; o++)
                    {
                        String x = TablaCrear.Rows[o].Cells[4].Value.ToString();
                        Imp = new PdfPCell(new Paragraph(x));
                    }
                    doc.Add(Chunk.NEWLINE);


                    GenerarDocumento(doc);

                    Paragraph fin = new Paragraph("\nSubtotal: $" + subtaux + "\nImpuesto: $" + impu + "\nDescuento: $" + descuent + "\nTotal: $" + total);
                    fin.Alignment = 2;
                    doc.Add(fin);
                    doc.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error al Exportar PDF: "+s.Message);
            }
        }
    }
}
