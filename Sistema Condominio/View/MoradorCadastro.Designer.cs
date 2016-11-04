namespace Sistema_Condominio.View
{
    partial class MoradorCadastro
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.textRG = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textTResidencial = new System.Windows.Forms.TextBox();
            this.textTComercial = new System.Windows.Forms.TextBox();
            this.textTCelular = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.dateTimeDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDataFim = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTipoMorador = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(27, 54);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(392, 20);
            this.textNome.TabIndex = 0;
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(24, 92);
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(185, 20);
            this.textRG.TabIndex = 1;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(236, 92);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(183, 20);
            this.textCPF.TabIndex = 2;
            // 
            // textTResidencial
            // 
            this.textTResidencial.Location = new System.Drawing.Point(27, 128);
            this.textTResidencial.Name = "textTResidencial";
            this.textTResidencial.Size = new System.Drawing.Size(122, 20);
            this.textTResidencial.TabIndex = 3;
            // 
            // textTComercial
            // 
            this.textTComercial.Location = new System.Drawing.Point(155, 128);
            this.textTComercial.Name = "textTComercial";
            this.textTComercial.Size = new System.Drawing.Size(122, 20);
            this.textTComercial.TabIndex = 4;
            // 
            // textTCelular
            // 
            this.textTCelular.Location = new System.Drawing.Point(292, 128);
            this.textTCelular.Name = "textTCelular";
            this.textTCelular.Size = new System.Drawing.Size(127, 20);
            this.textTCelular.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(27, 164);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(392, 20);
            this.textEmail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefone Residencial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone Comercial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefone Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(266, 236);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(81, 35);
            this.buttonCadastrar.TabIndex = 14;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimeDataInicio
            // 
            this.dateTimeDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataInicio.Location = new System.Drawing.Point(174, 201);
            this.dateTimeDataInicio.Name = "dateTimeDataInicio";
            this.dateTimeDataInicio.Size = new System.Drawing.Size(119, 20);
            this.dateTimeDataInicio.TabIndex = 15;
            this.dateTimeDataInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimeDataFim
            // 
            this.dateTimeDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataFim.Location = new System.Drawing.Point(312, 201);
            this.dateTimeDataFim.Name = "dateTimeDataFim";
            this.dateTimeDataFim.Size = new System.Drawing.Size(107, 20);
            this.dateTimeDataFim.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data Inicio";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data Fim";
            // 
            // comboBoxTipoMorador
            // 
            this.comboBoxTipoMorador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoMorador.FormattingEnabled = true;
            this.comboBoxTipoMorador.Items.AddRange(new object[] {
            "Proprietario",
            "Aluguel",
            "Teste"});
            this.comboBoxTipoMorador.Location = new System.Drawing.Point(27, 201);
            this.comboBoxTipoMorador.Name = "comboBoxTipoMorador";
            this.comboBoxTipoMorador.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoMorador.TabIndex = 19;
            this.comboBoxTipoMorador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tipo Morador";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MoradorCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 283);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxTipoMorador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimeDataFim);
            this.Controls.Add(this.dateTimeDataInicio);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTCelular);
            this.Controls.Add(this.textTComercial);
            this.Controls.Add(this.textTResidencial);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.textNome);
            this.Name = "MoradorCadastro";
            this.Text = "MoradorCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textRG;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textTResidencial;
        private System.Windows.Forms.TextBox textTComercial;
        private System.Windows.Forms.TextBox textTCelular;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.DateTimePicker dateTimeDataInicio;
        private System.Windows.Forms.DateTimePicker dateTimeDataFim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTipoMorador;
        private System.Windows.Forms.Label label10;
    }
}