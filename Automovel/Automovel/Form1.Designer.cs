namespace Automovel
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
            this.textBoxDistancia = new System.Windows.Forms.TextBox();
            this.textBoxCombustivel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMedia = new System.Windows.Forms.ListBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDistancia
            // 
            this.textBoxDistancia.Location = new System.Drawing.Point(209, 90);
            this.textBoxDistancia.Name = "textBoxDistancia";
            this.textBoxDistancia.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistancia.TabIndex = 0;
            // 
            // textBoxCombustivel
            // 
            this.textBoxCombustivel.Location = new System.Drawing.Point(434, 90);
            this.textBoxCombustivel.Name = "textBoxCombustivel";
            this.textBoxCombustivel.Size = new System.Drawing.Size(100, 20);
            this.textBoxCombustivel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distancia total percorrida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total de combustivel gasto";
            // 
            // listBoxMedia
            // 
            this.listBoxMedia.FormattingEnabled = true;
            this.listBoxMedia.Location = new System.Drawing.Point(277, 190);
            this.listBoxMedia.Name = "listBoxMedia";
            this.listBoxMedia.Size = new System.Drawing.Size(186, 147);
            this.listBoxMedia.TabIndex = 4;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(308, 145);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(129, 39);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.listBoxMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCombustivel);
            this.Controls.Add(this.textBoxDistancia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDistancia;
        private System.Windows.Forms.TextBox textBoxCombustivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMedia;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

