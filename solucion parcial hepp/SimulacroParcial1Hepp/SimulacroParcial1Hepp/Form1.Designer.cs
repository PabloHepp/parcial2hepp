namespace SimulacroParcial1Hepp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.txbCtacte = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbCuenta = new System.Windows.Forms.CheckBox();
            this.lbxTurnos = new System.Windows.Forms.ListBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnExportarTicket = new System.Windows.Forms.Button();
            this.btnImportarCuenta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.rbCompras = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Turnos";
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(135, 25);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(183, 20);
            this.txbDNI.TabIndex = 1;
            // 
            // txbCtacte
            // 
            this.txbCtacte.Location = new System.Drawing.Point(107, 25);
            this.txbCtacte.Name = "txbCtacte";
            this.txbCtacte.Size = new System.Drawing.Size(183, 20);
            this.txbCtacte.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbCuenta);
            this.groupBox1.Controls.Add(this.txbCtacte);
            this.groupBox1.Location = new System.Drawing.Point(28, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ckbCuenta
            // 
            this.ckbCuenta.AutoSize = true;
            this.ckbCuenta.Location = new System.Drawing.Point(6, 28);
            this.ckbCuenta.Name = "ckbCuenta";
            this.ckbCuenta.Size = new System.Drawing.Size(93, 17);
            this.ckbCuenta.TabIndex = 0;
            this.ckbCuenta.Text = "NroCuentaCte";
            this.ckbCuenta.UseVisualStyleBackColor = true;
            // 
            // lbxTurnos
            // 
            this.lbxTurnos.FormattingEnabled = true;
            this.lbxTurnos.Location = new System.Drawing.Point(28, 172);
            this.lbxTurnos.Name = "lbxTurnos";
            this.lbxTurnos.Size = new System.Drawing.Size(310, 186);
            this.lbxTurnos.TabIndex = 3;
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(201, 388);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(137, 40);
            this.btnAtender.TabIndex = 4;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(370, 96);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 23);
            this.btnTicket.TabIndex = 4;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExportarTicket
            // 
            this.btnExportarTicket.Location = new System.Drawing.Point(370, 191);
            this.btnExportarTicket.Name = "btnExportarTicket";
            this.btnExportarTicket.Size = new System.Drawing.Size(75, 58);
            this.btnExportarTicket.TabIndex = 4;
            this.btnExportarTicket.Text = "Exportar Ticket";
            this.btnExportarTicket.UseVisualStyleBackColor = true;
            this.btnExportarTicket.Click += new System.EventHandler(this.btnExportarTicket_Click);
            // 
            // btnImportarCuenta
            // 
            this.btnImportarCuenta.Location = new System.Drawing.Point(370, 279);
            this.btnImportarCuenta.Name = "btnImportarCuenta";
            this.btnImportarCuenta.Size = new System.Drawing.Size(75, 57);
            this.btnImportarCuenta.TabIndex = 4;
            this.btnImportarCuenta.Text = "Importar Cuentas Corrientes";
            this.btnImportarCuenta.UseVisualStyleBackColor = true;
            this.btnImportarCuenta.Click += new System.EventHandler(this.btnImportarCuenta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPagos);
            this.groupBox2.Controls.Add(this.rbCompras);
            this.groupBox2.Location = new System.Drawing.Point(28, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 61);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.Location = new System.Drawing.Point(7, 38);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(55, 17);
            this.rbPagos.TabIndex = 1;
            this.rbPagos.TabStop = true;
            this.rbPagos.Text = "Pagos";
            this.rbPagos.UseVisualStyleBackColor = true;
            // 
            // rbCompras
            // 
            this.rbCompras.AutoSize = true;
            this.rbCompras.Location = new System.Drawing.Point(7, 9);
            this.rbCompras.Name = "rbCompras";
            this.rbCompras.Size = new System.Drawing.Size(66, 17);
            this.rbCompras.TabIndex = 0;
            this.rbCompras.TabStop = true;
            this.rbCompras.Text = "Compras";
            this.rbCompras.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnImportarCuenta);
            this.Controls.Add(this.btnExportarTicket);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lbxTurnos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCtacte;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox ckbCuenta;
        public System.Windows.Forms.Button btnTicket;
        public System.Windows.Forms.Button btnImportarCuenta;
        public System.Windows.Forms.Button btnExportarTicket;
        public System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton rbCompras;
        public System.Windows.Forms.RadioButton rbPagos;
        public System.Windows.Forms.ListBox lbxTurnos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox txbDNI;
    }
}

