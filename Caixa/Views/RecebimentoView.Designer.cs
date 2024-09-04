namespace Caixa.Views
{
    partial class RecebimentoView
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
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.dgv_Recebimentos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_InserirCaixa = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.cbx_StatusRecebimento = new System.Windows.Forms.ComboBox();
            this.cbx_Caixa = new System.Windows.Forms.ComboBox();
            this.cbx_Venda = new System.Windows.Forms.ComboBox();
            this.dtp_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.dtp_Pagamento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recebimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.Aqua;
            this.btn_Atualizar.Location = new System.Drawing.Point(867, 696);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(158, 85);
            this.btn_Atualizar.TabIndex = 33;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Deletar.Location = new System.Drawing.Point(867, 489);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(158, 85);
            this.btn_Deletar.TabIndex = 32;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // dgv_Recebimentos
            // 
            this.dgv_Recebimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recebimentos.Location = new System.Drawing.Point(32, 71);
            this.dgv_Recebimentos.Name = "dgv_Recebimentos";
            this.dgv_Recebimentos.RowHeadersWidth = 62;
            this.dgv_Recebimentos.RowTemplate.Height = 28;
            this.dgv_Recebimentos.Size = new System.Drawing.Size(993, 409);
            this.dgv_Recebimentos.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Recebimento";
            // 
            // btn_InserirCaixa
            // 
            this.btn_InserirCaixa.Location = new System.Drawing.Point(-129, 394);
            this.btn_InserirCaixa.Name = "btn_InserirCaixa";
            this.btn_InserirCaixa.Size = new System.Drawing.Size(89, 39);
            this.btn_InserirCaixa.TabIndex = 29;
            this.btn_InserirCaixa.Text = "Adicionar";
            this.btn_InserirCaixa.UseVisualStyleBackColor = true;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.Lime;
            this.btn_Adicionar.Location = new System.Drawing.Point(867, 593);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(158, 85);
            this.btn_Adicionar.TabIndex = 34;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(23, 544);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(198, 26);
            this.txt_Valor.TabIndex = 35;
            // 
            // cbx_StatusRecebimento
            // 
            this.cbx_StatusRecebimento.FormattingEnabled = true;
            this.cbx_StatusRecebimento.Location = new System.Drawing.Point(268, 544);
            this.cbx_StatusRecebimento.Name = "cbx_StatusRecebimento";
            this.cbx_StatusRecebimento.Size = new System.Drawing.Size(198, 28);
            this.cbx_StatusRecebimento.TabIndex = 36;
            // 
            // cbx_Caixa
            // 
            this.cbx_Caixa.FormattingEnabled = true;
            this.cbx_Caixa.Location = new System.Drawing.Point(23, 622);
            this.cbx_Caixa.Name = "cbx_Caixa";
            this.cbx_Caixa.Size = new System.Drawing.Size(161, 28);
            this.cbx_Caixa.TabIndex = 37;
            // 
            // cbx_Venda
            // 
            this.cbx_Venda.FormattingEnabled = true;
            this.cbx_Venda.Location = new System.Drawing.Point(268, 622);
            this.cbx_Venda.Name = "cbx_Venda";
            this.cbx_Venda.Size = new System.Drawing.Size(194, 28);
            this.cbx_Venda.TabIndex = 38;
            // 
            // dtp_Vencimento
            // 
            this.dtp_Vencimento.Location = new System.Drawing.Point(508, 624);
            this.dtp_Vencimento.Name = "dtp_Vencimento";
            this.dtp_Vencimento.Size = new System.Drawing.Size(317, 26);
            this.dtp_Vencimento.TabIndex = 39;
            // 
            // dtp_Pagamento
            // 
            this.dtp_Pagamento.Location = new System.Drawing.Point(508, 542);
            this.dtp_Pagamento.Name = "dtp_Pagamento";
            this.dtp_Pagamento.Size = new System.Drawing.Size(319, 26);
            this.dtp_Pagamento.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Valor";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(556, 601);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 20);
            this.label.TabIndex = 42;
            this.label.Text = "Vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Status Recebimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Caixa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Venda";
            // 
            // RecebimentoView
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
            this.Controls.Add(this.cbx_Venda);
            this.Controls.Add(this.cbx_Caixa);
            this.Controls.Add(this.cbx_StatusRecebimento);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.dgv_Recebimentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_InserirCaixa);
            this.Name = "RecebimentoView";
            this.ShowIcon = false;
            this.Text = "Recebimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recebimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.DataGridView dgv_Recebimentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_InserirCaixa;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.ComboBox cbx_StatusRecebimento;
        private System.Windows.Forms.ComboBox cbx_Caixa;
        private System.Windows.Forms.ComboBox cbx_Venda;
        private System.Windows.Forms.DateTimePicker dtp_Vencimento;
        private System.Windows.Forms.DateTimePicker dtp_Pagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}