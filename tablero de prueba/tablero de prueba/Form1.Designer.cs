﻿namespace tablero_de_prueba
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJugad = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.numEndu = new System.Windows.Forms.TextBox();
            this.lblFrec = new System.Windows.Forms.Label();
            this.frecEndul = new System.Windows.Forms.TextBox();
            this.contJugad = new System.Windows.Forms.NumericUpDown();
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
            this.lblValorEndu = new System.Windows.Forms.Label();
            this.lblValorRega = new System.Windows.Forms.Label();
            this.valorRega = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.valorEndu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fotoGod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contJugad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoGod)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 186);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Chocolate;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Nirmala UI", 9.3F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(0, 409);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 23);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            this.lblFecha.Visible = false;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cuantos Jugadores serán?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(72, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecciona la fecha de inicio";
            // 
            // btnJugad
            // 
            this.btnJugad.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnJugad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJugad.Location = new System.Drawing.Point(155, 356);
            this.btnJugad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJugad.Name = "btnJugad";
            this.btnJugad.Size = new System.Drawing.Size(100, 28);
            this.btnJugad.TabIndex = 7;
            this.btnJugad.Text = "Guardar";
            this.btnJugad.UseVisualStyleBackColor = true;
            this.btnJugad.Click += new System.EventHandler(this.btnJugad_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Sienna;
            this.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNum.Location = new System.Drawing.Point(72, 230);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(147, 16);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "Número de endulzadas";
            // 
            // numEndu
            // 
            this.numEndu.Location = new System.Drawing.Point(76, 250);
            this.numEndu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numEndu.Name = "numEndu";
            this.numEndu.Size = new System.Drawing.Size(60, 22);
            this.numEndu.TabIndex = 9;
            // 
            // lblFrec
            // 
            this.lblFrec.AutoSize = true;
            this.lblFrec.BackColor = System.Drawing.Color.Sienna;
            this.lblFrec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrec.Location = new System.Drawing.Point(72, 278);
            this.lblFrec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrec.Name = "lblFrec";
            this.lblFrec.Size = new System.Drawing.Size(175, 16);
            this.lblFrec.TabIndex = 10;
            this.lblFrec.Text = "Cada cuantos días (Ej: 5,7,9)";
            this.lblFrec.Click += new System.EventHandler(this.label4_Click);
            // 
            // frecEndul
            // 
            this.frecEndul.Location = new System.Drawing.Point(76, 298);
            this.frecEndul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frecEndul.Name = "frecEndul";
            this.frecEndul.Size = new System.Drawing.Size(57, 22);
            this.frecEndul.TabIndex = 10;
            // 
            // contJugad
            // 
            this.contJugad.Location = new System.Drawing.Point(76, 130);
            this.contJugad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contJugad.Name = "contJugad";
            this.contJugad.Size = new System.Drawing.Size(71, 22);
            this.contJugad.TabIndex = 0;
            this.contJugad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDato1
            // 
            this.txtDato1.AutoSize = true;
            this.txtDato1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDato1.Location = new System.Drawing.Point(528, 174);
            this.txtDato1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(186, 16);
            this.txtDato1.TabIndex = 14;
            this.txtDato1.Text = "Ingrese el nombre del jugador";
            this.txtDato1.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nombre.Location = new System.Drawing.Point(532, 194);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(132, 22);
            this.Nombre.TabIndex = 15;
            this.Nombre.Visible = false;
            // 
            // txtDato2
            // 
            this.txtDato2.AutoSize = true;
            this.txtDato2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDato2.Location = new System.Drawing.Point(528, 249);
            this.txtDato2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(179, 16);
            this.txtDato2.TabIndex = 16;
            this.txtDato2.Text = "Ingrese el correo del jugador";
            this.txtDato2.Visible = false;
            // 
            // correo
            // 
            this.correo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.correo.Location = new System.Drawing.Point(532, 268);
            this.correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(132, 22);
            this.correo.TabIndex = 17;
            this.correo.Visible = false;
            // 
            // txtDato3
            // 
            this.txtDato3.AutoSize = true;
            this.txtDato3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDato3.Location = new System.Drawing.Point(528, 315);
            this.txtDato3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(236, 16);
            this.txtDato3.TabIndex = 18;
            this.txtDato3.Text = "Ingrese la endulzada ideal del jugador";
            this.txtDato3.Visible = false;
            // 
            // endulzada
            // 
            this.endulzada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endulzada.Location = new System.Drawing.Point(532, 343);
            this.endulzada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endulzada.Name = "endulzada";
            this.endulzada.Size = new System.Drawing.Size(132, 22);
            this.endulzada.TabIndex = 19;
            this.endulzada.Visible = false;
            // 
            // lblRegalo
            // 
            this.lblRegalo.AutoSize = true;
            this.lblRegalo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegalo.Location = new System.Drawing.Point(528, 379);
            this.lblRegalo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegalo.Name = "lblRegalo";
            this.lblRegalo.Size = new System.Drawing.Size(286, 16);
            this.lblRegalo.TabIndex = 20;
            this.lblRegalo.Text = "Ingrese el regalo deseado nombre del jugador";
            this.lblRegalo.Visible = false;
            // 
            // regalo
            // 
            this.regalo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regalo.Location = new System.Drawing.Point(532, 398);
            this.regalo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regalo.Name = "regalo";
            this.regalo.Size = new System.Drawing.Size(132, 22);
            this.regalo.TabIndex = 21;
            this.regalo.Visible = false;
            // 
            // btnSubir
            // 
            this.btnSubir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubir.Location = new System.Drawing.Point(548, 443);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(100, 28);
            this.btnSubir.TabIndex = 22;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Visible = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // saltar
            // 
            this.saltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saltar.Location = new System.Drawing.Point(732, 443);
            this.saltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saltar.Name = "saltar";
            this.saltar.Size = new System.Drawing.Size(100, 25);
            this.saltar.TabIndex = 23;
            this.saltar.Text = "Correos";
            this.saltar.UseVisualStyleBackColor = true;
            this.saltar.Visible = false;
            this.saltar.Click += new System.EventHandler(this.saltar_Click);
            // 
            // lblValorEndu
            // 
            this.lblValorEndu.AutoSize = true;
            this.lblValorEndu.BackColor = System.Drawing.Color.Sienna;
            this.lblValorEndu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorEndu.Location = new System.Drawing.Point(72, 322);
            this.lblValorEndu.Name = "lblValorEndu";
            this.lblValorEndu.Size = new System.Drawing.Size(138, 16);
            this.lblValorEndu.TabIndex = 25;
            this.lblValorEndu.Text = "Valor de la endulzada";
            // 
            // lblValorRega
            // 
            this.lblValorRega.AutoSize = true;
            this.lblValorRega.BackColor = System.Drawing.Color.Sienna;
            this.lblValorRega.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorRega.Location = new System.Drawing.Point(72, 378);
            this.lblValorRega.Name = "lblValorRega";
            this.lblValorRega.Size = new System.Drawing.Size(106, 16);
            this.lblValorRega.TabIndex = 26;
            this.lblValorRega.Text = "Valor del regalo ";
            // 
            // valorRega
            // 
            this.valorRega.Location = new System.Drawing.Point(76, 402);
            this.valorRega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valorRega.Name = "valorRega";
            this.valorRega.Size = new System.Drawing.Size(100, 22);
            this.valorRega.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.btnJugad);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(53, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(379, 508);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReiniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReiniciar.Location = new System.Drawing.Point(263, 356);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(100, 28);
            this.btnReiniciar.TabIndex = 8;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // valorEndu
            // 
            this.valorEndu.Location = new System.Drawing.Point(76, 341);
            this.valorEndu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valorEndu.Name = "valorEndu";
            this.valorEndu.Size = new System.Drawing.Size(100, 22);
            this.valorEndu.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(732, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fotoGod
            // 
            this.fotoGod.BackColor = System.Drawing.Color.Transparent;
            this.fotoGod.Image = ((System.Drawing.Image)(resources.GetObject("fotoGod.Image")));
            this.fotoGod.Location = new System.Drawing.Point(490, 142);
            this.fotoGod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoGod.Name = "fotoGod";
            this.fotoGod.Size = new System.Drawing.Size(375, 345);
            this.fotoGod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoGod.TabIndex = 30;
            this.fotoGod.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 594);
            this.Controls.Add(this.fotoGod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valorEndu);
            this.Controls.Add(this.valorRega);
            this.Controls.Add(this.lblValorRega);
            this.Controls.Add(this.lblValorEndu);
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
            this.Controls.Add(this.contJugad);
            this.Controls.Add(this.frecEndul);
            this.Controls.Add(this.lblFrec);
            this.Controls.Add(this.numEndu);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contJugad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoGod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJugad;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox numEndu;
        private System.Windows.Forms.Label lblFrec;
        private System.Windows.Forms.TextBox frecEndul;
        private System.Windows.Forms.NumericUpDown contJugad;
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
        private System.Windows.Forms.Label lblValorEndu;
        private System.Windows.Forms.Label lblValorRega;
        private System.Windows.Forms.TextBox valorRega;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valorEndu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.PictureBox fotoGod;
    }
}

