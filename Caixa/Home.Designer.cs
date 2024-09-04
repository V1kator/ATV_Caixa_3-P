namespace Caixa
{
    partial class Home
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
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnRecebimento = new System.Windows.Forms.Button();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.Gold;
            this.btnCaixa.Location = new System.Drawing.Point(96, 94);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(155, 73);
            this.btnCaixa.TabIndex = 0;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnRecebimento
            // 
            this.btnRecebimento.BackColor = System.Drawing.Color.Lime;
            this.btnRecebimento.Location = new System.Drawing.Point(497, 263);
            this.btnRecebimento.Name = "btnRecebimento";
            this.btnRecebimento.Size = new System.Drawing.Size(155, 82);
            this.btnRecebimento.TabIndex = 1;
            this.btnRecebimento.Text = "Recebimento";
            this.btnRecebimento.UseVisualStyleBackColor = false;
            this.btnRecebimento.Click += new System.EventHandler(this.btnRecebimento_Click);
            // 
            // btnDespesa
            // 
            this.btnDespesa.BackColor = System.Drawing.Color.Red;
            this.btnDespesa.Location = new System.Drawing.Point(497, 94);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(155, 81);
            this.btnDespesa.TabIndex = 2;
            this.btnDespesa.Text = "Despesa";
            this.btnDespesa.UseVisualStyleBackColor = false;
            this.btnDespesa.Click += new System.EventHandler(this.btnDespesa_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFuncionario.Location = new System.Drawing.Point(96, 263);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(155, 73);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnDespesa);
            this.Controls.Add(this.btnRecebimento);
            this.Controls.Add(this.btnCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.ShowIcon = false;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnRecebimento;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Button btnFuncionario;
    }
}

