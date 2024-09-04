namespace Caixa.Views
{
    partial class DespesaView
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
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.dgv_Despesas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Pagamento = new System.Windows.Forms.DateTimePicker();
            this.dtp_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.cbx_Fornecedores = new System.Windows.Forms.ComboBox();
            this.cbx_Caixas = new System.Windows.Forms.ComboBox();
            this.cbx_StatusDespesas = new System.Windows.Forms.ComboBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Despesas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.Lime;
            this.btn_Adicionar.Location = new System.Drawing.Point(871, 541);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(168, 90);
            this.btn_Adicionar.TabIndex = 39;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.Aqua;
            this.btn_Atualizar.Location = new System.Drawing.Point(871, 674);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(168, 90);
            this.btn_Atualizar.TabIndex = 38;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click_1);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Deletar.Location = new System.Drawing.Point(871, 415);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(168, 90);
            this.btn_Deletar.TabIndex = 37;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click_1);
            // 
            // dgv_Despesas
            // 
            this.dgv_Despesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Despesas.Location = new System.Drawing.Point(21, 51);
            this.dgv_Despesas.Name = "dgv_Despesas";
            this.dgv_Despesas.RowHeadersWidth = 62;
            this.dgv_Despesas.RowTemplate.Height = 28;
            this.dgv_Despesas.Size = new System.Drawing.Size(1018, 343);
            this.dgv_Despesas.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Despesas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Caixa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Status Despesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Pagamento";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(346, 456);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 20);
            this.label.TabIndex = 54;
            this.label.Text = "Vencimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Valor";
            // 
            // dtp_Pagamento
            // 
            this.dtp_Pagamento.Location = new System.Drawing.Point(313, 550);
            this.dtp_Pagamento.Name = "dtp_Pagamento";
            this.dtp_Pagamento.Size = new System.Drawing.Size(321, 26);
            this.dtp_Pagamento.TabIndex = 52;
            // 
            // dtp_Vencimento
            // 
            this.dtp_Vencimento.Location = new System.Drawing.Point(313, 479);
            this.dtp_Vencimento.Name = "dtp_Vencimento";
            this.dtp_Vencimento.Size = new System.Drawing.Size(321, 26);
            this.dtp_Vencimento.TabIndex = 51;
            // 
            // cbx_Fornecedores
            // 
            this.cbx_Fornecedores.FormattingEnabled = true;
            this.cbx_Fornecedores.Location = new System.Drawing.Point(313, 626);
            this.cbx_Fornecedores.Name = "cbx_Fornecedores";
            this.cbx_Fornecedores.Size = new System.Drawing.Size(231, 28);
            this.cbx_Fornecedores.TabIndex = 50;
            // 
            // cbx_Caixas
            // 
            this.cbx_Caixas.FormattingEnabled = true;
            this.cbx_Caixas.Location = new System.Drawing.Point(21, 626);
            this.cbx_Caixas.Name = "cbx_Caixas";
            this.cbx_Caixas.Size = new System.Drawing.Size(171, 28);
            this.cbx_Caixas.TabIndex = 49;
            // 
            // cbx_StatusDespesas
            // 
            this.cbx_StatusDespesas.FormattingEnabled = true;
            this.cbx_StatusDespesas.Location = new System.Drawing.Point(21, 552);
            this.cbx_StatusDespesas.Name = "cbx_StatusDespesas";
            this.cbx_StatusDespesas.Size = new System.Drawing.Size(171, 28);
            this.cbx_StatusDespesas.TabIndex = 48;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(21, 479);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(171, 26);
            this.txt_Valor.TabIndex = 47;
            // 
            // DespesaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 1024);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Pagamento);
            this.Controls.Add(this.dtp_Vencimento);
            this.Controls.Add(this.cbx_Fornecedores);
            this.Controls.Add(this.cbx_Caixas);
            this.Controls.Add(this.cbx_StatusDespesas);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.dgv_Despesas);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DespesaView";
            this.ShowIcon = false;
            this.Text = "Despesa";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Despesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.DataGridView dgv_Despesas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Pagamento;
        private System.Windows.Forms.DateTimePicker dtp_Vencimento;
        private System.Windows.Forms.ComboBox cbx_Fornecedores;
        private System.Windows.Forms.ComboBox cbx_Caixas;
        private System.Windows.Forms.ComboBox cbx_StatusDespesas;
        private System.Windows.Forms.TextBox txt_Valor;
    }
}