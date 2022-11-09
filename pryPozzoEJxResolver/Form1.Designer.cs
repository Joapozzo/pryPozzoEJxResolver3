namespace pryPozzoEJxResolver
{
    partial class frmInicio
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
            this.mrcRepuestroRegistro = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNroRepuesto = new System.Windows.Forms.TextBox();
            this.lstOrigen = new System.Windows.Forms.ComboBox();
            this.lstMarca = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNroRepuesto = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaConsulta = new System.Windows.Forms.Label();
            this.lstMarcaConsulta = new System.Windows.Forms.ComboBox();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.lisDatos = new System.Windows.Forms.ListBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblDatosRepuestos = new System.Windows.Forms.Label();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.lblOrigenConsulta = new System.Windows.Forms.Label();
            this.mrcRepuestroRegistro.SuspendLayout();
            this.mrcConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRepuestroRegistro
            // 
            this.mrcRepuestroRegistro.Controls.Add(this.btnCancelar);
            this.mrcRepuestroRegistro.Controls.Add(this.btnRegistrar);
            this.mrcRepuestroRegistro.Controls.Add(this.txtPrecio);
            this.mrcRepuestroRegistro.Controls.Add(this.txtDescripcion);
            this.mrcRepuestroRegistro.Controls.Add(this.txtNroRepuesto);
            this.mrcRepuestroRegistro.Controls.Add(this.lstOrigen);
            this.mrcRepuestroRegistro.Controls.Add(this.lstMarca);
            this.mrcRepuestroRegistro.Controls.Add(this.lblPrecio);
            this.mrcRepuestroRegistro.Controls.Add(this.lblDescripcion);
            this.mrcRepuestroRegistro.Controls.Add(this.lblNroRepuesto);
            this.mrcRepuestroRegistro.Controls.Add(this.lblOrigen);
            this.mrcRepuestroRegistro.Controls.Add(this.lblMarca);
            this.mrcRepuestroRegistro.Location = new System.Drawing.Point(12, 12);
            this.mrcRepuestroRegistro.Name = "mrcRepuestroRegistro";
            this.mrcRepuestroRegistro.Size = new System.Drawing.Size(260, 356);
            this.mrcRepuestroRegistro.TabIndex = 0;
            this.mrcRepuestroRegistro.TabStop = false;
            this.mrcRepuestroRegistro.Text = "Repuesto - Registro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(38, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(119, 283);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(73, 203);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(73, 159);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtNroRepuesto
            // 
            this.txtNroRepuesto.Enabled = false;
            this.txtNroRepuesto.Location = new System.Drawing.Point(73, 115);
            this.txtNroRepuesto.MaxLength = 6;
            this.txtNroRepuesto.Name = "txtNroRepuesto";
            this.txtNroRepuesto.Size = new System.Drawing.Size(100, 20);
            this.txtNroRepuesto.TabIndex = 7;
            this.txtNroRepuesto.TextChanged += new System.EventHandler(this.txtNroRepuesto_TextChanged);
            this.txtNroRepuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroRepuesto_KeyPress);
            // 
            // lstOrigen
            // 
            this.lstOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstOrigen.Enabled = false;
            this.lstOrigen.FormattingEnabled = true;
            this.lstOrigen.Items.AddRange(new object[] {
            "Nacional",
            "Importado"});
            this.lstOrigen.Location = new System.Drawing.Point(73, 70);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.Size = new System.Drawing.Size(121, 21);
            this.lstOrigen.TabIndex = 6;
            this.lstOrigen.SelectedIndexChanged += new System.EventHandler(this.lstOrigen_SelectedIndexChanged);
            // 
            // lstMarca
            // 
            this.lstMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMarca.FormattingEnabled = true;
            this.lstMarca.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.lstMarca.Location = new System.Drawing.Point(73, 28);
            this.lstMarca.Name = "lstMarca";
            this.lstMarca.Size = new System.Drawing.Size(121, 21);
            this.lstMarca.TabIndex = 5;
            this.lstMarca.SelectedIndexChanged += new System.EventHandler(this.lstMarca_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 206);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 162);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNroRepuesto
            // 
            this.lblNroRepuesto.AutoSize = true;
            this.lblNroRepuesto.Location = new System.Drawing.Point(6, 118);
            this.lblNroRepuesto.Name = "lblNroRepuesto";
            this.lblNroRepuesto.Size = new System.Drawing.Size(68, 13);
            this.lblNroRepuesto.TabIndex = 2;
            this.lblNroRepuesto.Text = "Nº Repuesto";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 73);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 31);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblMarcaConsulta
            // 
            this.lblMarcaConsulta.AutoSize = true;
            this.lblMarcaConsulta.Location = new System.Drawing.Point(6, 31);
            this.lblMarcaConsulta.Name = "lblMarcaConsulta";
            this.lblMarcaConsulta.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaConsulta.TabIndex = 0;
            this.lblMarcaConsulta.Text = "Marca";
            // 
            // lstMarcaConsulta
            // 
            this.lstMarcaConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMarcaConsulta.FormattingEnabled = true;
            this.lstMarcaConsulta.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.lstMarcaConsulta.Location = new System.Drawing.Point(96, 28);
            this.lstMarcaConsulta.Name = "lstMarcaConsulta";
            this.lstMarcaConsulta.Size = new System.Drawing.Size(121, 21);
            this.lstMarcaConsulta.TabIndex = 5;
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.lisDatos);
            this.mrcConsulta.Controls.Add(this.btnConsultar);
            this.mrcConsulta.Controls.Add(this.lblDatosRepuestos);
            this.mrcConsulta.Controls.Add(this.optImportado);
            this.mrcConsulta.Controls.Add(this.optNacional);
            this.mrcConsulta.Controls.Add(this.lblOrigenConsulta);
            this.mrcConsulta.Controls.Add(this.lstMarcaConsulta);
            this.mrcConsulta.Controls.Add(this.lblMarcaConsulta);
            this.mrcConsulta.Location = new System.Drawing.Point(292, 12);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Size = new System.Drawing.Size(292, 356);
            this.mrcConsulta.TabIndex = 12;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta";
            // 
            // lisDatos
            // 
            this.lisDatos.FormattingEnabled = true;
            this.lisDatos.Location = new System.Drawing.Point(95, 139);
            this.lisDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lisDatos.Name = "lisDatos";
            this.lisDatos.Size = new System.Drawing.Size(193, 147);
            this.lisDatos.TabIndex = 13;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Location = new System.Drawing.Point(212, 319);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblDatosRepuestos
            // 
            this.lblDatosRepuestos.AutoSize = true;
            this.lblDatosRepuestos.Location = new System.Drawing.Point(6, 139);
            this.lblDatosRepuestos.Name = "lblDatosRepuestos";
            this.lblDatosRepuestos.Size = new System.Drawing.Size(89, 13);
            this.lblDatosRepuestos.TabIndex = 16;
            this.lblDatosRepuestos.Text = "Datos Repuestos";
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(96, 103);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 13;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(96, 70);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 14;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // lblOrigenConsulta
            // 
            this.lblOrigenConsulta.AutoSize = true;
            this.lblOrigenConsulta.Location = new System.Drawing.Point(4, 70);
            this.lblOrigenConsulta.Name = "lblOrigenConsulta";
            this.lblOrigenConsulta.Size = new System.Drawing.Size(38, 13);
            this.lblOrigenConsulta.TabIndex = 6;
            this.lblOrigenConsulta.Text = "Origen";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 403);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.mrcRepuestroRegistro);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.mrcRepuestroRegistro.ResumeLayout(false);
            this.mrcRepuestroRegistro.PerformLayout();
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRepuestroRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNroRepuesto;
        private System.Windows.Forms.ComboBox lstOrigen;
        private System.Windows.Forms.ComboBox lstMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNroRepuesto;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaConsulta;
        private System.Windows.Forms.ComboBox lstMarcaConsulta;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.Label lblOrigenConsulta;
        private System.Windows.Forms.Label lblDatosRepuestos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListBox lisDatos;
    }
}

