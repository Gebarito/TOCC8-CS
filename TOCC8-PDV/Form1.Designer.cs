namespace TOCC8_PDV
{
    partial class FMain
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
            this.txtPrazoValidade = new System.Windows.Forms.TextBox();
            this.lblPrazoValidade = new System.Windows.Forms.Label();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.txtTaxaLucro = new System.Windows.Forms.TextBox();
            this.lblTaxaLucro = new System.Windows.Forms.Label();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrazoValidade
            // 
            this.txtPrazoValidade.Location = new System.Drawing.Point(349, 392);
            this.txtPrazoValidade.Name = "txtPrazoValidade";
            this.txtPrazoValidade.ReadOnly = true;
            this.txtPrazoValidade.Size = new System.Drawing.Size(88, 20);
            this.txtPrazoValidade.TabIndex = 39;
            // 
            // lblPrazoValidade
            // 
            this.lblPrazoValidade.AutoSize = true;
            this.lblPrazoValidade.Location = new System.Drawing.Point(346, 376);
            this.lblPrazoValidade.Name = "lblPrazoValidade";
            this.lblPrazoValidade.Size = new System.Drawing.Size(76, 13);
            this.lblPrazoValidade.TabIndex = 38;
            this.lblPrazoValidade.Text = "Prazo em dias:";
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(669, 376);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(100, 127);
            this.btnGrafico.TabIndex = 37;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // txtTaxaLucro
            // 
            this.txtTaxaLucro.Location = new System.Drawing.Point(12, 483);
            this.txtTaxaLucro.Name = "txtTaxaLucro";
            this.txtTaxaLucro.Size = new System.Drawing.Size(88, 20);
            this.txtTaxaLucro.TabIndex = 36;
            // 
            // lblTaxaLucro
            // 
            this.lblTaxaLucro.AutoSize = true;
            this.lblTaxaLucro.Location = new System.Drawing.Point(9, 467);
            this.lblTaxaLucro.Name = "lblTaxaLucro";
            this.lblTaxaLucro.Size = new System.Drawing.Size(64, 13);
            this.lblTaxaLucro.TabIndex = 35;
            this.lblTaxaLucro.Text = "Taxa Lucro:";
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Location = new System.Drawing.Point(128, 392);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(212, 20);
            this.dtpDataValidade.TabIndex = 34;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Location = new System.Drawing.Point(125, 376);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(92, 13);
            this.lblDataValidade.TabIndex = 33;
            this.lblDataValidade.Text = "Data de Validade:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(128, 436);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(212, 67);
            this.txtDescricao.TabIndex = 32;
            this.txtDescricao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyUp);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(125, 420);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 31;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(12, 436);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(88, 20);
            this.txtPreco.TabIndex = 30;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(9, 420);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 29;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 376);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 28;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 392);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 20);
            this.txtCodigo.TabIndex = 27;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.Location = new System.Drawing.Point(563, 444);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 59);
            this.btnRemover.TabIndex = 26;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(563, 376);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 59);
            this.btnListar.TabIndex = 25;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(457, 444);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 59);
            this.btnAtualizar.TabIndex = 24;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(457, 376);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 59);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(12, 52);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(757, 321);
            this.dgvProduto.TabIndex = 20;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(268, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 31);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "TOCC8 - Produtos";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 507);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPrazoValidade);
            this.Controls.Add(this.lblPrazoValidade);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.txtTaxaLucro);
            this.Controls.Add(this.lblTaxaLucro);
            this.Controls.Add(this.dtpDataValidade);
            this.Controls.Add(this.lblDataValidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvProduto);
            this.Name = "FMain";
            this.Text = "TOCC8 - Tela de Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrazoValidade;
        private System.Windows.Forms.Label lblPrazoValidade;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.TextBox txtTaxaLucro;
        private System.Windows.Forms.Label lblTaxaLucro;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label lblTitulo;
    }
}

