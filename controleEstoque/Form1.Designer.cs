namespace controleEstoque
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCadastrarProd = new System.Windows.Forms.Button();
            this.numericQuantC = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(94, 27);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(189, 20);
            this.txtProduto.TabIndex = 0;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(94, 53);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(189, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(198, 105);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(85, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(303, 79);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 46);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MARCA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "QUANTIDADE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PREÇO:";
            // 
            // buttonCadastrarProd
            // 
            this.buttonCadastrarProd.Location = new System.Drawing.Point(303, 27);
            this.buttonCadastrarProd.Name = "buttonCadastrarProd";
            this.buttonCadastrarProd.Size = new System.Drawing.Size(83, 46);
            this.buttonCadastrarProd.TabIndex = 9;
            this.buttonCadastrarProd.Text = "Cadastrar Produtos";
            this.buttonCadastrarProd.UseVisualStyleBackColor = true;
            this.buttonCadastrarProd.Click += new System.EventHandler(this.buttonCadastrarProd_Click);
            // 
            // numericQuantC
            // 
            this.numericQuantC.Enabled = false;
            this.numericQuantC.Location = new System.Drawing.Point(198, 79);
            this.numericQuantC.Name = "numericQuantC";
            this.numericQuantC.Size = new System.Drawing.Size(85, 20);
            this.numericQuantC.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 155);
            this.Controls.Add(this.numericQuantC);
            this.Controls.Add(this.buttonCadastrarProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtProduto);
            this.Name = "Form1";
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCadastrarProd;
        private System.Windows.Forms.NumericUpDown numericQuantC;
    }
}

