namespace Lab3_Amigo_Secreto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblFechaIn = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblFrec = new System.Windows.Forms.Label();
            this.fechaIni = new System.Windows.Forms.DateTimePicker();
            this.numeroJugadores = new System.Windows.Forms.NumericUpDown();
            this.numEndu = new System.Windows.Forms.NumericUpDown();
            this.OpcionJugad = new System.Windows.Forms.DomainUpDown();
            this.consultCorreo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.frecEndul = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeroJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecEndul)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amigo Secreto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJugador.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblJugador.Location = new System.Drawing.Point(51, 119);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(187, 19);
            this.lblJugador.TabIndex = 1;
            this.lblJugador.Text = "¿Cuántos Jugadores serán?";
            // 
            // lblFechaIn
            // 
            this.lblFechaIn.AutoSize = true;
            this.lblFechaIn.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaIn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblFechaIn.Location = new System.Drawing.Point(25, 164);
            this.lblFechaIn.Name = "lblFechaIn";
            this.lblFechaIn.Size = new System.Drawing.Size(264, 19);
            this.lblFechaIn.TabIndex = 2;
            this.lblFechaIn.Text = "Selecciona la fecha de inicio del juego";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNum.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblNum.Location = new System.Drawing.Point(3, 209);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(317, 19);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "¿Cuántas endulzadas serán? (Incluye el regalo)";
            // 
            // lblFrec
            // 
            this.lblFrec.AutoSize = true;
            this.lblFrec.BackColor = System.Drawing.Color.Transparent;
            this.lblFrec.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFrec.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblFrec.Location = new System.Drawing.Point(25, 254);
            this.lblFrec.Name = "lblFrec";
            this.lblFrec.Size = new System.Drawing.Size(249, 38);
            this.lblFrec.TabIndex = 4;
            this.lblFrec.Text = "¿Cada cuánto serán las endulzadas? \r\n                (En días Ej: 5,7,9)";
            // 
            // fechaIni
            // 
            this.fechaIni.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.fechaIni.CalendarTitleBackColor = System.Drawing.Color.PapayaWhip;
            this.fechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIni.Location = new System.Drawing.Point(74, 186);
            this.fechaIni.Name = "fechaIni";
            this.fechaIni.Size = new System.Drawing.Size(173, 20);
            this.fechaIni.TabIndex = 5;
            // 
            // numeroJugadores
            // 
            this.numeroJugadores.BackColor = System.Drawing.Color.White;
            this.numeroJugadores.Location = new System.Drawing.Point(113, 141);
            this.numeroJugadores.Name = "numeroJugadores";
            this.numeroJugadores.Size = new System.Drawing.Size(63, 20);
            this.numeroJugadores.TabIndex = 6;
            this.numeroJugadores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeroJugadores.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numEndu
            // 
            this.numEndu.Location = new System.Drawing.Point(113, 231);
            this.numEndu.Name = "numEndu";
            this.numEndu.Size = new System.Drawing.Size(63, 20);
            this.numEndu.TabIndex = 10;
            this.numEndu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEndu.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // OpcionJugad
            // 
            this.OpcionJugad.Location = new System.Drawing.Point(395, 143);
            this.OpcionJugad.Name = "OpcionJugad";
            this.OpcionJugad.Size = new System.Drawing.Size(61, 20);
            this.OpcionJugad.TabIndex = 12;
            this.OpcionJugad.Text = "Correo";
            this.OpcionJugad.Visible = false;
            this.OpcionJugad.SelectedItemChanged += new System.EventHandler(this.OpcionJugad_SelectedItemChanged);
            // 
            // consultCorreo
            // 
            this.consultCorreo.Location = new System.Drawing.Point(395, 169);
            this.consultCorreo.Name = "consultCorreo";
            this.consultCorreo.Size = new System.Drawing.Size(75, 23);
            this.consultCorreo.TabIndex = 13;
            this.consultCorreo.Text = "Consultar";
            this.consultCorreo.UseVisualStyleBackColor = true;
            this.consultCorreo.Visible = false;
            this.consultCorreo.Click += new System.EventHandler(this.consultCorreo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(104, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Peru;
            this.lblFecha.Location = new System.Drawing.Point(182, 72);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFecha.Size = new System.Drawing.Size(45, 17);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "label2";
            this.lblFecha.Visible = false;
            // 
            // frecEndul
            // 
            this.frecEndul.Location = new System.Drawing.Point(113, 295);
            this.frecEndul.Name = "frecEndul";
            this.frecEndul.Size = new System.Drawing.Size(63, 20);
            this.frecEndul.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 372);
            this.Controls.Add(this.frecEndul);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.consultCorreo);
            this.Controls.Add(this.OpcionJugad);
            this.Controls.Add(this.numEndu);
            this.Controls.Add(this.numeroJugadores);
            this.Controls.Add(this.fechaIni);
            this.Controls.Add(this.lblFrec);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblFechaIn);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecEndul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblFechaIn;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblFrec;
        private System.Windows.Forms.DateTimePicker fechaIni;
        private System.Windows.Forms.NumericUpDown numeroJugadores;
        private System.Windows.Forms.NumericUpDown numEndu;
        private System.Windows.Forms.DomainUpDown OpcionJugad;
        private System.Windows.Forms.Button consultCorreo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.NumericUpDown frecEndul;
    }
}

