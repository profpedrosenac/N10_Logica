namespace VendasDaShopee
{
    partial class frmVenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.cboValor = new System.Windows.Forms.ComboBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.btoOK = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Qtde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total a Pagar";
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Items.AddRange(new object[] {
            "Ar-condicionado",
            "Aspirador robô",
            "Cafeteira elétrica",
            "Caixa de som portátil",
            "Câmera digital",
            "Console de videogame",
            "Drone",
            "Fone de ouvido Bluetooth",
            "Geladeira inteligente",
            "Impressora multifuncional",
            "Máquina de lavar",
            "Micro-ondas",
            "Monitor de computador",
            "Notebook",
            "Roteador Wi-Fi",
            "Smartphone",
            "Smartwatch",
            "Tablet",
            "TV 4K",
            "Ventilador de torre"});
            this.cboProduto.Location = new System.Drawing.Point(15, 42);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(277, 38);
            this.cboProduto.TabIndex = 0;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // cboValor
            // 
            this.cboValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboValor.Enabled = false;
            this.cboValor.FormattingEnabled = true;
            this.cboValor.Items.AddRange(new object[] {
            "R$ 2.000,00",
            "R$ 1.500,00",
            "R$ 300,00",
            "R$ 400,00",
            "R$ 2.000,00",
            "R$ 2.800,00",
            "R$ 1.800,00",
            "R$ 300,00",
            "R$ 5.000,00",
            "R$ 600,00",
            "R$ 2200,00",
            "R$ 600,00",
            "R$ 1.000,00",
            "R$ 4.000,00",
            "R$ 250,00",
            "R$ 2.500,00",
            "R$ 1.200,00",
            "R$ 1.500,00",
            "R$ 3.500,00",
            "R$ 400,00"});
            this.cboValor.Location = new System.Drawing.Point(298, 42);
            this.cboValor.Name = "cboValor";
            this.cboValor.Size = new System.Drawing.Size(252, 38);
            this.cboValor.TabIndex = 1;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(556, 42);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(198, 36);
            this.txtQtde.TabIndex = 2;
            this.txtQtde.Text = "0";
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(298, 135);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(456, 36);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "R$ 0,00";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Débito",
            "Dinheiro - Desconto 10%",
            "PIX - Desconto 5%",
            "Crédito - Juros 25%"});
            this.cboTipo.Location = new System.Drawing.Point(12, 135);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(277, 38);
            this.cboTipo.TabIndex = 3;
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Location = new System.Drawing.Point(12, 285);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.ReadOnly = true;
            this.txtTotalFinal.Size = new System.Drawing.Size(576, 36);
            this.txtTotalFinal.TabIndex = 5;
            this.txtTotalFinal.Text = "R$ 0,00";
            // 
            // btoOK
            // 
            this.btoOK.Location = new System.Drawing.Point(594, 177);
            this.btoOK.Name = "btoOK";
            this.btoOK.Size = new System.Drawing.Size(160, 44);
            this.btoOK.TabIndex = 6;
            this.btoOK.Text = "OK";
            this.btoOK.UseVisualStyleBackColor = true;
            this.btoOK.Click += new System.EventHandler(this.btoOK_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(594, 227);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(160, 44);
            this.btoLimpar.TabIndex = 7;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(594, 277);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(160, 44);
            this.btoSair.TabIndex = 8;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 330);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoOK);
            this.Controls.Add(this.txtTotalFinal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.cboValor);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboProduto;
        private ComboBox cboValor;
        private TextBox txtQtde;
        private TextBox txtTotal;
        private ComboBox cboTipo;
        private TextBox txtTotalFinal;
        private Button btoOK;
        private Button btoLimpar;
        private Button btoSair;
    }
}