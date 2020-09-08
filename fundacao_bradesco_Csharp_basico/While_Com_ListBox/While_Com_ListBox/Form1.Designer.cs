namespace While_Com_ListBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblWhile = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(47, 61);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 95);
            this.listBox.TabIndex = 0;
            // 
            // lblWhile
            // 
            this.lblWhile.AutoSize = true;
            this.lblWhile.Location = new System.Drawing.Point(65, 26);
            this.lblWhile.Name = "lblWhile";
            this.lblWhile.Size = new System.Drawing.Size(34, 13);
            this.lblWhile.TabIndex = 1;
            this.lblWhile.Text = "While";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(47, 211);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(120, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 263);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblWhile);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblWhile;
        private System.Windows.Forms.Button btnVerificar;
    }
}

