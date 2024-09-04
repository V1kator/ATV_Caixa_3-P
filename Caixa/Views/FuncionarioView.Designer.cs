namespace Caixa.Views
{
    partial class FuncionarioView
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
            this.dgv_Funcionarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.Lime;
            this.btn_Adicionar.Location = new System.Drawing.Point(583, 555);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(167, 90);
            this.btn_Adicionar.TabIndex = 39;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.Aqua;
            this.btn_Atualizar.Location = new System.Drawing.Point(880, 555);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(167, 90);
            this.btn_Atualizar.TabIndex = 38;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Deletar.Location = new System.Drawing.Point(880, 416);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(167, 90);
            this.btn_Deletar.TabIndex = 37;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // dgv_Funcionarios
            // 
            this.dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funcionarios.Location = new System.Drawing.Point(31, 56);
            this.dgv_Funcionarios.Name = "dgv_Funcionarios";
            this.dgv_Funcionarios.RowHeadersWidth = 62;
            this.dgv_Funcionarios.RowTemplate.Height = 28;
            this.dgv_Funcionarios.Size = new System.Drawing.Size(1016, 349);
            this.dgv_Funcionarios.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(49, 480);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(261, 26);
            this.txt_Nome.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "CPF";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(463, 480);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(261, 26);
            this.txt_cpf.TabIndex = 44;
            // 
            // FuncionarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 694);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.dgv_Funcionarios);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FuncionarioView";
            this.ShowIcon = false;
            this.Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.DataGridView dgv_Funcionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cpf;
    }
}