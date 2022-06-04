namespace Variáveis
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Idade = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.Label();
            this.Gênero = new System.Windows.Forms.Label();
            this.EnsinoMedio = new System.Windows.Forms.Label();
            this.cbConcluido = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(176, 123);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(628, 30);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exibir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Nome.Location = new System.Drawing.Point(112, 130);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(55, 23);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(176, 161);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(180, 30);
            this.txtIdade.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(112, 168);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(58, 23);
            this.Idade.TabIndex = 5;
            this.Idade.Text = "Idade:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(176, 209);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 27);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(299, 209);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(91, 27);
            this.rbFem.TabIndex = 7;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(167, 255);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 30);
            this.txtAltura.TabIndex = 8;
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(104, 258);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(63, 23);
            this.Altura.TabIndex = 9;
            this.Altura.Text = "Altura:";
            // 
            // Gênero
            // 
            this.Gênero.AutoSize = true;
            this.Gênero.Location = new System.Drawing.Point(104, 211);
            this.Gênero.Name = "Gênero";
            this.Gênero.Size = new System.Drawing.Size(66, 23);
            this.Gênero.TabIndex = 10;
            this.Gênero.Text = "Gênero:";
            // 
            // EnsinoMedio
            // 
            this.EnsinoMedio.AutoSize = true;
            this.EnsinoMedio.Location = new System.Drawing.Point(12, 308);
            this.EnsinoMedio.Name = "EnsinoMedio";
            this.EnsinoMedio.Size = new System.Drawing.Size(180, 23);
            this.EnsinoMedio.TabIndex = 11;
            this.EnsinoMedio.Text = "Ensino Médio Concluído";
            // 
            // cbConcluido
            // 
            this.cbConcluido.AutoSize = true;
            this.cbConcluido.Location = new System.Drawing.Point(198, 308);
            this.cbConcluido.Name = "cbConcluido";
            this.cbConcluido.Size = new System.Drawing.Size(56, 27);
            this.cbConcluido.TabIndex = 12;
            this.cbConcluido.Text = "Sim";
            this.cbConcluido.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 796);
            this.Controls.Add(this.cbConcluido);
            this.Controls.Add(this.EnsinoMedio);
            this.Controls.Add(this.Gênero);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.rbFem);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Formulário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Label Gênero;
        private System.Windows.Forms.Label EnsinoMedio;
        private System.Windows.Forms.CheckBox cbConcluido;
    }
}

