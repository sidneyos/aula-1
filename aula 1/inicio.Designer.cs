namespace aula_1
{
    partial class frmpropriedadescheckbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpropriedadescheckbox));
            this.chkpessoafisica = new System.Windows.Forms.CheckBox();
            this.chkpessoajuridica = new System.Windows.Forms.CheckBox();
            this.btnavancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkpessoafisica
            // 
            this.chkpessoafisica.AutoSize = true;
            this.chkpessoafisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpessoafisica.Location = new System.Drawing.Point(12, 57);
            this.chkpessoafisica.Name = "chkpessoafisica";
            this.chkpessoafisica.Size = new System.Drawing.Size(113, 21);
            this.chkpessoafisica.TabIndex = 0;
            this.chkpessoafisica.Text = "pessoa física";
            this.chkpessoafisica.UseVisualStyleBackColor = true;
            // 
            // chkpessoajuridica
            // 
            this.chkpessoajuridica.AutoSize = true;
            this.chkpessoajuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpessoajuridica.Location = new System.Drawing.Point(154, 57);
            this.chkpessoajuridica.Name = "chkpessoajuridica";
            this.chkpessoajuridica.Size = new System.Drawing.Size(125, 21);
            this.chkpessoajuridica.TabIndex = 1;
            this.chkpessoajuridica.Text = "pessoa jurídica";
            this.chkpessoajuridica.UseVisualStyleBackColor = true;
            // 
            // btnavancar
            // 
            this.btnavancar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnavancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavancar.Location = new System.Drawing.Point(76, 144);
            this.btnavancar.Name = "btnavancar";
            this.btnavancar.Size = new System.Drawing.Size(133, 54);
            this.btnavancar.TabIndex = 2;
            this.btnavancar.Text = "Avançar";
            this.btnavancar.UseVisualStyleBackColor = false;
            this.btnavancar.Click += new System.EventHandler(this.btnavancar_Click);
            // 
            // frmpropriedadescheckbox
            // 
            this.AccessibleName = "ss";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 274);
            this.Controls.Add(this.btnavancar);
            this.Controls.Add(this.chkpessoajuridica);
            this.Controls.Add(this.chkpessoafisica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpropriedadescheckbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro de clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkpessoafisica;
        private System.Windows.Forms.CheckBox chkpessoajuridica;
        private System.Windows.Forms.Button btnavancar;
    }
}

