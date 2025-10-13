namespace ProjetoGames
{
    partial class Menu
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
            this.lblValorJogo = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.txtValorJogo = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.cmbTiposJogos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblValorJogo
            // 
            this.lblValorJogo.AutoSize = true;
            this.lblValorJogo.Location = new System.Drawing.Point(12, 46);
            this.lblValorJogo.Name = "lblValorJogo";
            this.lblValorJogo.Size = new System.Drawing.Size(94, 13);
            this.lblValorJogo.TabIndex = 0;
            this.lblValorJogo.Text = "VALOR DO JOGO";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(178, 46);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 1;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(384, 46);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 2;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            this.lblValorPagar.Click += new System.EventHandler(this.lblValorPagar_Click);
            // 
            // txtValorJogo
            // 
            this.txtValorJogo.Location = new System.Drawing.Point(15, 80);
            this.txtValorJogo.Name = "txtValorJogo";
            this.txtValorJogo.Size = new System.Drawing.Size(100, 20);
            this.txtValorJogo.TabIndex = 3;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(181, 80);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 4;
            this.txtValorOpcionais.TextChanged += new System.EventHandler(this.txtValorOpcionais_TextChanged);
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(387, 80);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 5;
            // 
            // cmbTiposJogos
            // 
            this.cmbTiposJogos.FormattingEnabled = true;
            this.cmbTiposJogos.Location = new System.Drawing.Point(545, 79);
            this.cmbTiposJogos.Name = "cmbTiposJogos";
            this.cmbTiposJogos.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposJogos.TabIndex = 6;
            this.cmbTiposJogos.Text = "TIPOS DE JOGOS";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 648);
            this.Controls.Add(this.cmbTiposJogos);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorJogo);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.lblValorJogo);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorJogo;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.TextBox txtValorJogo;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.ComboBox cmbTiposJogos;
    }
}

