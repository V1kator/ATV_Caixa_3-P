namespace Caixa.Views
{
    partial class CaixaView
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
            this.cbx_StatusCaixa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Funcionario = new System.Windows.Forms.ComboBox();
            this.lb_Funcionario = new System.Windows.Forms.Label();
            this.btn_InserirCaixa = new System.Windows.Forms.Button();
            this.txt_TotalSaidas = new System.Windows.Forms.TextBox();
            this.lb_TotalSaidas = new System.Windows.Forms.Label();
            this.txt_TotalEntradas = new System.Windows.Forms.TextBox();
            this.lb_TotalEntradas = new System.Windows.Forms.Label();
            this.txt_SaldoInicial = new System.Windows.Forms.TextBox();
            this.lb_SaldoInicial = new System.Windows.Forms.Label();
            this.dgv_Caixas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_AtualizarCaixa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Caixas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_StatusCaixa
            // 
            this.cbx_StatusCaixa.FormattingEnabled = true;
            this.cbx_StatusCaixa.Location = new System.Drawing.Point(626, 633);
            this.cbx_StatusCaixa.Name = "cbx_StatusCaixa";
            this.cbx_StatusCaixa.Size = new System.Drawing.Size(169, 28);
            this.cbx_StatusCaixa.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Status do Caixa";
            // 
            // cbx_Funcionario
            // 
            this.cbx_Funcionario.FormattingEnabled = true;
            this.cbx_Funcionario.Location = new System.Drawing.Point(847, 635);
            this.cbx_Funcionario.Name = "cbx_Funcionario";
            this.cbx_Funcionario.Size = new System.Drawing.Size(193, 28);
            this.cbx_Funcionario.TabIndex = 19;
            // 
            // lb_Funcionario
            // 
            this.lb_Funcionario.AutoSize = true;
            this.lb_Funcionario.Location = new System.Drawing.Point(852, 603);
            this.lb_Funcionario.Name = "lb_Funcionario";
            this.lb_Funcionario.Size = new System.Drawing.Size(188, 20);
            this.lb_Funcionario.TabIndex = 18;
            this.lb_Funcionario.Text = "Funcionario Responsável";
            // 
            // btn_InserirCaixa
            // 
            this.btn_InserirCaixa.BackColor = System.Drawing.Color.Lime;
            this.btn_InserirCaixa.Location = new System.Drawing.Point(218, 691);
            this.btn_InserirCaixa.Name = "btn_InserirCaixa";
            this.btn_InserirCaixa.Size = new System.Drawing.Size(155, 74);
            this.btn_InserirCaixa.TabIndex = 17;
            this.btn_InserirCaixa.Text = "Adicionar";
            this.btn_InserirCaixa.UseVisualStyleBackColor = false;
            this.btn_InserirCaixa.Click += new System.EventHandler(this.btn_InserirCaixa_Click);
            // 
            // txt_TotalSaidas
            // 
            this.txt_TotalSaidas.Location = new System.Drawing.Point(417, 635);
            this.txt_TotalSaidas.Name = "txt_TotalSaidas";
            this.txt_TotalSaidas.Size = new System.Drawing.Size(151, 26);
            this.txt_TotalSaidas.TabIndex = 16;
            // 
            // lb_TotalSaidas
            // 
            this.lb_TotalSaidas.AutoSize = true;
            this.lb_TotalSaidas.Location = new System.Drawing.Point(440, 603);
            this.lb_TotalSaidas.Name = "lb_TotalSaidas";
            this.lb_TotalSaidas.Size = new System.Drawing.Size(97, 20);
            this.lb_TotalSaidas.TabIndex = 15;
            this.lb_TotalSaidas.Text = "Total Saidas";
            // 
            // txt_TotalEntradas
            // 
            this.txt_TotalEntradas.Location = new System.Drawing.Point(224, 635);
            this.txt_TotalEntradas.Name = "txt_TotalEntradas";
            this.txt_TotalEntradas.Size = new System.Drawing.Size(149, 26);
            this.txt_TotalEntradas.TabIndex = 14;
            // 
            // lb_TotalEntradas
            // 
            this.lb_TotalEntradas.AutoSize = true;
            this.lb_TotalEntradas.Location = new System.Drawing.Point(240, 603);
            this.lb_TotalEntradas.Name = "lb_TotalEntradas";
            this.lb_TotalEntradas.Size = new System.Drawing.Size(113, 20);
            this.lb_TotalEntradas.TabIndex = 13;
            this.lb_TotalEntradas.Text = "Total Entradas";
            // 
            // txt_SaldoInicial
            // 
            this.txt_SaldoInicial.Location = new System.Drawing.Point(29, 635);
            this.txt_SaldoInicial.Name = "txt_SaldoInicial";
            this.txt_SaldoInicial.Size = new System.Drawing.Size(152, 26);
            this.txt_SaldoInicial.TabIndex = 12;
            // 
            // lb_SaldoInicial
            // 
            this.lb_SaldoInicial.AutoSize = true;
            this.lb_SaldoInicial.Location = new System.Drawing.Point(60, 603);
            this.lb_SaldoInicial.Name = "lb_SaldoInicial";
            this.lb_SaldoInicial.Size = new System.Drawing.Size(94, 20);
            this.lb_SaldoInicial.TabIndex = 11;
            this.lb_SaldoInicial.Text = "Saldo Inicial";
            // 
            // dgv_Caixas
            // 
            this.dgv_Caixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Caixas.Location = new System.Drawing.Point(29, 58);
            this.dgv_Caixas.Name = "dgv_Caixas";
            this.dgv_Caixas.RowHeadersWidth = 62;
            this.dgv_Caixas.RowTemplate.Height = 28;
            this.dgv_Caixas.Size = new System.Drawing.Size(1011, 437);
            this.dgv_Caixas.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Caixas";
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Deletar.Location = new System.Drawing.Point(929, 512);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(87, 42);
            this.btn_Deletar.TabIndex = 27;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_AtualizarCaixa
            // 
            this.btn_AtualizarCaixa.BackColor = System.Drawing.Color.Aqua;
            this.btn_AtualizarCaixa.Location = new System.Drawing.Point(626, 691);
            this.btn_AtualizarCaixa.Name = "btn_AtualizarCaixa";
            this.btn_AtualizarCaixa.Size = new System.Drawing.Size(155, 74);
            this.btn_AtualizarCaixa.TabIndex = 28;
            this.btn_AtualizarCaixa.Text = "Atualizar";
            this.btn_AtualizarCaixa.UseVisualStyleBackColor = false;
            this.btn_AtualizarCaixa.Click += new System.EventHandler(this.btn_AtualizarCaixa_Click_1);
            // 
            // CaixaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 1024);
            this.Controls.Add(this.btn_AtualizarCaixa);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.dgv_Caixas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_StatusCaixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Funcionario);
            this.Controls.Add(this.lb_Funcionario);
            this.Controls.Add(this.btn_InserirCaixa);
            this.Controls.Add(this.txt_TotalSaidas);
            this.Controls.Add(this.lb_TotalSaidas);
            this.Controls.Add(this.txt_TotalEntradas);
            this.Controls.Add(this.lb_TotalEntradas);
            this.Controls.Add(this.txt_SaldoInicial);
            this.Controls.Add(this.lb_SaldoInicial);
            this.Name = "CaixaView";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Caixas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_StatusCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Funcionario;
        private System.Windows.Forms.Label lb_Funcionario;
        private System.Windows.Forms.Button btn_InserirCaixa;
        private System.Windows.Forms.TextBox txt_TotalSaidas;
        private System.Windows.Forms.Label lb_TotalSaidas;
        private System.Windows.Forms.TextBox txt_TotalEntradas;
        private System.Windows.Forms.Label lb_TotalEntradas;
        private System.Windows.Forms.TextBox txt_SaldoInicial;
        private System.Windows.Forms.Label lb_SaldoInicial;
        private System.Windows.Forms.DataGridView dgv_Caixas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_AtualizarCaixa;
    }
}