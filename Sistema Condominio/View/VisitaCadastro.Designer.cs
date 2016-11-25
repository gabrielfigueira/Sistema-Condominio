namespace Sistema_Condominio.View
{
    partial class VisitaCadastro
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
            this.textButtonNome = new MetroFramework.Controls.MetroTextBox();
            this.dateTimeDataEntrada = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeDataSaida = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeDataPrevista = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.buttonCadastrar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // textButtonNome
            // 
            // 
            // 
            // 
            this.textButtonNome.CustomButton.Image = null;
            this.textButtonNome.CustomButton.Location = new System.Drawing.Point(464, 1);
            this.textButtonNome.CustomButton.Name = "";
            this.textButtonNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textButtonNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textButtonNome.CustomButton.TabIndex = 1;
            this.textButtonNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textButtonNome.CustomButton.UseSelectable = true;
            this.textButtonNome.CustomButton.Visible = false;
            this.textButtonNome.Lines = new string[0];
            this.textButtonNome.Location = new System.Drawing.Point(119, 80);
            this.textButtonNome.MaxLength = 32767;
            this.textButtonNome.Name = "textButtonNome";
            this.textButtonNome.PasswordChar = '\0';
            this.textButtonNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textButtonNome.SelectedText = "";
            this.textButtonNome.SelectionLength = 0;
            this.textButtonNome.SelectionStart = 0;
            this.textButtonNome.Size = new System.Drawing.Size(486, 23);
            this.textButtonNome.TabIndex = 0;
            this.textButtonNome.UseSelectable = true;
            this.textButtonNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textButtonNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateTimeDataEntrada
            // 
            this.dateTimeDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataEntrada.Location = new System.Drawing.Point(119, 109);
            this.dateTimeDataEntrada.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeDataEntrada.Name = "dateTimeDataEntrada";
            this.dateTimeDataEntrada.Size = new System.Drawing.Size(200, 29);
            this.dateTimeDataEntrada.TabIndex = 1;
            // 
            // dateTimeDataSaida
            // 
            this.dateTimeDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataSaida.Location = new System.Drawing.Point(407, 109);
            this.dateTimeDataSaida.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeDataSaida.Name = "dateTimeDataSaida";
            this.dateTimeDataSaida.Size = new System.Drawing.Size(200, 29);
            this.dateTimeDataSaida.TabIndex = 2;
            // 
            // dateTimeDataPrevista
            // 
            this.dateTimeDataPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataPrevista.Location = new System.Drawing.Point(119, 144);
            this.dateTimeDataPrevista.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeDataPrevista.Name = "dateTimeDataPrevista";
            this.dateTimeDataPrevista.Size = new System.Drawing.Size(200, 29);
            this.dateTimeDataPrevista.TabIndex = 3;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(48, 84);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Nome:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Data Entrada:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(326, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Data Saida:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Data Prevista:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Image = null;
            this.buttonCadastrar.Location = new System.Drawing.Point(500, 210);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(114, 23);
            this.buttonCadastrar.TabIndex = 34;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseSelectable = true;
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // VisitaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 256);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.dateTimeDataPrevista);
            this.Controls.Add(this.dateTimeDataSaida);
            this.Controls.Add(this.dateTimeDataEntrada);
            this.Controls.Add(this.textButtonNome);
            this.Name = "VisitaCadastro";
            this.Text = "Cadastro de Visitantes";
            this.Load += new System.EventHandler(this.VisitanteCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textButtonNome;
        private MetroFramework.Controls.MetroDateTime dateTimeDataEntrada;
        private MetroFramework.Controls.MetroDateTime dateTimeDataSaida;
        private MetroFramework.Controls.MetroDateTime dateTimeDataPrevista;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton buttonCadastrar;
    }
}