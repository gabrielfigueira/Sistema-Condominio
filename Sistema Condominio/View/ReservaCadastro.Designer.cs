namespace Sistema_Condominio.View
{
    partial class ReservaCadastro
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
            this.btPesquisar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.checkBoxPermitir = new System.Windows.Forms.CheckBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btCadastrarReserva = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.textButtonAlterar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = null;
            this.btPesquisar.Location = new System.Drawing.Point(398, 72);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 15;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseSelectable = true;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // tbNome
            // 
            // 
            // 
            // 
            this.tbNome.CustomButton.Image = null;
            this.tbNome.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.tbNome.CustomButton.Name = "";
            this.tbNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNome.CustomButton.TabIndex = 1;
            this.tbNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNome.CustomButton.UseSelectable = true;
            this.tbNome.CustomButton.Visible = false;
            this.tbNome.Enabled = false;
            this.tbNome.Lines = new string[0];
            this.tbNome.Location = new System.Drawing.Point(106, 72);
            this.tbNome.MaxLength = 32767;
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNome.SelectedText = "";
            this.tbNome.SelectionLength = 0;
            this.tbNome.SelectionStart = 0;
            this.tbNome.Size = new System.Drawing.Size(286, 23);
            this.tbNome.TabIndex = 14;
            this.tbNome.UseSelectable = true;
            this.tbNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 72);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Morador :";
            // 
            // tbDescricao
            // 
            // 
            // 
            // 
            this.tbDescricao.CustomButton.Image = null;
            this.tbDescricao.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.tbDescricao.CustomButton.Name = "";
            this.tbDescricao.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.tbDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescricao.CustomButton.TabIndex = 1;
            this.tbDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescricao.CustomButton.UseSelectable = true;
            this.tbDescricao.CustomButton.Visible = false;
            this.tbDescricao.Lines = new string[0];
            this.tbDescricao.Location = new System.Drawing.Point(106, 150);
            this.tbDescricao.MaxLength = 32767;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.PasswordChar = '\0';
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescricao.SelectedText = "";
            this.tbDescricao.SelectionLength = 0;
            this.tbDescricao.SelectionStart = 0;
            this.tbDescricao.Size = new System.Drawing.Size(346, 63);
            this.tbDescricao.TabIndex = 36;
            this.tbDescricao.UseSelectable = true;
            this.tbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(16, 150);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 35;
            this.metroLabel10.Text = "Descrição: ";
            // 
            // checkBoxPermitir
            // 
            this.checkBoxPermitir.AutoSize = true;
            this.checkBoxPermitir.Location = new System.Drawing.Point(366, 112);
            this.checkBoxPermitir.Name = "checkBoxPermitir";
            this.checkBoxPermitir.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPermitir.TabIndex = 39;
            this.checkBoxPermitir.Text = "Permitir";
            this.checkBoxPermitir.UseVisualStyleBackColor = true;
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(106, 110);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(237, 20);
            this.tbLocal.TabIndex = 40;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 110);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Local:";
            // 
            // btCadastrarReserva
            // 
            this.btCadastrarReserva.Image = null;
            this.btCadastrarReserva.Location = new System.Drawing.Point(338, 235);
            this.btCadastrarReserva.Name = "btCadastrarReserva";
            this.btCadastrarReserva.Size = new System.Drawing.Size(114, 23);
            this.btCadastrarReserva.TabIndex = 42;
            this.btCadastrarReserva.Text = "Salvar";
            this.btCadastrarReserva.UseSelectable = true;
            this.btCadastrarReserva.UseVisualStyleBackColor = true;
            this.btCadastrarReserva.Click += new System.EventHandler(this.btCadastrarReserva_Click);
            // 
            // textButtonAlterar
            // 
            this.textButtonAlterar.Image = null;
            this.textButtonAlterar.Location = new System.Drawing.Point(189, 235);
            this.textButtonAlterar.Name = "textButtonAlterar";
            this.textButtonAlterar.Size = new System.Drawing.Size(143, 23);
            this.textButtonAlterar.TabIndex = 43;
            this.textButtonAlterar.Text = "Alterar";
            this.textButtonAlterar.UseSelectable = true;
            this.textButtonAlterar.UseVisualStyleBackColor = true;
            this.textButtonAlterar.Click += new System.EventHandler(this.textButtonAlterar_Click);
            // 
            // ReservaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 281);
            this.Controls.Add(this.textButtonAlterar);
            this.Controls.Add(this.btCadastrarReserva);
            this.Controls.Add(this.tbLocal);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.checkBoxPermitir);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.metroLabel6);
            this.Name = "ReservaCadastro";
            this.Text = "Cadastro de Reserva";
            this.Load += new System.EventHandler(this.ReservaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btPesquisar;
        private MetroFramework.Controls.MetroTextBox tbNome;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.CheckBox checkBoxPermitir;
        private System.Windows.Forms.TextBox tbLocal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btCadastrarReserva;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton textButtonAlterar;
    }
}