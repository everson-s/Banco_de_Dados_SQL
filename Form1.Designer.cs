namespace Banco_Dados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCriar = new Button();
            btnInserir = new Button();
            btnLer = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnConsultar = new Button();
            btLimiteMedio = new Button();
            btnAtualizarExibir = new Button();
            dgvClientes = new DataGridView();
            nudLimite = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLimite).BeginInit();
            SuspendLayout();
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(12, 12);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 0;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(12, 41);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnLer
            // 
            btnLer.Location = new Point(12, 70);
            btnLer.Name = "btnLer";
            btnLer.Size = new Size(75, 23);
            btnLer.TabIndex = 2;
            btnLer.Text = "Ler";
            btnLer.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(12, 99);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(12, 128);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(12, 157);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btLimiteMedio
            // 
            btLimiteMedio.Location = new Point(12, 215);
            btLimiteMedio.Name = "btLimiteMedio";
            btLimiteMedio.Size = new Size(75, 58);
            btLimiteMedio.TabIndex = 7;
            btLimiteMedio.Text = "Consultar Limite Médio";
            btLimiteMedio.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarExibir
            // 
            btnAtualizarExibir.Location = new Point(12, 279);
            btnAtualizarExibir.Name = "btnAtualizarExibir";
            btnAtualizarExibir.Size = new Size(75, 62);
            btnAtualizarExibir.TabIndex = 8;
            btnAtualizarExibir.Text = "Atualizar e Exibir";
            btnAtualizarExibir.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(93, 14);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(695, 327);
            dgvClientes.TabIndex = 9;
            // 
            // nudLimite
            // 
            nudLimite.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudLimite.Location = new Point(12, 186);
            nudLimite.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudLimite.Name = "nudLimite";
            nudLimite.Size = new Size(74, 23);
            nudLimite.TabIndex = 10;
            nudLimite.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 352);
            Controls.Add(nudLimite);
            Controls.Add(dgvClientes);
            Controls.Add(btnAtualizarExibir);
            Controls.Add(btLimiteMedio);
            Controls.Add(btnConsultar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLer);
            Controls.Add(btnInserir);
            Controls.Add(btnCriar);
            Name = "Form1";
            Text = "Manipulador de Banco de Dados";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLimite).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCriar;
        private Button btnInserir;
        private Button btnLer;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnConsultar;
        private Button btLimiteMedio;
        private Button btnAtualizarExibir;
        private DataGridView dgvClientes;
        private NumericUpDown nudLimite;
    }
}
