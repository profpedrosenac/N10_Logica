namespace calculadora
{
    partial class frmMedia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(37, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "n1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "n2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "n3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "n4";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 42);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 36);
            this.txtN1.TabIndex = 0;
            this.txtN1.Enter += new System.EventHandler(this.txtN1_Enter);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(118, 42);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 36);
            this.txtN2.TabIndex = 1;
            this.txtN2.Enter += new System.EventHandler(this.txtN2_Enter);
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(224, 42);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 36);
            this.txtN3.TabIndex = 2;
            this.txtN3.Enter += new System.EventHandler(this.txtN3_Enter);
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(330, 42);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(100, 36);
            this.txtN4.TabIndex = 3;
            this.txtN4.Enter += new System.EventHandler(this.txtN4_Enter);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(12, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(418, 125);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "-";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btoOK
            // 
            this.btoOK.Location = new System.Drawing.Point(436, 86);
            this.btoOK.Name = "btoOK";
            this.btoOK.Size = new System.Drawing.Size(111, 36);
            this.btoOK.TabIndex = 4;
            this.btoOK.Text = "OK";
            this.btoOK.UseVisualStyleBackColor = true;
            this.btoOK.Click += new System.EventHandler(this.btoOK_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(436, 128);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(111, 36);
            this.btoLimpar.TabIndex = 5;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(436, 170);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(111, 36);
            this.btoSair.TabIndex = 6;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 220);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoOK);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtN3;
        private TextBox txtN4;
        private Label lblResult;
        private Button btoOK;
        private Button btoLimpar;
        private Button btoSair;
    }
}