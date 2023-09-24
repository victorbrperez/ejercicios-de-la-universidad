namespace Sistema_de_Inventario_SC
{
    partial class NuevoProductoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProductoForm));
            this.SugerirPreciosLkLb = new System.Windows.Forms.LinkLabel();
            this.tbItbis = new System.Windows.Forms.TextBox();
            this.lbItebis = new System.Windows.Forms.Label();
            this.tbPrecioVentaMay = new System.Windows.Forms.TextBox();
            this.lbPrecioVentaMay = new System.Windows.Forms.Label();
            this.tbPrecioVentaPred = new System.Windows.Forms.TextBox();
            this.lbPrecioVenta = new System.Windows.Forms.Label();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.cerrarBtn = new System.Windows.Forms.Button();
            this.lbNota = new System.Windows.Forms.Label();
            this.fechaDtT = new System.Windows.Forms.DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbMinimoExistencia = new System.Windows.Forms.Label();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.lbUnidad = new System.Windows.Forms.Label();
            this.tbMGM = new System.Windows.Forms.TextBox();
            this.lbMGM = new System.Windows.Forms.Label();
            this.tbMGP = new System.Windows.Forms.TextBox();
            this.lbMGP = new System.Windows.Forms.Label();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.lbPrecioCost = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.cantidadNUD = new System.Windows.Forms.NumericUpDown();
            this.minimoExistenciaNUD = new System.Windows.Forms.NumericUpDown();
            this.unidadCbx = new System.Windows.Forms.ComboBox();
            this.marcaCbx = new System.Windows.Forms.ComboBox();
            this.ubicacionCbx = new System.Windows.Forms.ComboBox();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.tbCostoNeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregarUDS = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimoExistenciaNUD)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SugerirPreciosLkLb
            // 
            this.SugerirPreciosLkLb.AutoSize = true;
            this.SugerirPreciosLkLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SugerirPreciosLkLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SugerirPreciosLkLb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SugerirPreciosLkLb.Location = new System.Drawing.Point(631, 496);
            this.SugerirPreciosLkLb.Name = "SugerirPreciosLkLb";
            this.SugerirPreciosLkLb.Size = new System.Drawing.Size(215, 24);
            this.SugerirPreciosLkLb.TabIndex = 20;
            this.SugerirPreciosLkLb.TabStop = true;
            this.SugerirPreciosLkLb.Text = "Sugerir precios de venta";
            this.SugerirPreciosLkLb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SugerirPreciosLkLb_LinkClicked);
            // 
            // tbItbis
            // 
            this.tbItbis.BackColor = System.Drawing.Color.White;
            this.tbItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItbis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbItbis.Location = new System.Drawing.Point(145, 538);
            this.tbItbis.MaxLength = 25;
            this.tbItbis.Name = "tbItbis";
            this.tbItbis.Size = new System.Drawing.Size(246, 29);
            this.tbItbis.TabIndex = 11;
            this.tbItbis.Text = "18";
            this.tbItbis.TextChanged += new System.EventHandler(this.tbItebis_TextChanged);
            // 
            // lbItebis
            // 
            this.lbItebis.AutoSize = true;
            this.lbItebis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItebis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbItebis.Location = new System.Drawing.Point(22, 538);
            this.lbItebis.Name = "lbItebis";
            this.lbItebis.Size = new System.Drawing.Size(74, 24);
            this.lbItebis.TabIndex = 67;
            this.lbItebis.Text = "ITBIS %";
            // 
            // tbPrecioVentaMay
            // 
            this.tbPrecioVentaMay.BackColor = System.Drawing.Color.White;
            this.tbPrecioVentaMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioVentaMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbPrecioVentaMay.Location = new System.Drawing.Point(599, 219);
            this.tbPrecioVentaMay.MaxLength = 25;
            this.tbPrecioVentaMay.Name = "tbPrecioVentaMay";
            this.tbPrecioVentaMay.ReadOnly = true;
            this.tbPrecioVentaMay.Size = new System.Drawing.Size(246, 29);
            this.tbPrecioVentaMay.TabIndex = 15;
            // 
            // lbPrecioVentaMay
            // 
            this.lbPrecioVentaMay.AutoSize = true;
            this.lbPrecioVentaMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioVentaMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbPrecioVentaMay.Location = new System.Drawing.Point(437, 222);
            this.lbPrecioVentaMay.Name = "lbPrecioVentaMay";
            this.lbPrecioVentaMay.Size = new System.Drawing.Size(157, 24);
            this.lbPrecioVentaMay.TabIndex = 66;
            this.lbPrecioVentaMay.Text = "PVM + ITBIS RD$";
            // 
            // tbPrecioVentaPred
            // 
            this.tbPrecioVentaPred.BackColor = System.Drawing.Color.White;
            this.tbPrecioVentaPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioVentaPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbPrecioVentaPred.Location = new System.Drawing.Point(599, 166);
            this.tbPrecioVentaPred.MaxLength = 25;
            this.tbPrecioVentaPred.Name = "tbPrecioVentaPred";
            this.tbPrecioVentaPred.ReadOnly = true;
            this.tbPrecioVentaPred.Size = new System.Drawing.Size(246, 29);
            this.tbPrecioVentaPred.TabIndex = 14;
            this.tbPrecioVentaPred.TextChanged += new System.EventHandler(this.tbPrecioVentaPred_TextChanged);
            // 
            // lbPrecioVenta
            // 
            this.lbPrecioVenta.AutoSize = true;
            this.lbPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbPrecioVenta.Location = new System.Drawing.Point(437, 166);
            this.lbPrecioVenta.Name = "lbPrecioVenta";
            this.lbPrecioVenta.Size = new System.Drawing.Size(153, 24);
            this.lbPrecioVenta.TabIndex = 65;
            this.lbPrecioVenta.Text = "PVP + ITBIS RD$";
            // 
            // registrarBtn
            // 
            this.registrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.registrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(61)))));
            this.registrarBtn.FlatAppearance.BorderSize = 0;
            this.registrarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.registrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.registrarBtn.Location = new System.Drawing.Point(581, 552);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(121, 47);
            this.registrarBtn.TabIndex = 21;
            this.registrarBtn.Text = "Registrar";
            this.registrarBtn.UseVisualStyleBackColor = false;
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // cerrarBtn
            // 
            this.cerrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.cerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cerrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(61)))));
            this.cerrarBtn.FlatAppearance.BorderSize = 0;
            this.cerrarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.cerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cerrarBtn.Location = new System.Drawing.Point(724, 552);
            this.cerrarBtn.Name = "cerrarBtn";
            this.cerrarBtn.Size = new System.Drawing.Size(122, 47);
            this.cerrarBtn.TabIndex = 22;
            this.cerrarBtn.Text = "Cerrar";
            this.cerrarBtn.UseVisualStyleBackColor = false;
            this.cerrarBtn.Click += new System.EventHandler(this.cerrarBtn_Click);
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbNota.Location = new System.Drawing.Point(441, 428);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(49, 24);
            this.lbNota.TabIndex = 64;
            this.lbNota.Text = "Nota";
            // 
            // fechaDtT
            // 
            this.fechaDtT.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.fechaDtT.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.fechaDtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDtT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDtT.Location = new System.Drawing.Point(600, 376);
            this.fechaDtT.Name = "fechaDtT";
            this.fechaDtT.Size = new System.Drawing.Size(246, 29);
            this.fechaDtT.TabIndex = 18;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbFecha.Location = new System.Drawing.Point(438, 376);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(64, 24);
            this.lbFecha.TabIndex = 63;
            this.lbFecha.Text = "Fecha";
            // 
            // lbMinimoExistencia
            // 
            this.lbMinimoExistencia.AutoSize = true;
            this.lbMinimoExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinimoExistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbMinimoExistencia.Location = new System.Drawing.Point(438, 315);
            this.lbMinimoExistencia.Name = "lbMinimoExistencia";
            this.lbMinimoExistencia.Size = new System.Drawing.Size(104, 48);
            this.lbMinimoExistencia.TabIndex = 62;
            this.lbMinimoExistencia.Text = "Minimo en \r\nexistenica";
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.AutoSize = true;
            this.lbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbUbicacion.Location = new System.Drawing.Point(438, 268);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(94, 24);
            this.lbUbicacion.TabIndex = 60;
            this.lbUbicacion.Text = "Ubicación";
            // 
            // lbUnidad
            // 
            this.lbUnidad.AutoSize = true;
            this.lbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbUnidad.Location = new System.Drawing.Point(21, 228);
            this.lbUnidad.Name = "lbUnidad";
            this.lbUnidad.Size = new System.Drawing.Size(70, 24);
            this.lbUnidad.TabIndex = 58;
            this.lbUnidad.Text = "Unidad";
            // 
            // tbMGM
            // 
            this.tbMGM.BackColor = System.Drawing.Color.White;
            this.tbMGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMGM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbMGM.Location = new System.Drawing.Point(146, 485);
            this.tbMGM.MaxLength = 25;
            this.tbMGM.Name = "tbMGM";
            this.tbMGM.Size = new System.Drawing.Size(246, 29);
            this.tbMGM.TabIndex = 10;
            this.tbMGM.TextChanged += new System.EventHandler(this.tbMGM_TextChanged);
            // 
            // lbMGM
            // 
            this.lbMGM.AutoSize = true;
            this.lbMGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMGM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbMGM.Location = new System.Drawing.Point(22, 485);
            this.lbMGM.Name = "lbMGM";
            this.lbMGM.Size = new System.Drawing.Size(76, 24);
            this.lbMGM.TabIndex = 55;
            this.lbMGM.Text = "MGM %";
            // 
            // tbMGP
            // 
            this.tbMGP.BackColor = System.Drawing.Color.White;
            this.tbMGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMGP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbMGP.Location = new System.Drawing.Point(147, 433);
            this.tbMGP.MaxLength = 25;
            this.tbMGP.Name = "tbMGP";
            this.tbMGP.Size = new System.Drawing.Size(246, 29);
            this.tbMGP.TabIndex = 9;
            this.tbMGP.TextChanged += new System.EventHandler(this.tbMGP_TextChanged);
            // 
            // lbMGP
            // 
            this.lbMGP.AutoSize = true;
            this.lbMGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMGP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbMGP.Location = new System.Drawing.Point(22, 433);
            this.lbMGP.Name = "lbMGP";
            this.lbMGP.Size = new System.Drawing.Size(72, 24);
            this.lbMGP.TabIndex = 52;
            this.lbMGP.Text = "MGP %";
            // 
            // tbCosto
            // 
            this.tbCosto.BackColor = System.Drawing.Color.White;
            this.tbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbCosto.Location = new System.Drawing.Point(146, 384);
            this.tbCosto.MaxLength = 25;
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(246, 29);
            this.tbCosto.TabIndex = 8;
            this.tbCosto.TextChanged += new System.EventHandler(this.tbPrecioCosto_TextChanged);
            // 
            // lbPrecioCost
            // 
            this.lbPrecioCost.AutoSize = true;
            this.lbPrecioCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbPrecioCost.Location = new System.Drawing.Point(22, 387);
            this.lbPrecioCost.Name = "lbPrecioCost";
            this.lbPrecioCost.Size = new System.Drawing.Size(99, 24);
            this.lbPrecioCost.TabIndex = 48;
            this.lbPrecioCost.Text = "Costo $RD";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbCantidad.Location = new System.Drawing.Point(21, 331);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(84, 24);
            this.lbCantidad.TabIndex = 46;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbMarca.Location = new System.Drawing.Point(22, 285);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(62, 24);
            this.lbMarca.TabIndex = 43;
            this.lbMarca.Text = "Marca";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.White;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbDescripcion.Location = new System.Drawing.Point(145, 158);
            this.tbDescripcion.MaxLength = 50;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(246, 49);
            this.tbDescripcion.TabIndex = 3;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbDescripcion.Location = new System.Drawing.Point(19, 158);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lbDescripcion.TabIndex = 39;
            this.lbDescripcion.Text = "Descripción";
            // 
            // tbReferencia
            // 
            this.tbReferencia.BackColor = System.Drawing.Color.White;
            this.tbReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbReferencia.Location = new System.Drawing.Point(145, 110);
            this.tbReferencia.MaxLength = 20;
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(246, 29);
            this.tbReferencia.TabIndex = 2;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbReferencia.Location = new System.Drawing.Point(20, 110);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(101, 24);
            this.lbReferencia.TabIndex = 36;
            this.lbReferencia.Text = "Referencia";
            // 
            // mskCodigo
            // 
            this.mskCodigo.BackColor = System.Drawing.Color.White;
            this.mskCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.mskCodigo.Location = new System.Drawing.Point(146, 64);
            this.mskCodigo.Mask = "99999";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(246, 29);
            this.mskCodigo.TabIndex = 1;
            this.mskCodigo.ValidatingType = typeof(int);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbCodigo.Location = new System.Drawing.Point(20, 64);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(71, 24);
            this.lbCodigo.TabIndex = 33;
            this.lbCodigo.Text = "Código";
            // 
            // cantidadNUD
            // 
            this.cantidadNUD.BackColor = System.Drawing.Color.White;
            this.cantidadNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.cantidadNUD.Location = new System.Drawing.Point(147, 331);
            this.cantidadNUD.Name = "cantidadNUD";
            this.cantidadNUD.Size = new System.Drawing.Size(244, 29);
            this.cantidadNUD.TabIndex = 7;
            // 
            // minimoExistenciaNUD
            // 
            this.minimoExistenciaNUD.BackColor = System.Drawing.Color.White;
            this.minimoExistenciaNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimoExistenciaNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.minimoExistenciaNUD.Location = new System.Drawing.Point(600, 321);
            this.minimoExistenciaNUD.Name = "minimoExistenciaNUD";
            this.minimoExistenciaNUD.Size = new System.Drawing.Size(246, 29);
            this.minimoExistenciaNUD.TabIndex = 17;
            // 
            // unidadCbx
            // 
            this.unidadCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.unidadCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unidadCbx.BackColor = System.Drawing.Color.White;
            this.unidadCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.unidadCbx.FormattingEnabled = true;
            this.unidadCbx.Location = new System.Drawing.Point(145, 226);
            this.unidadCbx.Name = "unidadCbx";
            this.unidadCbx.Size = new System.Drawing.Size(184, 32);
            this.unidadCbx.TabIndex = 4;
            this.unidadCbx.Text = "UD";
            // 
            // marcaCbx
            // 
            this.marcaCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.marcaCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.marcaCbx.BackColor = System.Drawing.Color.White;
            this.marcaCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.marcaCbx.FormattingEnabled = true;
            this.marcaCbx.Location = new System.Drawing.Point(147, 278);
            this.marcaCbx.Name = "marcaCbx";
            this.marcaCbx.Size = new System.Drawing.Size(182, 32);
            this.marcaCbx.TabIndex = 5;
            this.marcaCbx.Text = "Generico";
            // 
            // ubicacionCbx
            // 
            this.ubicacionCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ubicacionCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ubicacionCbx.BackColor = System.Drawing.Color.White;
            this.ubicacionCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacionCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.ubicacionCbx.FormattingEnabled = true;
            this.ubicacionCbx.ItemHeight = 24;
            this.ubicacionCbx.Location = new System.Drawing.Point(600, 268);
            this.ubicacionCbx.Name = "ubicacionCbx";
            this.ubicacionCbx.Size = new System.Drawing.Size(184, 32);
            this.ubicacionCbx.TabIndex = 16;
            this.ubicacionCbx.Text = "N/E";
            // 
            // tbDescuento
            // 
            this.tbDescuento.BackColor = System.Drawing.Color.White;
            this.tbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbDescuento.Location = new System.Drawing.Point(599, 64);
            this.tbDescuento.MaxLength = 25;
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.Size = new System.Drawing.Size(246, 29);
            this.tbDescuento.TabIndex = 12;
            this.tbDescuento.Text = "0";
            this.tbDescuento.TextChanged += new System.EventHandler(this.tbDescuento_TextChanged);
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbDescuento.Location = new System.Drawing.Point(437, 64);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(121, 24);
            this.lbDescuento.TabIndex = 74;
            this.lbDescuento.Text = "Descuento %";
            // 
            // tbCostoNeto
            // 
            this.tbCostoNeto.BackColor = System.Drawing.Color.White;
            this.tbCostoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoNeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbCostoNeto.Location = new System.Drawing.Point(599, 115);
            this.tbCostoNeto.MaxLength = 25;
            this.tbCostoNeto.Name = "tbCostoNeto";
            this.tbCostoNeto.ReadOnly = true;
            this.tbCostoNeto.Size = new System.Drawing.Size(246, 29);
            this.tbCostoNeto.TabIndex = 13;
            this.tbCostoNeto.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(437, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Costo neto $RD";
            // 
            // tbNota
            // 
            this.tbNota.BackColor = System.Drawing.Color.White;
            this.tbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.tbNota.Location = new System.Drawing.Point(599, 428);
            this.tbNota.MaxLength = 256;
            this.tbNota.Multiline = true;
            this.tbNota.Name = "tbNota";
            this.tbNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNota.Size = new System.Drawing.Size(246, 49);
            this.tbNota.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(61)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(790, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 32);
            this.button3.TabIndex = 75;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(61)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(335, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 32);
            this.button2.TabIndex = 72;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregarUDS
            // 
            this.btnAgregarUDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.btnAgregarUDS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(61)))));
            this.btnAgregarUDS.FlatAppearance.BorderSize = 0;
            this.btnAgregarUDS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.btnAgregarUDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUDS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnAgregarUDS.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUDS.Image")));
            this.btnAgregarUDS.Location = new System.Drawing.Point(335, 226);
            this.btnAgregarUDS.Name = "btnAgregarUDS";
            this.btnAgregarUDS.Size = new System.Drawing.Size(56, 32);
            this.btnAgregarUDS.TabIndex = 71;
            this.btnAgregarUDS.UseVisualStyleBackColor = false;
            this.btnAgregarUDS.Click += new System.EventHandler(this.btnAgregarUDS_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.Controls.Add(this.lbTitulo);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(870, 40);
            this.topPanel.TabIndex = 1;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.lbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("lbTitulo.Image")));
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitulo.Location = new System.Drawing.Point(14, 8);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(196, 24);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "      Nuevo producto";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NuevoProductoForm
            // 
            this.AcceptButton = this.registrarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CancelButton = this.cerrarBtn;
            this.ClientSize = new System.Drawing.Size(870, 623);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.tbCostoNeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbDescuento);
            this.Controls.Add(this.lbDescuento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarUDS);
            this.Controls.Add(this.ubicacionCbx);
            this.Controls.Add(this.marcaCbx);
            this.Controls.Add(this.unidadCbx);
            this.Controls.Add(this.minimoExistenciaNUD);
            this.Controls.Add(this.cantidadNUD);
            this.Controls.Add(this.SugerirPreciosLkLb);
            this.Controls.Add(this.tbItbis);
            this.Controls.Add(this.lbItebis);
            this.Controls.Add(this.tbPrecioVentaMay);
            this.Controls.Add(this.lbPrecioVentaMay);
            this.Controls.Add(this.tbPrecioVentaPred);
            this.Controls.Add(this.lbPrecioVenta);
            this.Controls.Add(this.registrarBtn);
            this.Controls.Add(this.cerrarBtn);
            this.Controls.Add(this.lbNota);
            this.Controls.Add(this.fechaDtT);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbMinimoExistencia);
            this.Controls.Add(this.lbUbicacion);
            this.Controls.Add(this.lbUnidad);
            this.Controls.Add(this.tbMGM);
            this.Controls.Add(this.lbMGM);
            this.Controls.Add(this.tbMGP);
            this.Controls.Add(this.lbMGP);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.lbPrecioCost);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.tbReferencia);
            this.Controls.Add(this.lbReferencia);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(898, 652);
            this.MinimumSize = new System.Drawing.Size(876, 652);
            this.Name = "NuevoProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo producto";
            this.Load += new System.EventHandler(this.NuevoProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimoExistenciaNUD)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.LinkLabel SugerirPreciosLkLb;
        private System.Windows.Forms.TextBox tbItbis;
        private System.Windows.Forms.Label lbItebis;
        private System.Windows.Forms.TextBox tbPrecioVentaMay;
        private System.Windows.Forms.Label lbPrecioVentaMay;
        private System.Windows.Forms.TextBox tbPrecioVentaPred;
        private System.Windows.Forms.Label lbPrecioVenta;
        private System.Windows.Forms.Button registrarBtn;
        private System.Windows.Forms.Button cerrarBtn;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.DateTimePicker fechaDtT;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbMinimoExistencia;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.Label lbUnidad;
        private System.Windows.Forms.TextBox tbMGM;
        private System.Windows.Forms.Label lbMGM;
        private System.Windows.Forms.TextBox tbMGP;
        private System.Windows.Forms.Label lbMGP;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.Label lbPrecioCost;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.NumericUpDown cantidadNUD;
        private System.Windows.Forms.NumericUpDown minimoExistenciaNUD;
        private System.Windows.Forms.ComboBox unidadCbx;
        private System.Windows.Forms.ComboBox marcaCbx;
        private System.Windows.Forms.ComboBox ubicacionCbx;
        private System.Windows.Forms.Button btnAgregarUDS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbCostoNeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNota;
    }
}