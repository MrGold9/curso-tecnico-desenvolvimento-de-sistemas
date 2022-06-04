namespace Forms_Exemplo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.checkDesenvolvimentoSistemas = new System.Windows.Forms.CheckBox();
            this.checkEnsinoMedio = new System.Windows.Forms.CheckBox();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFeminino = new System.Windows.Forms.RadioButton();
            this.groupGeneros = new System.Windows.Forms.GroupBox();
            this.groupCursos = new System.Windows.Forms.GroupBox();
            this.groupEstadoCivil = new System.Windows.Forms.GroupBox();
            this.radioDivorciado = new System.Windows.Forms.RadioButton();
            this.radioSolteiro = new System.Windows.Forms.RadioButton();
            this.radioCasado = new System.Windows.Forms.RadioButton();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupGeneros.SuspendLayout();
            this.groupCursos.SuspendLayout();
            this.groupEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(327, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(156, 42);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(290, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 23);
            this.txtNome.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 178);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(221, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 22);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(221, 136);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 22);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(290, 135);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(262, 23);
            this.txtSenha.TabIndex = 6;
            // 
            // checkDesenvolvimentoSistemas
            // 
            this.checkDesenvolvimentoSistemas.AutoSize = true;
            this.checkDesenvolvimentoSistemas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkDesenvolvimentoSistemas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkDesenvolvimentoSistemas.Location = new System.Drawing.Point(16, 25);
            this.checkDesenvolvimentoSistemas.Name = "checkDesenvolvimentoSistemas";
            this.checkDesenvolvimentoSistemas.Size = new System.Drawing.Size(248, 23);
            this.checkDesenvolvimentoSistemas.TabIndex = 7;
            this.checkDesenvolvimentoSistemas.Text = "Desenvolvimento de Sistemas";
            this.checkDesenvolvimentoSistemas.UseVisualStyleBackColor = true;
            // 
            // checkEnsinoMedio
            // 
            this.checkEnsinoMedio.AutoSize = true;
            this.checkEnsinoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEnsinoMedio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkEnsinoMedio.Location = new System.Drawing.Point(16, 54);
            this.checkEnsinoMedio.Name = "checkEnsinoMedio";
            this.checkEnsinoMedio.Size = new System.Drawing.Size(121, 22);
            this.checkEnsinoMedio.TabIndex = 8;
            this.checkEnsinoMedio.Text = "Ensino Médio";
            this.checkEnsinoMedio.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMasculino.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioMasculino.Location = new System.Drawing.Point(39, 24);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(97, 22);
            this.radioMasculino.TabIndex = 9;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // radioFeminino
            // 
            this.radioFeminino.AutoSize = true;
            this.radioFeminino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioFeminino.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioFeminino.Location = new System.Drawing.Point(39, 52);
            this.radioFeminino.Name = "radioFeminino";
            this.radioFeminino.Size = new System.Drawing.Size(90, 22);
            this.radioFeminino.TabIndex = 10;
            this.radioFeminino.TabStop = true;
            this.radioFeminino.Text = "Feminino";
            this.radioFeminino.UseVisualStyleBackColor = true;
            // 
            // groupGeneros
            // 
            this.groupGeneros.Controls.Add(this.radioFeminino);
            this.groupGeneros.Controls.Add(this.radioMasculino);
            this.groupGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupGeneros.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupGeneros.Location = new System.Drawing.Point(584, 61);
            this.groupGeneros.Name = "groupGeneros";
            this.groupGeneros.Padding = new System.Windows.Forms.Padding(9);
            this.groupGeneros.Size = new System.Drawing.Size(190, 80);
            this.groupGeneros.TabIndex = 11;
            this.groupGeneros.TabStop = false;
            this.groupGeneros.Text = "Gênero";
            // 
            // groupCursos
            // 
            this.groupCursos.Controls.Add(this.checkEnsinoMedio);
            this.groupCursos.Controls.Add(this.checkDesenvolvimentoSistemas);
            this.groupCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCursos.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupCursos.Location = new System.Drawing.Point(31, 257);
            this.groupCursos.Name = "groupCursos";
            this.groupCursos.Padding = new System.Windows.Forms.Padding(9);
            this.groupCursos.Size = new System.Drawing.Size(289, 86);
            this.groupCursos.TabIndex = 12;
            this.groupCursos.TabStop = false;
            this.groupCursos.Text = "Cursos";
            // 
            // groupEstadoCivil
            // 
            this.groupEstadoCivil.Controls.Add(this.radioDivorciado);
            this.groupEstadoCivil.Controls.Add(this.radioSolteiro);
            this.groupEstadoCivil.Controls.Add(this.radioCasado);
            this.groupEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupEstadoCivil.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupEstadoCivil.Location = new System.Drawing.Point(362, 225);
            this.groupEstadoCivil.Name = "groupEstadoCivil";
            this.groupEstadoCivil.Padding = new System.Windows.Forms.Padding(9);
            this.groupEstadoCivil.Size = new System.Drawing.Size(190, 118);
            this.groupEstadoCivil.TabIndex = 13;
            this.groupEstadoCivil.TabStop = false;
            this.groupEstadoCivil.Text = "Estado Civil";
            // 
            // radioDivorciado
            // 
            this.radioDivorciado.AutoSize = true;
            this.radioDivorciado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDivorciado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioDivorciado.Location = new System.Drawing.Point(45, 86);
            this.radioDivorciado.Name = "radioDivorciado";
            this.radioDivorciado.Size = new System.Drawing.Size(102, 22);
            this.radioDivorciado.TabIndex = 11;
            this.radioDivorciado.TabStop = true;
            this.radioDivorciado.Text = "Divorciado";
            this.radioDivorciado.UseVisualStyleBackColor = true;
            // 
            // radioSolteiro
            // 
            this.radioSolteiro.AutoSize = true;
            this.radioSolteiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioSolteiro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioSolteiro.Location = new System.Drawing.Point(45, 58);
            this.radioSolteiro.Name = "radioSolteiro";
            this.radioSolteiro.Size = new System.Drawing.Size(81, 22);
            this.radioSolteiro.TabIndex = 10;
            this.radioSolteiro.TabStop = true;
            this.radioSolteiro.Text = "Solteiro";
            this.radioSolteiro.UseVisualStyleBackColor = true;
            // 
            // radioCasado
            // 
            this.radioCasado.AutoSize = true;
            this.radioCasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCasado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioCasado.Location = new System.Drawing.Point(45, 30);
            this.radioCasado.Name = "radioCasado";
            this.radioCasado.Size = new System.Drawing.Size(78, 22);
            this.radioCasado.TabIndex = 9;
            this.radioCasado.TabStop = true;
            this.radioCasado.Text = "Casado";
            this.radioCasado.UseVisualStyleBackColor = true;
            // 
            // cbEstados
            // 
            this.cbEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstados.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Items.AddRange(new object[] {
            "SP",
            "BA",
            "PA",
            "AM",
            "PI",
            "PE",
            "SC",
            "ES",
            "MG",
            "RS",
            "RN",
            "MS"});
            this.cbEstados.Location = new System.Drawing.Point(623, 171);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(121, 26);
            this.cbEstados.TabIndex = 14;
            this.cbEstados.Text = "Estado";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(597, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 63);
            this.button1.TabIndex = 15;
            this.button1.Text = "Mensagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.groupEstadoCivil);
            this.Controls.Add(this.groupCursos);
            this.Controls.Add(this.groupGeneros);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnFechar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minha Aplicação";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupGeneros.ResumeLayout(false);
            this.groupGeneros.PerformLayout();
            this.groupCursos.ResumeLayout(false);
            this.groupCursos.PerformLayout();
            this.groupEstadoCivil.ResumeLayout(false);
            this.groupEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox checkDesenvolvimentoSistemas;
        private System.Windows.Forms.CheckBox checkEnsinoMedio;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.RadioButton radioFeminino;
        private System.Windows.Forms.GroupBox groupGeneros;
        private System.Windows.Forms.GroupBox groupCursos;
        private System.Windows.Forms.GroupBox groupEstadoCivil;
        private System.Windows.Forms.RadioButton radioDivorciado;
        private System.Windows.Forms.RadioButton radioSolteiro;
        private System.Windows.Forms.RadioButton radioCasado;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Button button1;
    }
}

