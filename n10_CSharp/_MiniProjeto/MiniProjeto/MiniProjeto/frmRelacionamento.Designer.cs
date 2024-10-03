namespace MiniProjeto
{
    partial class frmRelacionamento
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
            this.cboNomeUsuario = new System.Windows.Forms.ComboBox();
            this.cboIDUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // cboNomeUsuario
            // 
            this.cboNomeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomeUsuario.FormattingEnabled = true;
            this.cboNomeUsuario.Location = new System.Drawing.Point(12, 42);
            this.cboNomeUsuario.Name = "cboNomeUsuario";
            this.cboNomeUsuario.Size = new System.Drawing.Size(443, 38);
            this.cboNomeUsuario.TabIndex = 1;
            // 
            // cboIDUsuario
            // 
            this.cboIDUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDUsuario.FormattingEnabled = true;
            this.cboIDUsuario.Location = new System.Drawing.Point(461, 42);
            this.cboIDUsuario.Name = "cboIDUsuario";
            this.cboIDUsuario.Size = new System.Drawing.Size(127, 38);
            this.cboIDUsuario.TabIndex = 1;
            // 
            // frmRelacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 105);
            this.Controls.Add(this.cboIDUsuario);
            this.Controls.Add(this.cboNomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRelacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelacionamento";
            this.Load += new System.EventHandler(this.frmRelacionamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboNomeUsuario;
        private ComboBox cboIDUsuario;
    }
}