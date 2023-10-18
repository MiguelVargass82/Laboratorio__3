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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDato1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.txtDato3 = new System.Windows.Forms.Label();
            this.endulzada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regalo = new System.Windows.Forms.TextBox();
            this.btnSubir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contJugad)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.LightSalmon;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Location = new System.Drawing.Point(57, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            this.lblFecha.Visible = false;
            // 
            // btn_fecha
            // 
            this.btn_fecha.Location = new System.Drawing.Point(57, 268);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(75, 23);
            this.btn_fecha.TabIndex = 2;
            this.btn_fecha.Text = "Guardar";
            this.btn_fecha.UseVisualStyleBackColor = true;
            this.btn_fecha.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cuantos Jugadores serán?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecciona la fecha de inicio";
            // 
            // btnJugad
            // 
            this.btnJugad.Location = new System.Drawing.Point(57, 92);
            this.btnJugad.Name = "btnJugad";
            this.btnJugad.Size = new System.Drawing.Size(75, 23);
            this.btnJugad.TabIndex = 7;
            this.btnJugad.Text = "Guardar";
            this.btnJugad.UseVisualStyleBackColor = true;
            this.btnJugad.Click += new System.EventHandler(this.btnJugad_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(54, 187);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(116, 13);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "Número de endulzadas";
            // 
            // numEndu
            // 
            this.numEndu.Location = new System.Drawing.Point(57, 203);
            this.numEndu.Name = "numEndu";
            this.numEndu.Size = new System.Drawing.Size(46, 20);
            this.numEndu.TabIndex = 9;
            // 
            // lblFrec
            // 
            this.lblFrec.AutoSize = true;
            this.lblFrec.Location = new System.Drawing.Point(54, 226);
            this.lblFrec.Name = "lblFrec";
            this.lblFrec.Size = new System.Drawing.Size(257, 13);
            this.lblFrec.TabIndex = 10;
            this.lblFrec.Text = "Cada cuanto serán las endulzadas en días (Ej: 5,7,9)";
            this.lblFrec.Click += new System.EventHandler(this.label4_Click);
            // 
            // frecEndul
            // 
            this.frecEndul.Location = new System.Drawing.Point(57, 242);
            this.frecEndul.Name = "frecEndul";
            this.frecEndul.Size = new System.Drawing.Size(44, 20);
            this.frecEndul.TabIndex = 11;
            // 
            // contJugad
            // 
            this.contJugad.Location = new System.Drawing.Point(57, 66);
            this.contJugad.Name = "contJugad";
            this.contJugad.Size = new System.Drawing.Size(53, 20);
            this.contJugad.TabIndex = 12;
            this.contJugad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(447, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Participantes";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDato1
            // 
            this.txtDato1.AutoSize = true;
            this.txtDato1.Location = new System.Drawing.Point(414, 89);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(146, 13);
            this.txtDato1.TabIndex = 14;
            this.txtDato1.Text = "Ingrese el nombre del jugador";
            this.txtDato1.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(417, 105);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 15;
            this.Nombre.Visible = false;
            // 
            // txtDato2
            // 
            this.txtDato2.AutoSize = true;
            this.txtDato2.Location = new System.Drawing.Point(414, 149);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(141, 13);
            this.txtDato2.TabIndex = 16;
            this.txtDato2.Text = "Ingrese el correo del jugador";
            this.txtDato2.Visible = false;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(417, 165);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(100, 20);
            this.correo.TabIndex = 17;
            this.correo.Visible = false;
            // 
            // txtDato3
            // 
            this.txtDato3.AutoSize = true;
            this.txtDato3.Location = new System.Drawing.Point(414, 203);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(185, 13);
            this.txtDato3.TabIndex = 18;
            this.txtDato3.Text = "Ingrese la endulzada ideal del jugador";
            this.txtDato3.Visible = false;
            // 
            // endulzada
            // 
            this.endulzada.Location = new System.Drawing.Point(417, 226);
            this.endulzada.Name = "endulzada";
            this.endulzada.Size = new System.Drawing.Size(100, 20);
            this.endulzada.TabIndex = 19;
            this.endulzada.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ingrese el regalo deseado nombre del jugador";
            this.label3.Visible = false;
            // 
            // regalo
            // 
            this.regalo.Location = new System.Drawing.Point(417, 271);
            this.regalo.Name = "regalo";
            this.regalo.Size = new System.Drawing.Size(100, 20);
            this.regalo.TabIndex = 21;
            this.regalo.Visible = false;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(429, 307);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 23);
            this.btnSubir.TabIndex = 22;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Visible = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.regalo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endulzada);
            this.Controls.Add(this.txtDato3);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtDato1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label txtDato2;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label txtDato3;
        private System.Windows.Forms.TextBox endulzada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regalo;
        private System.Windows.Forms.Button btnSubir;
    }
}

