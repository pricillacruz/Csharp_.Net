namespace Array_multi
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
            this.btnArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(23, 58);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(134, 52);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "Array Multidimensional";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 168);
            this.Controls.Add(this.btnArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
    }
}

