namespace calculadora
{
    partial class frmCalculadora
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
            this.btoMais = new System.Windows.Forms.Button();
            this.btoMenos = new System.Windows.Forms.Button();
            this.btoMult = new System.Windows.Forms.Button();
            this.btoDiv = new System.Windows.Forms.Button();
            this.btoCE = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "N2";
            // 
            // btoMais
            // 
            this.btoMais.Location = new System.Drawing.Point(12, 90);
            this.btoMais.Name = "btoMais";
            this.btoMais.Size = new System.Drawing.Size(62, 41);
            this.btoMais.TabIndex = 2;
            this.btoMais.Text = "+";
            this.btoMais.UseVisualStyleBackColor = true;
            this.btoMais.Click += new System.EventHandler(this.btoMais_Click);
            // 
            // btoMenos
            // 
            this.btoMenos.Location = new System.Drawing.Point(80, 90);
            this.btoMenos.Name = "btoMenos";
            this.btoMenos.Size = new System.Drawing.Size(62, 41);
            this.btoMenos.TabIndex = 3;
            this.btoMenos.Text = "-";
            this.btoMenos.UseVisualStyleBackColor = true;
            this.btoMenos.Click += new System.EventHandler(this.btoMenos_Click);
            // 
            // btoMult
            // 
            this.btoMult.Location = new System.Drawing.Point(148, 90);
            this.btoMult.Name = "btoMult";
            this.btoMult.Size = new System.Drawing.Size(62, 41);
            this.btoMult.TabIndex = 4;
            this.btoMult.Text = "x";
            this.btoMult.UseVisualStyleBackColor = true;
            this.btoMult.Click += new System.EventHandler(this.btoMult_Click);
            // 
            // btoDiv
            // 
            this.btoDiv.Location = new System.Drawing.Point(216, 90);
            this.btoDiv.Name = "btoDiv";
            this.btoDiv.Size = new System.Drawing.Size(62, 41);
            this.btoDiv.TabIndex = 5;
            this.btoDiv.Text = ":";
            this.btoDiv.UseVisualStyleBackColor = true;
            this.btoDiv.Click += new System.EventHandler(this.btoDiv_Click);
            // 
            // btoCE
            // 
            this.btoCE.Location = new System.Drawing.Point(12, 137);
            this.btoCE.Name = "btoCE";
            this.btoCE.Size = new System.Drawing.Size(130, 41);
            this.btoCE.TabIndex = 6;
            this.btoCE.Text = "CE";
            this.btoCE.UseVisualStyleBackColor = true;
            this.btoCE.Click += new System.EventHandler(this.btoCE_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(148, 137);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(130, 41);
            this.btoSair.TabIndex = 7;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 42);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(130, 36);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(148, 42);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(130, 36);
            this.txtN2.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(12, 181);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(266, 56);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 247);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoCE);
            this.Controls.Add(this.btoDiv);
            this.Controls.Add(this.btoMult);
            this.Controls.Add(this.btoMenos);
            this.Controls.Add(this.btoMais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btoMais;
        private Button btoMenos;
        private Button btoMult;
        private Button btoDiv;
        private Button btoCE;
        private Button btoSair;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label lblResult;
    }
}