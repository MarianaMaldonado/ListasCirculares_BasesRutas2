namespace ListasCirculares_BasesRuta2
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
            this.lblNombreBase = new System.Windows.Forms.Label();
            this.txtNuevaBase = new System.Windows.Forms.TextBox();
            this.txtMinutosBaseAnterior = new System.Windows.Forms.TextBox();
            this.lblMinutosBaseAnt = new System.Windows.Forms.Label();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarInicio = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblBaseNuevaInsertar = new System.Windows.Forms.Label();
            this.txtPosicionBaseNuevaInsertar = new System.Windows.Forms.TextBox();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.txtBaseName = new System.Windows.Forms.TextBox();
            this.lblBaseName = new System.Windows.Forms.Label();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreBase
            // 
            this.lblNombreBase.AutoSize = true;
            this.lblNombreBase.Location = new System.Drawing.Point(1, 19);
            this.lblNombreBase.Name = "lblNombreBase";
            this.lblNombreBase.Size = new System.Drawing.Size(65, 13);
            this.lblNombreBase.TabIndex = 0;
            this.lblNombreBase.Text = "Nueva base";
            // 
            // txtNuevaBase
            // 
            this.txtNuevaBase.Location = new System.Drawing.Point(72, 16);
            this.txtNuevaBase.Name = "txtNuevaBase";
            this.txtNuevaBase.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaBase.TabIndex = 1;
            // 
            // txtMinutosBaseAnterior
            // 
            this.txtMinutosBaseAnterior.Location = new System.Drawing.Point(297, 25);
            this.txtMinutosBaseAnterior.Name = "txtMinutosBaseAnterior";
            this.txtMinutosBaseAnterior.Size = new System.Drawing.Size(100, 20);
            this.txtMinutosBaseAnterior.TabIndex = 3;
            // 
            // lblMinutosBaseAnt
            // 
            this.lblMinutosBaseAnt.AutoSize = true;
            this.lblMinutosBaseAnt.Location = new System.Drawing.Point(245, 9);
            this.lblMinutosBaseAnt.Name = "lblMinutosBaseAnt";
            this.lblMinutosBaseAnt.Size = new System.Drawing.Size(204, 13);
            this.lblMinutosBaseAnt.TabIndex = 2;
            this.lblMinutosBaseAnt.Text = "Ingrese los minutos desde la base anterior\r\n";
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(182, 78);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(174, 170);
            this.txtInformacion.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(104, 297);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(386, 155);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(75, 23);
            this.btnInformacion.TabIndex = 6;
            this.btnInformacion.Text = "Información";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(72, 163);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(94, 20);
            this.dtpHoraFin.TabIndex = 7;
            this.dtpHoraFin.TabStop = false;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(72, 137);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(94, 20);
            this.dtpHoraInicio.TabIndex = 8;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(7, 137);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(57, 13);
            this.lblHoraInicio.TabIndex = 9;
            this.lblHoraInicio.Text = "Hora inicio";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(21, 165);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(44, 13);
            this.lblHoraFin.TabIndex = 10;
            this.lblHoraFin.Text = "Hora fin";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(322, 297);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(413, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarInicio
            // 
            this.btnEliminarInicio.Location = new System.Drawing.Point(99, 373);
            this.btnEliminarInicio.Name = "btnEliminarInicio";
            this.btnEliminarInicio.Size = new System.Drawing.Size(89, 23);
            this.btnEliminarInicio.TabIndex = 13;
            this.btnEliminarInicio.Text = "Eliminar inicio";
            this.btnEliminarInicio.UseVisualStyleBackColor = true;
            this.btnEliminarInicio.Click += new System.EventHandler(this.btnEliminarInicio_Click);
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.Location = new System.Drawing.Point(413, 373);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(89, 23);
            this.btnEliminarUltimo.TabIndex = 14;
            this.btnEliminarUltimo.Text = "Eliminar ultimo\r\n";
            this.btnEliminarUltimo.UseVisualStyleBackColor = true;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(198, 431);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblBaseNuevaInsertar
            // 
            this.lblBaseNuevaInsertar.AutoSize = true;
            this.lblBaseNuevaInsertar.Location = new System.Drawing.Point(21, 475);
            this.lblBaseNuevaInsertar.Name = "lblBaseNuevaInsertar";
            this.lblBaseNuevaInsertar.Size = new System.Drawing.Size(167, 13);
            this.lblBaseNuevaInsertar.TabIndex = 16;
            this.lblBaseNuevaInsertar.Text = "Posición de base nueva a insertar";
            // 
            // txtPosicionBaseNuevaInsertar
            // 
            this.txtPosicionBaseNuevaInsertar.Location = new System.Drawing.Point(44, 502);
            this.txtPosicionBaseNuevaInsertar.Name = "txtPosicionBaseNuevaInsertar";
            this.txtPosicionBaseNuevaInsertar.Size = new System.Drawing.Size(100, 20);
            this.txtPosicionBaseNuevaInsertar.TabIndex = 17;
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Location = new System.Drawing.Point(193, 297);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarInicio.TabIndex = 20;
            this.btnAgregarInicio.Text = "Agregar en inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // txtBaseName
            // 
            this.txtBaseName.Location = new System.Drawing.Point(76, 99);
            this.txtBaseName.Name = "txtBaseName";
            this.txtBaseName.Size = new System.Drawing.Size(100, 20);
            this.txtBaseName.TabIndex = 22;
            // 
            // lblBaseName
            // 
            this.lblBaseName.AutoSize = true;
            this.lblBaseName.Location = new System.Drawing.Point(5, 102);
            this.lblBaseName.Name = "lblBaseName";
            this.lblBaseName.Size = new System.Drawing.Size(70, 13);
            this.lblBaseName.TabIndex = 21;
            this.lblBaseName.Text = "Nombre base";
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.Location = new System.Drawing.Point(56, 206);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrido.TabIndex = 23;
            this.btnRecorrido.Text = "Recorrido";
            this.btnRecorrido.UseVisualStyleBackColor = true;
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 546);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.txtBaseName);
            this.Controls.Add(this.lblBaseName);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.txtPosicionBaseNuevaInsertar);
            this.Controls.Add(this.lblBaseNuevaInsertar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.btnEliminarInicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.txtMinutosBaseAnterior);
            this.Controls.Add(this.lblMinutosBaseAnt);
            this.Controls.Add(this.txtNuevaBase);
            this.Controls.Add(this.lblNombreBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreBase;
        private System.Windows.Forms.TextBox txtNuevaBase;
        private System.Windows.Forms.TextBox txtMinutosBaseAnterior;
        private System.Windows.Forms.Label lblMinutosBaseAnt;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarInicio;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblBaseNuevaInsertar;
        private System.Windows.Forms.TextBox txtPosicionBaseNuevaInsertar;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.TextBox txtBaseName;
        private System.Windows.Forms.Label lblBaseName;
        private System.Windows.Forms.Button btnRecorrido;
    }
}

