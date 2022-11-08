namespace AulaKatia11
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
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.btnferias = new System.Windows.Forms.Button();
            this.btninss = new System.Windows.Forms.Button();
            this.btnComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(56, 48);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(58, 18);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo de serviço(meses):";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(404, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(140, 112);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(404, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(272, 182);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(272, 20);
            this.txtTempo.TabIndex = 5;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(64, 253);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(58, 18);
            this.lblvalor.TabIndex = 6;
            this.lblvalor.Text = "Nome:";
            // 
            // btnferias
            // 
            this.btnferias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnferias.Location = new System.Drawing.Point(59, 317);
            this.btnferias.Name = "btnferias";
            this.btnferias.Size = new System.Drawing.Size(156, 53);
            this.btnferias.TabIndex = 7;
            this.btnferias.Text = "Calcular férias ";
            this.btnferias.UseVisualStyleBackColor = true;
            this.btnferias.Click += new System.EventHandler(this.btnferias_Click);
            // 
            // btninss
            // 
            this.btninss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninss.Location = new System.Drawing.Point(221, 317);
            this.btninss.Name = "btninss";
            this.btninss.Size = new System.Drawing.Size(167, 53);
            this.btninss.TabIndex = 8;
            this.btninss.Text = "Calcular INSS";
            this.btninss.UseVisualStyleBackColor = true;
            this.btninss.Click += new System.EventHandler(this.btninss_Click);
            // 
            // btnComissao
            // 
            this.btnComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComissao.Location = new System.Drawing.Point(394, 317);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(150, 53);
            this.btnComissao.TabIndex = 9;
            this.btnComissao.Text = "Calcular comissao";
            this.btnComissao.UseVisualStyleBackColor = true;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.btninss);
            this.Controls.Add(this.btnferias);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button btnferias;
        private System.Windows.Forms.Button btninss;
        private System.Windows.Forms.Button btnComissao;
    }
}

