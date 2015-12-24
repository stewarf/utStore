namespace utStore.PagoDeuda
{
    partial class PagoDeudaForm
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
            this.PagoGroupBox = new System.Windows.Forms.GroupBox();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.DeudaActualLabel = new System.Windows.Forms.Label();
            this.DeudaMaximaLabel = new System.Windows.Forms.Label();
            this.DeudaActualValorLabel = new System.Windows.Forms.Label();
            this.DeudaMaximaValorLabel = new System.Windows.Forms.Label();
            this.PagoLabel = new System.Windows.Forms.Label();
            this.PagoTextBox = new System.Windows.Forms.TextBox();
            this.PagarButton = new System.Windows.Forms.Button();
            this.PagoTransaccionProgressBar = new System.Windows.Forms.ProgressBar();
            this.ClienteButton = new System.Windows.Forms.Button();
            this.ClienteGroupBox.SuspendLayout();
            this.PagoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClienteGroupBox
            // 
            this.ClienteGroupBox.Controls.Add(this.ClienteButton);
            this.ClienteGroupBox.Controls.Add(this.DeudaMaximaValorLabel);
            this.ClienteGroupBox.Controls.Add(this.DeudaActualValorLabel);
            this.ClienteGroupBox.Controls.Add(this.DeudaMaximaLabel);
            this.ClienteGroupBox.Controls.Add(this.DeudaActualLabel);
            this.ClienteGroupBox.Controls.Add(this.ClienteTextBox);
            this.ClienteGroupBox.Controls.Add(this.ClienteLabel);
            this.ClienteGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ClienteGroupBox.Name = "ClienteGroupBox";
            this.ClienteGroupBox.Size = new System.Drawing.Size(318, 141);
            this.ClienteGroupBox.TabIndex = 0;
            this.ClienteGroupBox.TabStop = false;
            this.ClienteGroupBox.Text = "Cliente";
            // 
            // PagoGroupBox
            // 
            this.PagoGroupBox.Controls.Add(this.PagarButton);
            this.PagoGroupBox.Controls.Add(this.PagoTextBox);
            this.PagoGroupBox.Controls.Add(this.PagoLabel);
            this.PagoGroupBox.Enabled = false;
            this.PagoGroupBox.Location = new System.Drawing.Point(12, 159);
            this.PagoGroupBox.Name = "PagoGroupBox";
            this.PagoGroupBox.Size = new System.Drawing.Size(318, 120);
            this.PagoGroupBox.TabIndex = 1;
            this.PagoGroupBox.TabStop = false;
            this.PagoGroupBox.Text = "Pago";
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Location = new System.Drawing.Point(20, 30);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(42, 13);
            this.ClienteLabel.TabIndex = 0;
            this.ClienteLabel.Text = "Cliente:";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(92, 30);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(141, 20);
            this.ClienteTextBox.TabIndex = 1;
            // 
            // DeudaActualLabel
            // 
            this.DeudaActualLabel.AutoSize = true;
            this.DeudaActualLabel.Location = new System.Drawing.Point(20, 74);
            this.DeudaActualLabel.Name = "DeudaActualLabel";
            this.DeudaActualLabel.Size = new System.Drawing.Size(75, 13);
            this.DeudaActualLabel.TabIndex = 2;
            this.DeudaActualLabel.Text = "Deuda Actual:";
            // 
            // DeudaMaximaLabel
            // 
            this.DeudaMaximaLabel.AutoSize = true;
            this.DeudaMaximaLabel.Location = new System.Drawing.Point(20, 99);
            this.DeudaMaximaLabel.Name = "DeudaMaximaLabel";
            this.DeudaMaximaLabel.Size = new System.Drawing.Size(81, 13);
            this.DeudaMaximaLabel.TabIndex = 3;
            this.DeudaMaximaLabel.Text = "Deuda Máxima:";
            // 
            // DeudaActualValorLabel
            // 
            this.DeudaActualValorLabel.AutoSize = true;
            this.DeudaActualValorLabel.Location = new System.Drawing.Point(162, 74);
            this.DeudaActualValorLabel.Name = "DeudaActualValorLabel";
            this.DeudaActualValorLabel.Size = new System.Drawing.Size(28, 13);
            this.DeudaActualValorLabel.TabIndex = 4;
            this.DeudaActualValorLabel.Text = "0.00";
            // 
            // DeudaMaximaValorLabel
            // 
            this.DeudaMaximaValorLabel.AutoSize = true;
            this.DeudaMaximaValorLabel.Location = new System.Drawing.Point(162, 99);
            this.DeudaMaximaValorLabel.Name = "DeudaMaximaValorLabel";
            this.DeudaMaximaValorLabel.Size = new System.Drawing.Size(28, 13);
            this.DeudaMaximaValorLabel.TabIndex = 5;
            this.DeudaMaximaValorLabel.Text = "0.00";
            // 
            // PagoLabel
            // 
            this.PagoLabel.AutoSize = true;
            this.PagoLabel.Location = new System.Drawing.Point(23, 38);
            this.PagoLabel.Name = "PagoLabel";
            this.PagoLabel.Size = new System.Drawing.Size(80, 13);
            this.PagoLabel.TabIndex = 0;
            this.PagoLabel.Text = "Monto a Pagar:";
            // 
            // PagoTextBox
            // 
            this.PagoTextBox.Location = new System.Drawing.Point(131, 38);
            this.PagoTextBox.Name = "PagoTextBox";
            this.PagoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PagoTextBox.Size = new System.Drawing.Size(137, 20);
            this.PagoTextBox.TabIndex = 3;
            // 
            // PagarButton
            // 
            this.PagarButton.Location = new System.Drawing.Point(131, 77);
            this.PagarButton.Name = "PagarButton";
            this.PagarButton.Size = new System.Drawing.Size(75, 23);
            this.PagarButton.TabIndex = 4;
            this.PagarButton.Text = "Aceptar";
            this.PagarButton.UseVisualStyleBackColor = true;
            this.PagarButton.Click += new System.EventHandler(this.PagarButton_Click);
            // 
            // PagoTransaccionProgressBar
            // 
            this.PagoTransaccionProgressBar.Location = new System.Drawing.Point(12, 294);
            this.PagoTransaccionProgressBar.Name = "PagoTransaccionProgressBar";
            this.PagoTransaccionProgressBar.Size = new System.Drawing.Size(318, 16);
            this.PagoTransaccionProgressBar.TabIndex = 2;
            // 
            // ClienteButton
            // 
            this.ClienteButton.Location = new System.Drawing.Point(240, 30);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(58, 23);
            this.ClienteButton.TabIndex = 2;
            this.ClienteButton.Text = "Buscar";
            this.ClienteButton.UseVisualStyleBackColor = true;
            this.ClienteButton.Click += new System.EventHandler(this.ClienteButton_Click);
            // 
            // PagoDeudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 322);
            this.Controls.Add(this.PagoTransaccionProgressBar);
            this.Controls.Add(this.PagoGroupBox);
            this.Controls.Add(this.ClienteGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagoDeudaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Deuda del Cliente";
            this.Load += new System.EventHandler(this.PagoDeudaForm_Load);
            this.ClienteGroupBox.ResumeLayout(false);
            this.ClienteGroupBox.PerformLayout();
            this.PagoGroupBox.ResumeLayout(false);
            this.PagoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ClienteGroupBox;
        private System.Windows.Forms.GroupBox PagoGroupBox;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.Label DeudaMaximaValorLabel;
        private System.Windows.Forms.Label DeudaActualValorLabel;
        private System.Windows.Forms.Label DeudaMaximaLabel;
        private System.Windows.Forms.Label DeudaActualLabel;
        private System.Windows.Forms.Button PagarButton;
        private System.Windows.Forms.TextBox PagoTextBox;
        private System.Windows.Forms.Label PagoLabel;
        private System.Windows.Forms.ProgressBar PagoTransaccionProgressBar;
        private System.Windows.Forms.Button ClienteButton;
    }
}