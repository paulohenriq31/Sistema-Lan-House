namespace controleEstoque
{
    partial class MenuInicial
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
            this.buttonVendaM = new System.Windows.Forms.Button();
            this.buttonCadastrarProdM = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVendaM
            // 
            this.buttonVendaM.Location = new System.Drawing.Point(12, 12);
            this.buttonVendaM.Name = "buttonVendaM";
            this.buttonVendaM.Size = new System.Drawing.Size(176, 118);
            this.buttonVendaM.TabIndex = 1;
            this.buttonVendaM.Text = "VENDAS";
            this.buttonVendaM.UseVisualStyleBackColor = true;
            this.buttonVendaM.Click += new System.EventHandler(this.buttonVendaM_Click);
            // 
            // buttonCadastrarProdM
            // 
            this.buttonCadastrarProdM.Location = new System.Drawing.Point(194, 12);
            this.buttonCadastrarProdM.Name = "buttonCadastrarProdM";
            this.buttonCadastrarProdM.Size = new System.Drawing.Size(176, 118);
            this.buttonCadastrarProdM.TabIndex = 1;
            this.buttonCadastrarProdM.Text = "CADASTRAR PRODUTO";
            this.buttonCadastrarProdM.UseVisualStyleBackColor = true;
            this.buttonCadastrarProdM.Click += new System.EventHandler(this.buttonCadastrarProdM_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 118);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 118);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 268);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCadastrarProdM);
            this.Controls.Add(this.buttonVendaM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVendaM;
        private System.Windows.Forms.Button buttonCadastrarProdM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}