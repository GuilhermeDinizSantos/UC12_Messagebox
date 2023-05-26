namespace UC12_Messagebox
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
            this.buttonMESSAGEBOX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMESSAGEBOX
            // 
            this.buttonMESSAGEBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMESSAGEBOX.Location = new System.Drawing.Point(13, 13);
            this.buttonMESSAGEBOX.Name = "buttonMESSAGEBOX";
            this.buttonMESSAGEBOX.Size = new System.Drawing.Size(775, 425);
            this.buttonMESSAGEBOX.TabIndex = 0;
            this.buttonMESSAGEBOX.Text = "MessageBox";
            this.buttonMESSAGEBOX.UseVisualStyleBackColor = true;
            this.buttonMESSAGEBOX.Click += new System.EventHandler(this.buttonMESSAGEBOX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMESSAGEBOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMESSAGEBOX;
    }
}

