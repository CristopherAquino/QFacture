namespace QFacture
{
    partial class CapturarF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtCPR = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.ComboBox();
            this.txtNIF = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDomicilioReceptor = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRFCReceptor = new System.Windows.Forms.TextBox();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaOperacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaExpedicion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TablaCrear = new System.Windows.Forms.DataGridView();
            this.DescripcionT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpuestoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCrear)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFolio
            // 
            this.txtFolio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.ForeColor = System.Drawing.Color.Black;
            this.txtFolio.Location = new System.Drawing.Point(19, 36);
            this.txtFolio.MaxLength = 6;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(135, 24);
            this.txtFolio.TabIndex = 0;
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtCP);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtSerie);
            this.panel1.Controls.Add(this.txtCPR);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtMoneda);
            this.panel1.Controls.Add(this.txtNIF);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtDomicilioReceptor);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtDomicilio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtRFCReceptor);
            this.panel1.Controls.Add(this.txtReceptor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtFechaOperacion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFechaExpedicion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Controls.Add(this.txtRFC);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(34, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 197);
            this.panel1.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(801, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 20);
            this.label22.TabIndex = 68;
            this.label22.Text = "Codigo Postal:";
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.ForeColor = System.Drawing.Color.Black;
            this.txtCP.Location = new System.Drawing.Point(805, 36);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(147, 24);
            this.txtCP.TabIndex = 4;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(801, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 20);
            this.label21.TabIndex = 67;
            this.label21.Text = "Codigo P. Receptor:";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.Color.Black;
            this.txtSerie.Location = new System.Drawing.Point(20, 98);
            this.txtSerie.MaxLength = 36;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(135, 24);
            this.txtSerie.TabIndex = 6;
            // 
            // txtCPR
            // 
            this.txtCPR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPR.ForeColor = System.Drawing.Color.Black;
            this.txtCPR.Location = new System.Drawing.Point(805, 97);
            this.txtCPR.MaxLength = 5;
            this.txtCPR.Name = "txtCPR";
            this.txtCPR.Size = new System.Drawing.Size(147, 24);
            this.txtCPR.TabIndex = 10;
            this.txtCPR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPR_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(16, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 20);
            this.label20.TabIndex = 64;
            this.label20.Text = "Serie Fiscal:";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.FormattingEnabled = true;
            this.txtMoneda.Items.AddRange(new object[] {
            "MXN",
            "USD",
            "EUR",
            "CAD",
            "GBP"});
            this.txtMoneda.Location = new System.Drawing.Point(383, 155);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(135, 26);
            this.txtMoneda.TabIndex = 12;
            this.txtMoneda.Text = "Seleccionar";
            this.txtMoneda.SelectedIndexChanged += new System.EventHandler(this.txtMoneda_SelectedIndexChanged);
            // 
            // txtNIF
            // 
            this.txtNIF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.FormattingEnabled = true;
            this.txtNIF.Items.AddRange(new object[] {
            "C-1 Efectivo y equivalentes de efectivo",
            "C-2 Inversión en Instrumentos Financieros",
            "C-3 Cuentas por cobrar",
            "C-4 Inventarios",
            "C-5 Pagos anticipados",
            "C-6 Propiedades, plantas y equipo",
            "C-7 Inversiones permanentes",
            "C-8 Activos intangibles",
            "C-9 Provisiones, contingencias y compromisos",
            "C-10 Instrumentos financieros derivados y relaciones",
            "C-11 Capital contable",
            "C-12 Instrumentos con características de pasivo y de capital",
            "C-13 Partes relacionadas",
            "C-14 Transferencia y baja de activos financieros",
            "C-15 Deterioro en el valor de los activos",
            "C-16 Deterioro de instrumentos financieros por cobrar",
            "C-17 Obligaciones asociadas con el retiro de propiedades",
            "C-18 Instrumentos Financieros por pagar",
            "C-19 Instrumentos Financieros pora cobrar principal",
            "C-20 Acuerdos con control conjunto"});
            this.txtNIF.Location = new System.Drawing.Point(19, 155);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(318, 26);
            this.txtNIF.TabIndex = 11;
            this.txtNIF.Text = "Seleccionar";
            this.txtNIF.SelectedIndexChanged += new System.EventHandler(this.txtNIF_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(556, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Domicilio Fiscal Receptor:";
            // 
            // txtDomicilioReceptor
            // 
            this.txtDomicilioReceptor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDomicilioReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilioReceptor.ForeColor = System.Drawing.Color.Black;
            this.txtDomicilioReceptor.Location = new System.Drawing.Point(560, 97);
            this.txtDomicilioReceptor.MaxLength = 100;
            this.txtDomicilioReceptor.Name = "txtDomicilioReceptor";
            this.txtDomicilioReceptor.Size = new System.Drawing.Size(201, 24);
            this.txtDomicilioReceptor.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(383, 132);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 47;
            this.label19.Text = "Moneda:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(556, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Domicilio Fiscal:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.ForeColor = System.Drawing.Color.Black;
            this.txtDomicilio.Location = new System.Drawing.Point(560, 36);
            this.txtDomicilio.MaxLength = 100;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(201, 24);
            this.txtDomicilio.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(379, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Receptor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "NIF:";
            // 
            // txtRFCReceptor
            // 
            this.txtRFCReceptor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRFCReceptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRFCReceptor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRFCReceptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFCReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFCReceptor.ForeColor = System.Drawing.Color.Black;
            this.txtRFCReceptor.Location = new System.Drawing.Point(202, 97);
            this.txtRFCReceptor.MaxLength = 13;
            this.txtRFCReceptor.Name = "txtRFCReceptor";
            this.txtRFCReceptor.Size = new System.Drawing.Size(135, 24);
            this.txtRFCReceptor.TabIndex = 7;
            // 
            // txtReceptor
            // 
            this.txtReceptor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptor.ForeColor = System.Drawing.Color.Black;
            this.txtReceptor.Location = new System.Drawing.Point(383, 97);
            this.txtReceptor.MaxLength = 100;
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(135, 24);
            this.txtReceptor.TabIndex = 8;
            this.txtReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceptor_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(198, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "RFC Receptor:";
            // 
            // txtFechaOperacion
            // 
            this.txtFechaOperacion.CustomFormat = "";
            this.txtFechaOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaOperacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaOperacion.Location = new System.Drawing.Point(559, 156);
            this.txtFechaOperacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFechaOperacion.Name = "txtFechaOperacion";
            this.txtFechaOperacion.Size = new System.Drawing.Size(168, 24);
            this.txtFechaOperacion.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(379, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "RFC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folio:";
            // 
            // txtFechaExpedicion
            // 
            this.txtFechaExpedicion.CustomFormat = "";
            this.txtFechaExpedicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaExpedicion.Location = new System.Drawing.Point(780, 155);
            this.txtFechaExpedicion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFechaExpedicion.Name = "txtFechaExpedicion";
            this.txtFechaExpedicion.Size = new System.Drawing.Size(168, 24);
            this.txtFechaExpedicion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(556, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Operación:";
            // 
            // txtRFC
            // 
            this.txtRFC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.ForeColor = System.Drawing.Color.Black;
            this.txtRFC.Location = new System.Drawing.Point(383, 36);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(135, 24);
            this.txtRFC.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(202, 36);
            this.txtCliente.MaxLength = 100;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(135, 24);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emisor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(776, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Expedición:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(933, 546);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 44);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(494, 508);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 35);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(765, 505);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Total: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(814, 506);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 17);
            this.txtTotal.TabIndex = 42;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(786, 28);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 37);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar Concepto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(632, 38);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtImpuesto.MaxLength = 3;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(115, 26);
            this.txtImpuesto.TabIndex = 19;
            this.txtImpuesto.Text = "16";
            this.txtImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImpuesto_KeyPress);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(481, 38);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescuento.MaxLength = 3;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(123, 26);
            this.txtDescuento.TabIndex = 18;
            this.txtDescuento.Text = "0";
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(628, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Impuesto (%):";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(477, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Descuento (%):";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(337, 38);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(110, 26);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(333, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 50;
            this.label14.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(19, 38);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(154, 26);
            this.txtDescripcion.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(206, 38);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(102, 26);
            this.txtCantidad.TabIndex = 16;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(202, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "Cantidad:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 14);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 46;
            this.label16.Text = "Descripción:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.txtDescuento);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtImpuesto);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(34, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 91);
            this.panel2.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(34, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 18);
            this.label17.TabIndex = 58;
            this.label17.Text = "DATOS";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(34, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 18);
            this.label18.TabIndex = 59;
            this.label18.Text = "CONCEPTOS";
            // 
            // TablaCrear
            // 
            this.TablaCrear.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablaCrear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.TablaCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaCrear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaCrear.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.TablaCrear.BackgroundColor = System.Drawing.Color.White;
            this.TablaCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaCrear.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaCrear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.TablaCrear.ColumnHeadersHeight = 30;
            this.TablaCrear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaCrear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescripcionT,
            this.CantidadT,
            this.PrecioT,
            this.DescuentoT,
            this.ImpuestoT,
            this.SubtotalT});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaCrear.DefaultCellStyle = dataGridViewCellStyle11;
            this.TablaCrear.EnableHeadersVisualStyles = false;
            this.TablaCrear.GridColor = System.Drawing.Color.White;
            this.TablaCrear.Location = new System.Drawing.Point(144, 347);
            this.TablaCrear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TablaCrear.Name = "TablaCrear";
            this.TablaCrear.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaCrear.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TablaCrear.RowHeadersWidth = 57;
            this.TablaCrear.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TablaCrear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaCrear.Size = new System.Drawing.Size(770, 153);
            this.TablaCrear.TabIndex = 60;
            this.TablaCrear.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TablaCrear_CellValidating);
            this.TablaCrear.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.TablaCrear_RowsAdded);
            // 
            // DescripcionT
            // 
            this.DescripcionT.FillWeight = 300F;
            this.DescripcionT.HeaderText = "Descripción";
            this.DescripcionT.Name = "DescripcionT";
            this.DescripcionT.ReadOnly = true;
            // 
            // CantidadT
            // 
            this.CantidadT.HeaderText = "Cantidad";
            this.CantidadT.Name = "CantidadT";
            this.CantidadT.ReadOnly = true;
            // 
            // PrecioT
            // 
            this.PrecioT.HeaderText = "Precio";
            this.PrecioT.Name = "PrecioT";
            this.PrecioT.ReadOnly = true;
            // 
            // DescuentoT
            // 
            this.DescuentoT.HeaderText = "Descuento (%)";
            this.DescuentoT.Name = "DescuentoT";
            this.DescuentoT.ReadOnly = true;
            // 
            // ImpuestoT
            // 
            this.ImpuestoT.HeaderText = "Impuesto (%)";
            this.ImpuestoT.Name = "ImpuestoT";
            this.ImpuestoT.ReadOnly = true;
            // 
            // SubtotalT
            // 
            this.SubtotalT.HeaderText = "Subtotal";
            this.SubtotalT.Name = "SubtotalT";
            this.SubtotalT.ReadOnly = true;
            // 
            // CapturarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.TablaCrear);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CapturarF";
            this.Text = "CapturarF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCrear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker txtFechaOperacion;
        private System.Windows.Forms.DateTimePicker txtFechaExpedicion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDomicilioReceptor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRFCReceptor;
        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView TablaCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpuestoT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalT;
        private System.Windows.Forms.ComboBox txtMoneda;
        private System.Windows.Forms.ComboBox txtNIF;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCPR;
        private System.Windows.Forms.Label label22;
    }
}