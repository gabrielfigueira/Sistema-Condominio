namespace Sistema_Condominio.View
{
    partial class UnidadeCadastro
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
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.checkBoxUnidade = new System.Windows.Forms.CheckBox();
            this.tbQtdComodo = new System.Windows.Forms.TextBox();
            this.tbAndar = new System.Windows.Forms.TextBox();
            this.tbQtdApartamento = new System.Windows.Forms.TextBox();
            this.btCadastrarUnidade = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbTipoImovel = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(333, 44);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.htmlLabel1.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.htmlLabel1.Size = new System.Drawing.Size(418, 48);
            this.htmlLabel1.TabIndex = 10;
            this.htmlLabel1.Text = "Cadastro de Unidade";
            // 
            // checkBoxUnidade
            // 
            this.checkBoxUnidade.AutoSize = true;
            this.checkBoxUnidade.Location = new System.Drawing.Point(500, 126);
            this.checkBoxUnidade.Name = "checkBoxUnidade";
            this.checkBoxUnidade.Size = new System.Drawing.Size(77, 17);
            this.checkBoxUnidade.TabIndex = 38;
            this.checkBoxUnidade.Text = "Disponível";
            this.checkBoxUnidade.UseVisualStyleBackColor = true;
            // 
            // tbQtdComodo
            // 
            this.tbQtdComodo.Location = new System.Drawing.Point(500, 76);
            this.tbQtdComodo.Name = "tbQtdComodo";
            this.tbQtdComodo.Size = new System.Drawing.Size(77, 20);
            this.tbQtdComodo.TabIndex = 37;
            this.tbQtdComodo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbQtdComodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbAndar
            // 
            this.tbAndar.Location = new System.Drawing.Point(324, 123);
            this.tbAndar.Name = "tbAndar";
            this.tbAndar.Size = new System.Drawing.Size(132, 20);
            this.tbAndar.TabIndex = 36;
            // 
            // tbQtdApartamento
            // 
            this.tbQtdApartamento.Location = new System.Drawing.Point(154, 119);
            this.tbQtdApartamento.Name = "tbQtdApartamento";
            this.tbQtdApartamento.Size = new System.Drawing.Size(77, 20);
            this.tbQtdApartamento.TabIndex = 27;
            // 
            // btCadastrarUnidade
            // 
            this.btCadastrarUnidade.Image = null;
            this.btCadastrarUnidade.Location = new System.Drawing.Point(463, 221);
            this.btCadastrarUnidade.Name = "btCadastrarUnidade";
            this.btCadastrarUnidade.Size = new System.Drawing.Size(114, 23);
            this.btCadastrarUnidade.TabIndex = 28;
            this.btCadastrarUnidade.Text = "Salvar";
            this.btCadastrarUnidade.UseSelectable = true;
            this.btCadastrarUnidade.UseVisualStyleBackColor = true;
            this.btCadastrarUnidade.Click += new System.EventHandler(this.btCadastrarUnidade_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(13, 80);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Tipo de Imóvel:";
            // 
            // cbTipoImovel
            // 
            this.cbTipoImovel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoImovel.FormattingEnabled = true;
            this.cbTipoImovel.Items.AddRange(new object[] {
            "Prédio",
            "Casa",
            "Mansão"});
            this.cbTipoImovel.Location = new System.Drawing.Point(154, 78);
            this.cbTipoImovel.Name = "cbTipoImovel";
            this.cbTipoImovel.Size = new System.Drawing.Size(224, 23);
            this.cbTipoImovel.TabIndex = 35;
            this.cbTipoImovel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(13, 120);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(121, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Qtd. Apartamento:";
            // 
            // tbDescricao
            // 
            // 
            // 
            // 
            this.tbDescricao.CustomButton.Image = null;
            this.tbDescricao.CustomButton.Location = new System.Drawing.Point(373, 1);
            this.tbDescricao.CustomButton.Name = "";
            this.tbDescricao.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.tbDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescricao.CustomButton.TabIndex = 1;
            this.tbDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescricao.CustomButton.UseSelectable = true;
            this.tbDescricao.CustomButton.Visible = false;
            this.tbDescricao.Lines = new string[0];
            this.tbDescricao.Location = new System.Drawing.Point(154, 154);
            this.tbDescricao.MaxLength = 32767;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.PasswordChar = '\0';
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescricao.SelectedText = "";
            this.tbDescricao.SelectionLength = 0;
            this.tbDescricao.SelectionStart = 0;
            this.tbDescricao.Size = new System.Drawing.Size(423, 51);
            this.tbDescricao.TabIndex = 34;
            this.tbDescricao.UseSelectable = true;
            this.tbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(395, 80);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 19);
            this.metroLabel8.TabIndex = 31;
            this.metroLabel8.Text = "Qtd. Comodo: ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(242, 120);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(76, 19);
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "Qtd Andar:";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(13, 154);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 33;
            this.metroLabel10.Text = "Descrição: ";
            // 
            // UnidadeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 267);
            this.Controls.Add(this.checkBoxUnidade);
            this.Controls.Add(this.tbQtdComodo);
            this.Controls.Add(this.tbAndar);
            this.Controls.Add(this.tbQtdApartamento);
            this.Controls.Add(this.btCadastrarUnidade);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbTipoImovel);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "UnidadeCadastro";
            this.Text = "Unidade";
            this.Load += new System.EventHandler(this.Unidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.CheckBox checkBoxUnidade;
        private System.Windows.Forms.TextBox tbQtdComodo;
        private System.Windows.Forms.TextBox tbAndar;
        private System.Windows.Forms.TextBox tbQtdApartamento;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btCadastrarUnidade;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox cbTipoImovel;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}