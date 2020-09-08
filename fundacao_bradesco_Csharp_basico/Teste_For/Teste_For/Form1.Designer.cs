namespace Teste_For
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
            this.btnTesteFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTesteFor
            // 
            this.btnTesteFor.Location = new System.Drawing.Point(102, 159);
            this.btnTesteFor.Name = "btnTesteFor";
            this.btnTesteFor.Size = new System.Drawing.Size(75, 23);
            this.btnTesteFor.TabIndex = 0;
            this.btnTesteFor.Text = "Teste For";
            this.btnTesteFor.UseVisualStyleBackColor = true;
            this.btnTesteFor.Click += new System.EventHandler(this.btnTesteFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 261);
            this.Controls.Add(this.btnTesteFor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesteFor;
    }
}

