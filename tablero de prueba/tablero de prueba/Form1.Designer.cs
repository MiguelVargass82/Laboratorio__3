namespace tablero_de_prueba
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJugad = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.numEndu = new System.Windows.Forms.TextBox();
            this.lblFrec = new System.Windows.Forms.Label();
            this.frecEndul = new System.Windows.Forms.TextBox();
            this.contJugad = new System.Windows.Forms.NumericUpDown();
            this.NombreCombobox = new System.Windows.Forms.ComboBox();
            this.txtDato1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.txtDato3 = new System.Windows.Forms.Label();
            this.endulzada = new System.Windows.Forms.TextBox();
            this.lblRegalo = new System.Windows.Forms.Label();
            this.regalo = new System.Windows.Forms.TextBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.saltar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblValorEndu = new System.Windows.Forms.Label();
            this.lblValorRega = new System.Windows.Forms.Label();
            this.valorRega = new System.Windows.Forms.TextBox();
            this.valorEndu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contJugad)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 232);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.LightSalmon;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Location = new System.Drawing.Point(86, 40);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 22);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            this.lblFecha.Visible = false;
            // 
            // btn_fecha
            // 
            this.btn_fecha.Location = new System.Drawing.Point(85, 535);
            this.btn_fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(112, 35);
            this.btn_fecha.TabIndex = 2;
            this.btn_fecha.Text = "Guardar";
            this.btn_fecha.UseVisualStyleBackColor = true;
            this.btn_fecha.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cuantos Jugadores serán?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecciona la fecha de inicio";
            // 
            // btnJugad
            // 
            this.btnJugad.Location = new System.Drawing.Point(86, 142);
            this.btnJugad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJugad.Name = "btnJugad";
            this.btnJugad.Size = new System.Drawing.Size(112, 35);
            this.btnJugad.TabIndex = 7;
            this.btnJugad.Text = "Guardar";
            this.btnJugad.UseVisualStyleBackColor = true;
            this.btnJugad.Click += new System.EventHandler(this.btnJugad_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(81, 288);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(173, 20);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "Número de endulzadas";
            // 
            // numEndu
            // 
            this.numEndu.Location = new System.Drawing.Point(86, 312);
            this.numEndu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numEndu.Name = "numEndu";
            this.numEndu.Size = new System.Drawing.Size(67, 26);
            this.numEndu.TabIndex = 9;
            // 
            // lblFrec
            // 
            this.lblFrec.AutoSize = true;
            this.lblFrec.Location = new System.Drawing.Point(81, 348);
            this.lblFrec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrec.Name = "lblFrec";
            this.lblFrec.Size = new System.Drawing.Size(380, 20);
            this.lblFrec.TabIndex = 10;
            this.lblFrec.Text = "Cada cuanto serán las endulzadas en días (Ej: 5,7,9)";
            this.lblFrec.Click += new System.EventHandler(this.label4_Click);
            // 
            // frecEndul
            // 
            this.frecEndul.Location = new System.Drawing.Point(86, 372);
            this.frecEndul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frecEndul.Name = "frecEndul";
            this.frecEndul.Size = new System.Drawing.Size(64, 26);
            this.frecEndul.TabIndex = 11;
            // 
            // contJugad
            // 
            this.contJugad.Location = new System.Drawing.Point(86, 102);
            this.contJugad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contJugad.Name = "contJugad";
            this.contJugad.Size = new System.Drawing.Size(80, 26);
            this.contJugad.TabIndex = 12;
            this.contJugad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NombreCombobox
            // 
            this.NombreCombobox.FormattingEnabled = true;
            this.NombreCombobox.Location = new System.Drawing.Point(670, 31);
            this.NombreCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NombreCombobox.Name = "NombreCombobox";
            this.NombreCombobox.Size = new System.Drawing.Size(180, 28);
            this.NombreCombobox.TabIndex = 13;
            this.NombreCombobox.Text = "Participantes";
            this.NombreCombobox.Visible = false;
            this.NombreCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDato1
            // 
            this.txtDato1.AutoSize = true;
            this.txtDato1.Location = new System.Drawing.Point(621, 137);
            this.txtDato1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(219, 20);
            this.txtDato1.TabIndex = 14;
            this.txtDato1.Text = "Ingrese el nombre del jugador";
            this.txtDato1.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(626, 162);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(148, 26);
            this.Nombre.TabIndex = 15;
            this.Nombre.Visible = false;
            // 
            // txtDato2
            // 
            this.txtDato2.AutoSize = true;
            this.txtDato2.Location = new System.Drawing.Point(621, 229);
            this.txtDato2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(210, 20);
            this.txtDato2.TabIndex = 16;
            this.txtDato2.Text = "Ingrese el correo del jugador";
            this.txtDato2.Visible = false;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(626, 254);
            this.correo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(148, 26);
            this.correo.TabIndex = 17;
            this.correo.Visible = false;
            // 
            // txtDato3
            // 
            this.txtDato3.AutoSize = true;
            this.txtDato3.Location = new System.Drawing.Point(621, 312);
            this.txtDato3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(276, 20);
            this.txtDato3.TabIndex = 18;
            this.txtDato3.Text = "Ingrese la endulzada ideal del jugador";
            this.txtDato3.Visible = false;
            // 
            // endulzada
            // 
            this.endulzada.Location = new System.Drawing.Point(626, 348);
            this.endulzada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endulzada.Name = "endulzada";
            this.endulzada.Size = new System.Drawing.Size(148, 26);
            this.endulzada.TabIndex = 19;
            this.endulzada.Visible = false;
            // 
            // lblRegalo
            // 
            this.lblRegalo.AutoSize = true;
            this.lblRegalo.Location = new System.Drawing.Point(621, 392);
            this.lblRegalo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegalo.Name = "lblRegalo";
            this.lblRegalo.Size = new System.Drawing.Size(333, 20);
            this.lblRegalo.TabIndex = 20;
            this.lblRegalo.Text = "Ingrese el regalo deseado nombre del jugador";
            this.lblRegalo.Visible = false;
            // 
            // regalo
            // 
            this.regalo.Location = new System.Drawing.Point(626, 417);
            this.regalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regalo.Name = "regalo";
            this.regalo.Size = new System.Drawing.Size(148, 26);
            this.regalo.TabIndex = 21;
            this.regalo.Visible = false;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(644, 472);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(112, 35);
            this.btnSubir.TabIndex = 22;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Visible = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // saltar
            // 
            this.saltar.Location = new System.Drawing.Point(850, 472);
            this.saltar.Name = "saltar";
            this.saltar.Size = new System.Drawing.Size(124, 31);
            this.saltar.TabIndex = 23;
            this.saltar.Text = "Siguiente";
            this.saltar.UseVisualStyleBackColor = true;
            this.saltar.Click += new System.EventHandler(this.saltar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(707, 67);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(98, 40);
            this.btnConsultar.TabIndex = 24;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblValorEndu
            // 
            this.lblValorEndu.AutoSize = true;
            this.lblValorEndu.Location = new System.Drawing.Point(81, 403);
            this.lblValorEndu.Name = "lblValorEndu";
            this.lblValorEndu.Size = new System.Drawing.Size(162, 20);
            this.lblValorEndu.TabIndex = 25;
            this.lblValorEndu.Text = "Valor de la endulzada";
            // 
            // lblValorRega
            // 
            this.lblValorRega.AutoSize = true;
            this.lblValorRega.Location = new System.Drawing.Point(81, 472);
            this.lblValorRega.Name = "lblValorRega";
            this.lblValorRega.Size = new System.Drawing.Size(119, 20);
            this.lblValorRega.TabIndex = 26;
            this.lblValorRega.Text = "Valor del regalo";
            // 
            // valorRega
            // 
            this.valorRega.Location = new System.Drawing.Point(86, 501);
            this.valorRega.Name = "valorRega";
            this.valorRega.Size = new System.Drawing.Size(112, 26);
            this.valorRega.TabIndex = 27;
            // 
            // valorEndu
            // 
            this.valorEndu.Location = new System.Drawing.Point(85, 426);
            this.valorEndu.Name = "valorEndu";
            this.valorEndu.Size = new System.Drawing.Size(112, 26);
            this.valorEndu.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1457, 748);
            this.Controls.Add(this.valorEndu);
            this.Controls.Add(this.valorRega);
            this.Controls.Add(this.lblValorRega);
            this.Controls.Add(this.lblValorEndu);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.saltar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.regalo);
            this.Controls.Add(this.lblRegalo);
            this.Controls.Add(this.endulzada);
            this.Controls.Add(this.txtDato3);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.NombreCombobox);
            this.Controls.Add(this.contJugad);
            this.Controls.Add(this.frecEndul);
            this.Controls.Add(this.lblFrec);
            this.Controls.Add(this.numEndu);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnJugad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contJugad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btn_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJugad;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox numEndu;
        private System.Windows.Forms.Label lblFrec;
        private System.Windows.Forms.TextBox frecEndul;
        private System.Windows.Forms.NumericUpDown contJugad;
        private System.Windows.Forms.ComboBox NombreCombobox;
        private System.Windows.Forms.Label txtDato1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label txtDato2;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label txtDato3;
        private System.Windows.Forms.TextBox endulzada;
        private System.Windows.Forms.Label lblRegalo;
        private System.Windows.Forms.TextBox regalo;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button saltar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblValorEndu;
        private System.Windows.Forms.Label lblValorRega;
        private System.Windows.Forms.TextBox valorRega;
        private System.Windows.Forms.TextBox valorEndu;
    }
}

