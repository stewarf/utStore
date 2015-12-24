namespace utStore.Facturacion
{
    partial class FacturarForm
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
            this.ClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.ClienteBuscarButton = new System.Windows.Forms.Button();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.DeudaMaximaValorLabel = new System.Windows.Forms.Label();
            this.DeudaActualValorLabel = new System.Windows.Forms.Label();
            this.DeudaMaximaLabel = new System.Windows.Forms.Label();
            this.DeudaActualLabel = new System.Windows.Forms.Label();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.FacturaTransaccionProgressBar = new System.Windows.Forms.ProgressBar();
            this.ArticuloGroupBox = new System.Windows.Forms.GroupBox();
            this.ArticuloBuscarButton = new System.Windows.Forms.Button();
            this.ArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.ArticuloExistenciasValorLabel = new System.Windows.Forms.Label();
            this.ArticuloPrecioSugeridoValorLabel = new System.Windows.Forms.Label();
            this.ArticuloExistenciasLabel = new System.Windows.Forms.Label();
            this.ArticuloPrecioSugeridoLabel = new System.Windows.Forms.Label();
            this.ArticuloLabel = new System.Windows.Forms.Label();
            this.FacturaGroupBox = new System.Windows.Forms.GroupBox();
            this.EmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.EmpleadoLabel = new System.Windows.Forms.Label();
            this.ArticuloCantidadTextBox = new System.Windows.Forms.TextBox();
            this.ArticuloCantidadLabel = new System.Windows.Forms.Label();
            this.FacturaButton = new System.Windows.Forms.Button();
            this.ClienteGroupBox.SuspendLayout();
            this.ArticuloGroupBox.SuspendLayout();
            this.FacturaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClienteGroupBox
            // 
            this.ClienteGroupBox.Controls.Add(this.ClienteBuscarButton);
            this.ClienteGroupBox.Controls.Add(this.ClienteComboBox);
            this.ClienteGroupBox.Controls.Add(this.DeudaMaximaValorLabel);
            this.ClienteGroupBox.Controls.Add(this.DeudaActualValorLabel);
            this.ClienteGroupBox.Controls.Add(this.DeudaMaximaLabel);
            this.ClienteGroupBox.Controls.Add(this.DeudaActualLabel);
            this.ClienteGroupBox.Controls.Add(this.ClienteLabel);
            this.ClienteGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ClienteGroupBox.Name = "ClienteGroupBox";
            this.ClienteGroupBox.Size = new System.Drawing.Size(375, 133);
            this.ClienteGroupBox.TabIndex = 0;
            this.ClienteGroupBox.TabStop = false;
            this.ClienteGroupBox.Text = "Información del Cliente";
            // 
            // ClienteBuscarButton
            // 
            this.ClienteBuscarButton.Location = new System.Drawing.Point(294, 32);
            this.ClienteBuscarButton.Name = "ClienteBuscarButton";
            this.ClienteBuscarButton.Size = new System.Drawing.Size(75, 23);
            this.ClienteBuscarButton.TabIndex = 5;
            this.ClienteBuscarButton.Text = "Seleccionar";
            this.ClienteBuscarButton.UseVisualStyleBackColor = true;
            this.ClienteBuscarButton.Click += new System.EventHandler(this.ClienteBuscarButton_Click);
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(166, 32);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClienteComboBox.TabIndex = 1;
            // 
            // DeudaMaximaValorLabel
            // 
            this.DeudaMaximaValorLabel.AutoSize = true;
            this.DeudaMaximaValorLabel.Location = new System.Drawing.Point(235, 97);
            this.DeudaMaximaValorLabel.Name = "DeudaMaximaValorLabel";
            this.DeudaMaximaValorLabel.Size = new System.Drawing.Size(28, 13);
            this.DeudaMaximaValorLabel.TabIndex = 4;
            this.DeudaMaximaValorLabel.Text = "0.00";
            // 
            // DeudaActualValorLabel
            // 
            this.DeudaActualValorLabel.AutoSize = true;
            this.DeudaActualValorLabel.Location = new System.Drawing.Point(235, 64);
            this.DeudaActualValorLabel.Name = "DeudaActualValorLabel";
            this.DeudaActualValorLabel.Size = new System.Drawing.Size(28, 13);
            this.DeudaActualValorLabel.TabIndex = 3;
            this.DeudaActualValorLabel.Text = "0.00";
            // 
            // DeudaMaximaLabel
            // 
            this.DeudaMaximaLabel.AutoSize = true;
            this.DeudaMaximaLabel.Location = new System.Drawing.Point(21, 97);
            this.DeudaMaximaLabel.Name = "DeudaMaximaLabel";
            this.DeudaMaximaLabel.Size = new System.Drawing.Size(81, 13);
            this.DeudaMaximaLabel.TabIndex = 2;
            this.DeudaMaximaLabel.Text = "Deuda Máxima:";
            // 
            // DeudaActualLabel
            // 
            this.DeudaActualLabel.AutoSize = true;
            this.DeudaActualLabel.Location = new System.Drawing.Point(21, 64);
            this.DeudaActualLabel.Name = "DeudaActualLabel";
            this.DeudaActualLabel.Size = new System.Drawing.Size(75, 13);
            this.DeudaActualLabel.TabIndex = 1;
            this.DeudaActualLabel.Text = "Deuda Actual:";
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Location = new System.Drawing.Point(21, 32);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(42, 13);
            this.ClienteLabel.TabIndex = 0;
            this.ClienteLabel.Text = "Cliente:";
            // 
            // FacturaTransaccionProgressBar
            // 
            this.FacturaTransaccionProgressBar.Location = new System.Drawing.Point(11, 421);
            this.FacturaTransaccionProgressBar.Name = "FacturaTransaccionProgressBar";
            this.FacturaTransaccionProgressBar.Size = new System.Drawing.Size(376, 20);
            this.FacturaTransaccionProgressBar.TabIndex = 1;
            // 
            // ArticuloGroupBox
            // 
            this.ArticuloGroupBox.Controls.Add(this.ArticuloBuscarButton);
            this.ArticuloGroupBox.Controls.Add(this.ArticuloComboBox);
            this.ArticuloGroupBox.Controls.Add(this.ArticuloExistenciasValorLabel);
            this.ArticuloGroupBox.Controls.Add(this.ArticuloPrecioSugeridoValorLabel);
            this.ArticuloGroupBox.Controls.Add(this.ArticuloExistenciasLabel);
            this.ArticuloGroupBox.Controls.Add(this.ArticuloPrecioSugeridoLabel);
            this.ArticuloGroupBox.Controls.Add(this.ArticuloLabel);
            this.ArticuloGroupBox.Location = new System.Drawing.Point(12, 151);
            this.ArticuloGroupBox.Name = "ArticuloGroupBox";
            this.ArticuloGroupBox.Size = new System.Drawing.Size(375, 114);
            this.ArticuloGroupBox.TabIndex = 2;
            this.ArticuloGroupBox.TabStop = false;
            this.ArticuloGroupBox.Text = "Información del Artículo";
            // 
            // ArticuloBuscarButton
            // 
            this.ArticuloBuscarButton.Location = new System.Drawing.Point(294, 25);
            this.ArticuloBuscarButton.Name = "ArticuloBuscarButton";
            this.ArticuloBuscarButton.Size = new System.Drawing.Size(75, 23);
            this.ArticuloBuscarButton.TabIndex = 5;
            this.ArticuloBuscarButton.Text = "Seleccionar";
            this.ArticuloBuscarButton.UseVisualStyleBackColor = true;
            this.ArticuloBuscarButton.Click += new System.EventHandler(this.ArticuloBuscarButton_Click);
            // 
            // ArticuloComboBox
            // 
            this.ArticuloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArticuloComboBox.FormattingEnabled = true;
            this.ArticuloComboBox.Location = new System.Drawing.Point(166, 26);
            this.ArticuloComboBox.Name = "ArticuloComboBox";
            this.ArticuloComboBox.Size = new System.Drawing.Size(121, 21);
            this.ArticuloComboBox.TabIndex = 2;
            // 
            // ArticuloExistenciasValorLabel
            // 
            this.ArticuloExistenciasValorLabel.AutoSize = true;
            this.ArticuloExistenciasValorLabel.Location = new System.Drawing.Point(250, 83);
            this.ArticuloExistenciasValorLabel.Name = "ArticuloExistenciasValorLabel";
            this.ArticuloExistenciasValorLabel.Size = new System.Drawing.Size(13, 13);
            this.ArticuloExistenciasValorLabel.TabIndex = 4;
            this.ArticuloExistenciasValorLabel.Text = "0";
            // 
            // ArticuloPrecioSugeridoValorLabel
            // 
            this.ArticuloPrecioSugeridoValorLabel.AutoSize = true;
            this.ArticuloPrecioSugeridoValorLabel.Location = new System.Drawing.Point(235, 58);
            this.ArticuloPrecioSugeridoValorLabel.Name = "ArticuloPrecioSugeridoValorLabel";
            this.ArticuloPrecioSugeridoValorLabel.Size = new System.Drawing.Size(28, 13);
            this.ArticuloPrecioSugeridoValorLabel.TabIndex = 3;
            this.ArticuloPrecioSugeridoValorLabel.Text = "0.00";
            // 
            // ArticuloExistenciasLabel
            // 
            this.ArticuloExistenciasLabel.AutoSize = true;
            this.ArticuloExistenciasLabel.Location = new System.Drawing.Point(21, 83);
            this.ArticuloExistenciasLabel.Name = "ArticuloExistenciasLabel";
            this.ArticuloExistenciasLabel.Size = new System.Drawing.Size(63, 13);
            this.ArticuloExistenciasLabel.TabIndex = 2;
            this.ArticuloExistenciasLabel.Text = "Existencias:";
            // 
            // ArticuloPrecioSugeridoLabel
            // 
            this.ArticuloPrecioSugeridoLabel.AutoSize = true;
            this.ArticuloPrecioSugeridoLabel.Location = new System.Drawing.Point(21, 58);
            this.ArticuloPrecioSugeridoLabel.Name = "ArticuloPrecioSugeridoLabel";
            this.ArticuloPrecioSugeridoLabel.Size = new System.Drawing.Size(83, 13);
            this.ArticuloPrecioSugeridoLabel.TabIndex = 1;
            this.ArticuloPrecioSugeridoLabel.Text = "Precio sugerido:";
            // 
            // ArticuloLabel
            // 
            this.ArticuloLabel.AutoSize = true;
            this.ArticuloLabel.Location = new System.Drawing.Point(21, 29);
            this.ArticuloLabel.Name = "ArticuloLabel";
            this.ArticuloLabel.Size = new System.Drawing.Size(47, 13);
            this.ArticuloLabel.TabIndex = 0;
            this.ArticuloLabel.Text = "Artículo:";
            // 
            // FacturaGroupBox
            // 
            this.FacturaGroupBox.Controls.Add(this.EmpleadoComboBox);
            this.FacturaGroupBox.Controls.Add(this.EmpleadoLabel);
            this.FacturaGroupBox.Controls.Add(this.ArticuloCantidadTextBox);
            this.FacturaGroupBox.Controls.Add(this.ArticuloCantidadLabel);
            this.FacturaGroupBox.Location = new System.Drawing.Point(13, 272);
            this.FacturaGroupBox.Name = "FacturaGroupBox";
            this.FacturaGroupBox.Size = new System.Drawing.Size(374, 100);
            this.FacturaGroupBox.TabIndex = 3;
            this.FacturaGroupBox.TabStop = false;
            this.FacturaGroupBox.Text = "Facturación";
            // 
            // EmpleadoComboBox
            // 
            this.EmpleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpleadoComboBox.FormattingEnabled = true;
            this.EmpleadoComboBox.Location = new System.Drawing.Point(165, 58);
            this.EmpleadoComboBox.Name = "EmpleadoComboBox";
            this.EmpleadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmpleadoComboBox.TabIndex = 4;
            // 
            // EmpleadoLabel
            // 
            this.EmpleadoLabel.AutoSize = true;
            this.EmpleadoLabel.Location = new System.Drawing.Point(23, 61);
            this.EmpleadoLabel.Name = "EmpleadoLabel";
            this.EmpleadoLabel.Size = new System.Drawing.Size(57, 13);
            this.EmpleadoLabel.TabIndex = 2;
            this.EmpleadoLabel.Text = "Empleado:";
            // 
            // ArticuloCantidadTextBox
            // 
            this.ArticuloCantidadTextBox.Location = new System.Drawing.Point(165, 31);
            this.ArticuloCantidadTextBox.Name = "ArticuloCantidadTextBox";
            this.ArticuloCantidadTextBox.Size = new System.Drawing.Size(121, 20);
            this.ArticuloCantidadTextBox.TabIndex = 3;
            // 
            // ArticuloCantidadLabel
            // 
            this.ArticuloCantidadLabel.AutoSize = true;
            this.ArticuloCantidadLabel.Location = new System.Drawing.Point(23, 31);
            this.ArticuloCantidadLabel.Name = "ArticuloCantidadLabel";
            this.ArticuloCantidadLabel.Size = new System.Drawing.Size(106, 13);
            this.ArticuloCantidadLabel.TabIndex = 0;
            this.ArticuloCantidadLabel.Text = "Cantidad de artículo:";
            // 
            // FacturaButton
            // 
            this.FacturaButton.Location = new System.Drawing.Point(178, 378);
            this.FacturaButton.Name = "FacturaButton";
            this.FacturaButton.Size = new System.Drawing.Size(75, 23);
            this.FacturaButton.TabIndex = 4;
            this.FacturaButton.Text = "Facturar";
            this.FacturaButton.UseVisualStyleBackColor = true;
            this.FacturaButton.Click += new System.EventHandler(this.FacturaButton_Click);
            // 
            // FacturarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 453);
            this.Controls.Add(this.FacturaButton);
            this.Controls.Add(this.FacturaGroupBox);
            this.Controls.Add(this.ArticuloGroupBox);
            this.Controls.Add(this.FacturaTransaccionProgressBar);
            this.Controls.Add(this.ClienteGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacturarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación de Artículos";
            this.Load += new System.EventHandler(this.FacturarForm_Load);
            this.ClienteGroupBox.ResumeLayout(false);
            this.ClienteGroupBox.PerformLayout();
            this.ArticuloGroupBox.ResumeLayout(false);
            this.ArticuloGroupBox.PerformLayout();
            this.FacturaGroupBox.ResumeLayout(false);
            this.FacturaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ClienteGroupBox;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.ProgressBar FacturaTransaccionProgressBar;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.Label DeudaMaximaValorLabel;
        private System.Windows.Forms.Label DeudaActualValorLabel;
        private System.Windows.Forms.Label DeudaMaximaLabel;
        private System.Windows.Forms.Label DeudaActualLabel;
        private System.Windows.Forms.GroupBox ArticuloGroupBox;
        private System.Windows.Forms.ComboBox ArticuloComboBox;
        private System.Windows.Forms.Label ArticuloExistenciasValorLabel;
        private System.Windows.Forms.Label ArticuloPrecioSugeridoValorLabel;
        private System.Windows.Forms.Label ArticuloExistenciasLabel;
        private System.Windows.Forms.Label ArticuloPrecioSugeridoLabel;
        private System.Windows.Forms.Label ArticuloLabel;
        private System.Windows.Forms.GroupBox FacturaGroupBox;
        private System.Windows.Forms.TextBox ArticuloCantidadTextBox;
        private System.Windows.Forms.Label ArticuloCantidadLabel;
        private System.Windows.Forms.ComboBox EmpleadoComboBox;
        private System.Windows.Forms.Label EmpleadoLabel;
        private System.Windows.Forms.Button FacturaButton;
        private System.Windows.Forms.Button ClienteBuscarButton;
        private System.Windows.Forms.Button ArticuloBuscarButton;
    }
}