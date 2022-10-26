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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblNroRepuesto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lstMarca = new System.Windows.Forms.ComboBox();
            this.lstOrigen = new System.Windows.Forms.ComboBox();
            this.txtNroRepuesto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mrcRepuestroRegistro.SuspendLayout();
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
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 31);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
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
            // lblNroRepuesto
            // 
            this.lblNroRepuesto.AutoSize = true;
            this.lblNroRepuesto.Location = new System.Drawing.Point(6, 118);
            this.lblNroRepuesto.Name = "lblNroRepuesto";
            this.lblNroRepuesto.Size = new System.Drawing.Size(68, 13);
            this.lblNroRepuesto.TabIndex = 2;
            this.lblNroRepuesto.Text = "Nº Repuesto";
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
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 206);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
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
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(119, 283);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
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
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 380);
            this.Controls.Add(this.mrcRepuestroRegistro);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.mrcRepuestroRegistro.ResumeLayout(false);
            this.mrcRepuestroRegistro.PerformLayout();
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
    }
}

