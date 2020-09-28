namespace projetoPim.Apresentacao
{
    partial class Veiculos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalvar);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditar);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(982, 483);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCor);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.cbModelo);
            this.groupBox1.Controls.Add(this.lblCor);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblPlaca);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(493, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veiculos";
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Ambar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta"});
            this.cbCor.Location = new System.Drawing.Point(27, 241);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(344, 32);
            this.cbCor.TabIndex = 7;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Volkwagen",
            "Ford",
            "Renault",
            "Hyundai",
            "Toyota",
            "Honda",
            "Citroen"});
            this.cbMarca.Location = new System.Drawing.Point(27, 179);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(302, 32);
            this.cbMarca.TabIndex = 6;
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Corsa",
            "Celta",
            "Onix",
            "Prima",
            "Captiva",
            "Classic",
            "Vectra",
            "Cobalt",
            "Agile",
            "Punto",
            "Siena",
            "Uno",
            "Palio",
            "Mobi",
            "Toro",
            "Starda",
            "Ideia",
            "Weekend",
            "Gol",
            "Fox",
            "Up",
            "Saveiro",
            "Voyagem",
            "Fusca",
            "Focus",
            "Ecosport",
            "Fiesta",
            "Ka",
            "Sandero",
            "Logan",
            "Clio",
            "Duster",
            "Kwid",
            "Captur",
            "Hb20",
            "I30",
            "Tucson",
            "Corolla kilux",
            "Etios",
            "Fit",
            "Civic",
            "Hr-v",
            "C3",
            "A3",
            "Renegade",
            "207",
            "Kicks",
            "March"});
            this.cbModelo.Location = new System.Drawing.Point(27, 117);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(247, 32);
            this.cbModelo.TabIndex = 5;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(23, 214);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(44, 24);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "Cor";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(23, 152);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(69, 24);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(23, 90);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(77, 24);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 32);
            this.textBox1.TabIndex = 1;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(23, 28);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(61, 24);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 277);
            this.listBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(372, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 77);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(282, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 77);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(193, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 77);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(103, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 77);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Novo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 532);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Veiculos";
            this.Text = "Veiculos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
    }
}