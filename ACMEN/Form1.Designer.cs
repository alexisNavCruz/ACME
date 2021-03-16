namespace ACMEN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dateTimePickerBuscar = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescTab2 = new System.Windows.Forms.TextBox();
            this.txtEmpTab2 = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbCapBuscar = new System.Windows.Forms.ComboBox();
            this.cmbProvBuscar = new System.Windows.Forms.ComboBox();
            this.gvEmpresas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCapitalBuscar = new System.Windows.Forms.Label();
            this.lblProvinciaBuscar = new System.Windows.Forms.Label();
            this.lblFechabuscar = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMarcarDescargaBOE = new System.Windows.Forms.Button();
            this.lblDescargaBoe = new System.Windows.Forms.Label();
            this.calendarDescarga = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.cmbCapitales = new System.Windows.Forms.ComboBox();
            this.cmbProinvincia = new System.Windows.Forms.ComboBox();
            this.lblmensajetab1 = new System.Windows.Forms.Label();
            this.btnAdNuevaEmpresa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ProvCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAltaEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCapital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(502, 49);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gestión Empresas BOE";
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(4, 148);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Añadir empresa";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(141, 148);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 30);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Bucar empresa";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 181);
            this.panel1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.dateTimePickerBuscar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDescTab2);
            this.tabPage2.Controls.Add(this.txtEmpTab2);
            this.tabPage2.Controls.Add(this.btnBorrar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.cmbCapBuscar);
            this.tabPage2.Controls.Add(this.cmbProvBuscar);
            this.tabPage2.Controls.Add(this.gvEmpresas);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.lblCapitalBuscar);
            this.tabPage2.Controls.Add(this.lblProvinciaBuscar);
            this.tabPage2.Controls.Add(this.lblFechabuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1372, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(147, 317);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 42);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dateTimePickerBuscar
            // 
            this.dateTimePickerBuscar.Location = new System.Drawing.Point(147, 170);
            this.dateTimePickerBuscar.Name = "dateTimePickerBuscar";
            this.dateTimePickerBuscar.Size = new System.Drawing.Size(223, 26);
            this.dateTimePickerBuscar.TabIndex = 16;
            this.dateTimePickerBuscar.ValueChanged += new System.EventHandler(this.dateTimePickerBuscar_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Location = new System.Drawing.Point(18, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Descripción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Location = new System.Drawing.Point(18, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Empresa";
            // 
            // txtDescTab2
            // 
            this.txtDescTab2.Location = new System.Drawing.Point(147, 443);
            this.txtDescTab2.Multiline = true;
            this.txtDescTab2.Name = "txtDescTab2";
            this.txtDescTab2.Size = new System.Drawing.Size(223, 97);
            this.txtDescTab2.TabIndex = 13;
            // 
            // txtEmpTab2
            // 
            this.txtEmpTab2.Location = new System.Drawing.Point(147, 393);
            this.txtEmpTab2.Name = "txtEmpTab2";
            this.txtEmpTab2.Size = new System.Drawing.Size(223, 26);
            this.txtEmpTab2.TabIndex = 12;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(266, 585);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 42);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(147, 585);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 42);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbCapBuscar
            // 
            this.cmbCapBuscar.FormattingEnabled = true;
            this.cmbCapBuscar.Location = new System.Drawing.Point(147, 274);
            this.cmbCapBuscar.Name = "cmbCapBuscar";
            this.cmbCapBuscar.Size = new System.Drawing.Size(223, 28);
            this.cmbCapBuscar.TabIndex = 9;
            this.cmbCapBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbCapBuscar_SelectedIndexChanged);
            // 
            // cmbProvBuscar
            // 
            this.cmbProvBuscar.FormattingEnabled = true;
            this.cmbProvBuscar.Location = new System.Drawing.Point(147, 216);
            this.cmbProvBuscar.Name = "cmbProvBuscar";
            this.cmbProvBuscar.Size = new System.Drawing.Size(223, 28);
            this.cmbProvBuscar.TabIndex = 8;
            this.cmbProvBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbProvBuscar_SelectedIndexChanged);
            // 
            // gvEmpresas
            // 
            this.gvEmpresas.BackgroundColor = System.Drawing.Color.White;
            this.gvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_ProvCap,
            this.Nombre,
            this.Descripcion,
            this.FechaAltaEmpresa,
            this.NombreCapital});
            this.gvEmpresas.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.gvEmpresas.Location = new System.Drawing.Point(413, 176);
            this.gvEmpresas.Name = "gvEmpresas";
            this.gvEmpresas.RowTemplate.Height = 28;
            this.gvEmpresas.Size = new System.Drawing.Size(924, 451);
            this.gvEmpresas.TabIndex = 7;
            this.gvEmpresas.DoubleClick += new System.EventHandler(this.gvEmpresas_DoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(266, 317);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 42);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCapitalBuscar
            // 
            this.lblCapitalBuscar.AutoSize = true;
            this.lblCapitalBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalBuscar.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblCapitalBuscar.Location = new System.Drawing.Point(19, 277);
            this.lblCapitalBuscar.Name = "lblCapitalBuscar";
            this.lblCapitalBuscar.Size = new System.Drawing.Size(74, 20);
            this.lblCapitalBuscar.TabIndex = 2;
            this.lblCapitalBuscar.Text = "Capital";
            // 
            // lblProvinciaBuscar
            // 
            this.lblProvinciaBuscar.AutoSize = true;
            this.lblProvinciaBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaBuscar.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblProvinciaBuscar.Location = new System.Drawing.Point(19, 216);
            this.lblProvinciaBuscar.Name = "lblProvinciaBuscar";
            this.lblProvinciaBuscar.Size = new System.Drawing.Size(91, 20);
            this.lblProvinciaBuscar.TabIndex = 1;
            this.lblProvinciaBuscar.Text = "Provincia";
            // 
            // lblFechabuscar
            // 
            this.lblFechabuscar.AutoSize = true;
            this.lblFechabuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechabuscar.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblFechabuscar.Location = new System.Drawing.Point(19, 176);
            this.lblFechabuscar.Name = "lblFechabuscar";
            this.lblFechabuscar.Size = new System.Drawing.Size(61, 20);
            this.lblFechabuscar.TabIndex = 0;
            this.lblFechabuscar.Text = "Fecha";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnMarcarDescargaBOE);
            this.tabPage1.Controls.Add(this.lblDescargaBoe);
            this.tabPage1.Controls.Add(this.calendarDescarga);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtDescEmpresa);
            this.tabPage1.Controls.Add(this.txtNombreEmpresa);
            this.tabPage1.Controls.Add(this.cmbCapitales);
            this.tabPage1.Controls.Add(this.cmbProinvincia);
            this.tabPage1.Controls.Add(this.lblmensajetab1);
            this.tabPage1.Controls.Add(this.btnAdNuevaEmpresa);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1372, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnMarcarDescargaBOE
            // 
            this.btnMarcarDescargaBOE.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMarcarDescargaBOE.FlatAppearance.BorderSize = 2;
            this.btnMarcarDescargaBOE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMarcarDescargaBOE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarDescargaBOE.ForeColor = System.Drawing.Color.White;
            this.btnMarcarDescargaBOE.Location = new System.Drawing.Point(838, 504);
            this.btnMarcarDescargaBOE.Name = "btnMarcarDescargaBOE";
            this.btnMarcarDescargaBOE.Size = new System.Drawing.Size(234, 49);
            this.btnMarcarDescargaBOE.TabIndex = 7;
            this.btnMarcarDescargaBOE.Text = "Marcar como descarga BOE";
            this.btnMarcarDescargaBOE.UseVisualStyleBackColor = false;
            this.btnMarcarDescargaBOE.Click += new System.EventHandler(this.btnMarcarDescargaBOE_Click);
            // 
            // lblDescargaBoe
            // 
            this.lblDescargaBoe.AutoSize = true;
            this.lblDescargaBoe.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescargaBoe.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDescargaBoe.Location = new System.Drawing.Point(750, 180);
            this.lblDescargaBoe.Name = "lblDescargaBoe";
            this.lblDescargaBoe.Size = new System.Drawing.Size(533, 20);
            this.lblDescargaBoe.TabIndex = 14;
            this.lblDescargaBoe.Text = "Los días en negrita indican que se ha descargado el BOE";
            // 
            // calendarDescarga
            // 
            this.calendarDescarga.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.calendarDescarga.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.calendarDescarga.Location = new System.Drawing.Point(754, 213);
            this.calendarDescarga.Name = "calendarDescarga";
            this.calendarDescarga.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Location = new System.Drawing.Point(67, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Descripción";
            // 
            // txtDescEmpresa
            // 
            this.txtDescEmpresa.Location = new System.Drawing.Point(272, 261);
            this.txtDescEmpresa.Multiline = true;
            this.txtDescEmpresa.Name = "txtDescEmpresa";
            this.txtDescEmpresa.Size = new System.Drawing.Size(249, 104);
            this.txtDescEmpresa.TabIndex = 3;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(272, 213);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(249, 26);
            this.txtNombreEmpresa.TabIndex = 2;
            // 
            // cmbCapitales
            // 
            this.cmbCapitales.FormattingEnabled = true;
            this.cmbCapitales.Location = new System.Drawing.Point(272, 439);
            this.cmbCapitales.Name = "cmbCapitales";
            this.cmbCapitales.Size = new System.Drawing.Size(249, 28);
            this.cmbCapitales.TabIndex = 5;
            this.cmbCapitales.SelectedIndexChanged += new System.EventHandler(this.cmbCapitales_SelectedIndexChanged);
            // 
            // cmbProinvincia
            // 
            this.cmbProinvincia.FormattingEnabled = true;
            this.cmbProinvincia.Location = new System.Drawing.Point(272, 388);
            this.cmbProinvincia.Name = "cmbProinvincia";
            this.cmbProinvincia.Size = new System.Drawing.Size(249, 28);
            this.cmbProinvincia.TabIndex = 4;
            this.cmbProinvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProinvincia_SelectedIndexChanged);
            // 
            // lblmensajetab1
            // 
            this.lblmensajetab1.AutoSize = true;
            this.lblmensajetab1.Location = new System.Drawing.Point(733, 117);
            this.lblmensajetab1.Name = "lblmensajetab1";
            this.lblmensajetab1.Size = new System.Drawing.Size(0, 20);
            this.lblmensajetab1.TabIndex = 8;
            // 
            // btnAdNuevaEmpresa
            // 
            this.btnAdNuevaEmpresa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdNuevaEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdNuevaEmpresa.FlatAppearance.BorderSize = 2;
            this.btnAdNuevaEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdNuevaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdNuevaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdNuevaEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnAdNuevaEmpresa.Location = new System.Drawing.Point(385, 503);
            this.btnAdNuevaEmpresa.Name = "btnAdNuevaEmpresa";
            this.btnAdNuevaEmpresa.Size = new System.Drawing.Size(136, 50);
            this.btnAdNuevaEmpresa.TabIndex = 5;
            this.btnAdNuevaEmpresa.Text = "Añadir";
            this.btnAdNuevaEmpresa.UseVisualStyleBackColor = false;
            this.btnAdNuevaEmpresa.Click += new System.EventHandler(this.btnAdNuevaEmpresa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Location = new System.Drawing.Point(67, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Capital";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Location = new System.Drawing.Point(67, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Provincia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Location = new System.Drawing.Point(67, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1380, 686);
            this.tabControl1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "IdEmpresa";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // id_ProvCap
            // 
            this.id_ProvCap.HeaderText = "idProvCap ";
            this.id_ProvCap.Name = "id_ProvCap";
            this.id_ProvCap.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Empresa";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "desc";
            this.Descripcion.HeaderText = "Descripción Empresa";
            this.Descripcion.Name = "Descripcion";
            // 
            // FechaAltaEmpresa
            // 
            this.FechaAltaEmpresa.DataPropertyName = "fecha";
            this.FechaAltaEmpresa.HeaderText = "Fecha Alta Empresa";
            this.FechaAltaEmpresa.Name = "FechaAltaEmpresa";
            // 
            // NombreCapital
            // 
            this.NombreCapital.DataPropertyName = "ProvCap";
            this.NombreCapital.HeaderText = "ProvCap ";
            this.NombreCapital.Name = "NombreCapital";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescTab2;
        private System.Windows.Forms.TextBox txtEmpTab2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbCapBuscar;
        private System.Windows.Forms.ComboBox cmbProvBuscar;
        private System.Windows.Forms.DataGridView gvEmpresas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCapitalBuscar;
        private System.Windows.Forms.Label lblProvinciaBuscar;
        private System.Windows.Forms.Label lblFechabuscar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblDescargaBoe;
        private System.Windows.Forms.MonthCalendar calendarDescarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescEmpresa;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.ComboBox cmbCapitales;
        private System.Windows.Forms.ComboBox cmbProinvincia;
        private System.Windows.Forms.Label lblmensajetab1;
        private System.Windows.Forms.Button btnAdNuevaEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnMarcarDescargaBOE;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ProvCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAltaEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCapital;
    }
}

