namespace crime
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
            this.lblPergunta1 = new System.Windows.Forms.Label();
            this.lblPergunta2 = new System.Windows.Forms.Label();
            this.lblPergunta3 = new System.Windows.Forms.Label();
            this.lblPergunta4 = new System.Windows.Forms.Label();
            this.lblPergunta5 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.AutoSize = true;
            this.lblPergunta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta1.Location = new System.Drawing.Point(88, 85);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(206, 20);
            this.lblPergunta1.TabIndex = 1;
            this.lblPergunta1.Text = "Telefonou para a vítima?";
            // 
            // lblPergunta2
            // 
            this.lblPergunta2.AutoSize = true;
            this.lblPergunta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta2.Location = new System.Drawing.Point(86, 119);
            this.lblPergunta2.Name = "lblPergunta2";
            this.lblPergunta2.Size = new System.Drawing.Size(214, 20);
            this.lblPergunta2.TabIndex = 2;
            this.lblPergunta2.Text = "Esteve no local do crime?";
            // 
            // lblPergunta3
            // 
            this.lblPergunta3.AutoSize = true;
            this.lblPergunta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta3.Location = new System.Drawing.Point(98, 154);
            this.lblPergunta3.Name = "lblPergunta3";
            this.lblPergunta3.Size = new System.Drawing.Size(182, 20);
            this.lblPergunta3.TabIndex = 4;
            this.lblPergunta3.Text = "Mora perto da vítima?";
            // 
            // lblPergunta4
            // 
            this.lblPergunta4.AutoSize = true;
            this.lblPergunta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta4.Location = new System.Drawing.Point(109, 190);
            this.lblPergunta4.Name = "lblPergunta4";
            this.lblPergunta4.Size = new System.Drawing.Size(171, 20);
            this.lblPergunta4.TabIndex = 6;
            this.lblPergunta4.Text = "Devia para a vítima?";
            // 
            // lblPergunta5
            // 
            this.lblPergunta5.AutoSize = true;
            this.lblPergunta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta5.Location = new System.Drawing.Point(77, 224);
            this.lblPergunta5.Name = "lblPergunta5";
            this.lblPergunta5.Size = new System.Drawing.Size(223, 20);
            this.lblPergunta5.TabIndex = 8;
            this.lblPergunta5.Text = "Já trabalhou com a vítima?";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(388, 40);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Aconteceu um crime, responda essas questões\r\nPara saber seu envolvimento no caso\r" +
    "\n";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(25, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 31);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(263, 276);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(115, 31);
            this.btnExaminar.TabIndex = 12;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 314);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPergunta5);
            this.Controls.Add(this.lblPergunta4);
            this.Controls.Add(this.lblPergunta3);
            this.Controls.Add(this.lblPergunta2);
            this.Controls.Add(this.lblPergunta1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPergunta1;
        private System.Windows.Forms.Label lblPergunta2;
        private System.Windows.Forms.Label lblPergunta3;
        private System.Windows.Forms.Label lblPergunta4;
        private System.Windows.Forms.Label lblPergunta5;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExaminar;
    }
}

