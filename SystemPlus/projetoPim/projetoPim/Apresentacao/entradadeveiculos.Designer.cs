namespace projetoPim.Apresentacao
{
    partial class EntradaDeVeiculos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblENTRADADEVEICULOS = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gpIndentificação = new System.Windows.Forms.GroupBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.txbObservação = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblObservação = new System.Windows.Forms.Label();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpIndentificação.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblENTRADADEVEICULOS);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 37);
            this.splitContainer1.SplitterDistance = 632;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblENTRADADEVEICULOS
            // 
            this.lblENTRADADEVEICULOS.AutoSize = true;
            this.lblENTRADADEVEICULOS.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblENTRADADEVEICULOS.Location = new System.Drawing.Point(4, 4);
            this.lblENTRADADEVEICULOS.Name = "lblENTRADADEVEICULOS";
            this.lblENTRADADEVEICULOS.Size = new System.Drawing.Size(350, 31);
            this.lblENTRADADEVEICULOS.TabIndex = 0;
            this.lblENTRADADEVEICULOS.Text = "ENTRADA DE VEICULOS";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // gpIndentificação
            // 
            this.gpIndentificação.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpIndentificação.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpIndentificação.Controls.Add(this.txbCliente);
            this.gpIndentificação.Controls.Add(this.txbObservação);
            this.gpIndentificação.Controls.Add(this.lblCliente);
            this.gpIndentificação.Controls.Add(this.lblObservação);
            this.gpIndentificação.Controls.Add(this.txbPlaca);
            this.gpIndentificação.Controls.Add(this.lblPlaca);
            this.gpIndentificação.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpIndentificação.Location = new System.Drawing.Point(12, 62);
            this.gpIndentificação.Name = "gpIndentificação";
            this.gpIndentificação.Size = new System.Drawing.Size(451, 209);
            this.gpIndentificação.TabIndex = 1;
            this.gpIndentificação.TabStop = false;
            this.gpIndentificação.Text = "Indentificação";
            // 
            // txbCliente
            // 
            this.txbCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliente.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.Location = new System.Drawing.Point(89, 178);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(136, 23);
            this.txbCliente.TabIndex = 5;
            // 
            // txbObservação
            // 
            this.txbObservação.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbObservação.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbObservação.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservação.Location = new System.Drawing.Point(89, 144);
            this.txbObservação.Name = "txbObservação";
            this.txbObservação.Size = new System.Drawing.Size(202, 23);
            this.txbObservação.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(10, 186);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // lblObservação
            // 
            this.lblObservação.AutoSize = true;
            this.lblObservação.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservação.Location = new System.Drawing.Point(10, 152);
            this.lblObservação.Name = "lblObservação";
            this.lblObservação.Size = new System.Drawing.Size(72, 15);
            this.lblObservação.TabIndex = 2;
            this.lblObservação.Text = "Observação";
            // 
            // txbPlaca
            // 
            this.txbPlaca.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlaca.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlaca.Location = new System.Drawing.Point(73, 30);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(152, 26);
            this.txbPlaca.TabIndex = 1;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(6, 30);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(61, 24);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(713, 373);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 101);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(836, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(117, 101);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // EntradaDeVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1030, 479);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpIndentificação);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntradaDeVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "entradadeveiculos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpIndentificação.ResumeLayout(false);
            this.gpIndentificação.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gpIndentificação;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblENTRADADEVEICULOS;
        private System.Windows.Forms.TextBox txbObservação;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblObservação;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSair;
    }
}