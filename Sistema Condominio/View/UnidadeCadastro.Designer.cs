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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbQtdComodo = new MetroFramework.Controls.MetroTextBox();
            this.tbAndar = new MetroFramework.Controls.MetroTextBox();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.cbTipoImovel = new System.Windows.Forms.ComboBox();
            this.tbQtdApart = new System.Windows.Forms.TextBox();
            this.btCadastrar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tipo de Imóvel:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Qtd. Apartamento:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Qtd. Comodo: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 237);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Andar: ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 272);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Descrição: ";
            // 
            // tbQtdComodo
            // 
            // 
            // 
            // 
            this.tbQtdComodo.CustomButton.Image = null;
            this.tbQtdComodo.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.tbQtdComodo.CustomButton.Name = "";
            this.tbQtdComodo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbQtdComodo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbQtdComodo.CustomButton.TabIndex = 1;
            this.tbQtdComodo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbQtdComodo.CustomButton.UseSelectable = true;
            this.tbQtdComodo.CustomButton.Visible = false;
            this.tbQtdComodo.Lines = new string[0];
            this.tbQtdComodo.Location = new System.Drawing.Point(153, 196);
            this.tbQtdComodo.MaxLength = 32767;
            this.tbQtdComodo.Name = "tbQtdComodo";
            this.tbQtdComodo.PasswordChar = '\0';
            this.tbQtdComodo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbQtdComodo.SelectedText = "";
            this.tbQtdComodo.SelectionLength = 0;
            this.tbQtdComodo.SelectionStart = 0;
            this.tbQtdComodo.Size = new System.Drawing.Size(65, 23);
            this.tbQtdComodo.TabIndex = 7;
            this.tbQtdComodo.UseSelectable = true;
            this.tbQtdComodo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbQtdComodo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAndar
            // 
            // 
            // 
            // 
            this.tbAndar.CustomButton.Image = null;
            this.tbAndar.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.tbAndar.CustomButton.Name = "";
            this.tbAndar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAndar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAndar.CustomButton.TabIndex = 1;
            this.tbAndar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAndar.CustomButton.UseSelectable = true;
            this.tbAndar.CustomButton.Visible = false;
            this.tbAndar.Lines = new string[0];
            this.tbAndar.Location = new System.Drawing.Point(153, 233);
            this.tbAndar.MaxLength = 32767;
            this.tbAndar.Name = "tbAndar";
            this.tbAndar.PasswordChar = '\0';
            this.tbAndar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAndar.SelectedText = "";
            this.tbAndar.SelectionLength = 0;
            this.tbAndar.SelectionStart = 0;
            this.tbAndar.Size = new System.Drawing.Size(65, 23);
            this.tbAndar.TabIndex = 8;
            this.tbAndar.UseSelectable = true;
            this.tbAndar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAndar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDescricao
            // 
            // 
            // 
            // 
            this.tbDescricao.CustomButton.Image = null;
            this.tbDescricao.CustomButton.Location = new System.Drawing.Point(124, 2);
            this.tbDescricao.CustomButton.Name = "";
            this.tbDescricao.CustomButton.Size = new System.Drawing.Size(97, 97);
            this.tbDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescricao.CustomButton.TabIndex = 1;
            this.tbDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescricao.CustomButton.UseSelectable = true;
            this.tbDescricao.CustomButton.Visible = false;
            this.tbDescricao.Lines = new string[0];
            this.tbDescricao.Location = new System.Drawing.Point(153, 272);
            this.tbDescricao.MaxLength = 32767;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.PasswordChar = '\0';
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescricao.SelectedText = "";
            this.tbDescricao.SelectionLength = 0;
            this.tbDescricao.SelectionStart = 0;
            this.tbDescricao.Size = new System.Drawing.Size(224, 102);
            this.tbDescricao.TabIndex = 9;
            this.tbDescricao.UseSelectable = true;
            this.tbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // cbTipoImovel
            // 
            this.cbTipoImovel.FormattingEnabled = true;
            this.cbTipoImovel.Items.AddRange(new object[] {
            "Prédio",
            "Casa",
            "Mansão"});
            this.cbTipoImovel.Location = new System.Drawing.Point(153, 118);
            this.cbTipoImovel.Name = "cbTipoImovel";
            this.cbTipoImovel.Size = new System.Drawing.Size(224, 21);
            this.cbTipoImovel.TabIndex = 13;
            this.cbTipoImovel.Text = "Selecione o tipo de imóvel";
            this.cbTipoImovel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbQtdApart
            // 
            this.tbQtdApart.Location = new System.Drawing.Point(153, 164);
            this.tbQtdApart.Name = "tbQtdApart";
            this.tbQtdApart.Size = new System.Drawing.Size(65, 20);
            this.tbQtdApart.TabIndex = 14;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = null;
            this.btCadastrar.Location = new System.Drawing.Point(274, 380);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(103, 30);
            this.btCadastrar.TabIndex = 15;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseSelectable = true;
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // Unidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 514);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbQtdApart);
            this.Controls.Add(this.cbTipoImovel);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbAndar);
            this.Controls.Add(this.tbQtdComodo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Unidade";
            this.Text = "Unidade";
            this.Load += new System.EventHandler(this.Unidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbQtdComodo;
        private MetroFramework.Controls.MetroTextBox tbAndar;
        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.ComboBox cbTipoImovel;
        private System.Windows.Forms.TextBox tbQtdApart;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btCadastrar;
    }
}