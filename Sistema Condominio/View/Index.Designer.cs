namespace Sistema_Condominio.View
{
    partial class Index
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroTextButtonExcluirMorador = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.dataGridMorador = new System.Windows.Forms.DataGridView();
            this.metroTextButtonCadastrar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.textFieldPesquisarMorador = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbUnidade = new System.Windows.Forms.GroupBox();
            this.checkBoxUnidade = new System.Windows.Forms.CheckBox();
            this.tbQtdComodo = new System.Windows.Forms.TextBox();
            this.tbAndar = new System.Windows.Forms.TextBox();
            this.tbQtdApartamento = new System.Windows.Forms.TextBox();
            this.btCadastrarUnidade = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbTipoImovel = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroTextButtonAlterarMorador = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMorador)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbUnidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(16, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroTextButtonAlterarMorador);
            this.tabPage1.Controls.Add(this.metroTextButtonExcluirMorador);
            this.tabPage1.Controls.Add(this.dataGridMorador);
            this.tabPage1.Controls.Add(this.metroTextButtonCadastrar);
            this.tabPage1.Controls.Add(this.textFieldPesquisarMorador);
            this.tabPage1.Controls.Add(this.btPesquisar);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Moradores";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // metroTextButtonExcluirMorador
            // 
            this.metroTextButtonExcluirMorador.Image = null;
            this.metroTextButtonExcluirMorador.Location = new System.Drawing.Point(110, 258);
            this.metroTextButtonExcluirMorador.Name = "metroTextButtonExcluirMorador";
            this.metroTextButtonExcluirMorador.Size = new System.Drawing.Size(75, 23);
            this.metroTextButtonExcluirMorador.TabIndex = 7;
            this.metroTextButtonExcluirMorador.Text = "Excluir";
            this.metroTextButtonExcluirMorador.UseSelectable = true;
            this.metroTextButtonExcluirMorador.UseVisualStyleBackColor = true;
            this.metroTextButtonExcluirMorador.Click += new System.EventHandler(this.metroTextButtonAlterarMorador_Click);
            // 
            // dataGridMorador
            // 
            this.dataGridMorador.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridMorador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMorador.Location = new System.Drawing.Point(6, 40);
            this.dataGridMorador.Name = "dataGridMorador";
            this.dataGridMorador.Size = new System.Drawing.Size(636, 212);
            this.dataGridMorador.TabIndex = 6;
            this.dataGridMorador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMorador_CellContentClick);
            this.dataGridMorador.DoubleClick += new System.EventHandler(this.metroTextButtonAlterarMorador_Click_1);
            // 
            // metroTextButtonCadastrar
            // 
            this.metroTextButtonCadastrar.Image = null;
            this.metroTextButtonCadastrar.Location = new System.Drawing.Point(6, 258);
            this.metroTextButtonCadastrar.Name = "metroTextButtonCadastrar";
            this.metroTextButtonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.metroTextButtonCadastrar.TabIndex = 5;
            this.metroTextButtonCadastrar.Text = "Cadastrar";
            this.metroTextButtonCadastrar.UseSelectable = true;
            this.metroTextButtonCadastrar.UseVisualStyleBackColor = true;
            this.metroTextButtonCadastrar.Click += new System.EventHandler(this.metroTextButton3_Click);
            // 
            // textFieldPesquisarMorador
            // 
            // 
            // 
            // 
            this.textFieldPesquisarMorador.CustomButton.Image = null;
            this.textFieldPesquisarMorador.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.textFieldPesquisarMorador.CustomButton.Name = "";
            this.textFieldPesquisarMorador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textFieldPesquisarMorador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textFieldPesquisarMorador.CustomButton.TabIndex = 1;
            this.textFieldPesquisarMorador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textFieldPesquisarMorador.CustomButton.UseSelectable = true;
            this.textFieldPesquisarMorador.CustomButton.Visible = false;
            this.textFieldPesquisarMorador.Lines = new string[0];
            this.textFieldPesquisarMorador.Location = new System.Drawing.Point(6, 11);
            this.textFieldPesquisarMorador.MaxLength = 32767;
            this.textFieldPesquisarMorador.Name = "textFieldPesquisarMorador";
            this.textFieldPesquisarMorador.PasswordChar = '\0';
            this.textFieldPesquisarMorador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textFieldPesquisarMorador.SelectedText = "";
            this.textFieldPesquisarMorador.SelectionLength = 0;
            this.textFieldPesquisarMorador.SelectionStart = 0;
            this.textFieldPesquisarMorador.Size = new System.Drawing.Size(323, 23);
            this.textFieldPesquisarMorador.TabIndex = 4;
            this.textFieldPesquisarMorador.UseSelectable = true;
            this.textFieldPesquisarMorador.WaterMark = "Pesquise aqui...";
            this.textFieldPesquisarMorador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textFieldPesquisarMorador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = null;
            this.btPesquisar.Location = new System.Drawing.Point(335, 11);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 3;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseSelectable = true;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(636, 212);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.gbUnidade);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unidades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTextButton2);
            this.panel1.Controls.Add(this.metroTextButton1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(32, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 54);
            this.panel1.TabIndex = 3;
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(493, 18);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(114, 23);
            this.metroTextButton2.TabIndex = 27;
            this.metroTextButton2.Text = "Excluir";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(373, 18);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(114, 23);
            this.metroTextButton1.TabIndex = 26;
            this.metroTextButton1.Text = "Editar";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 194);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbUnidade
            // 
            this.gbUnidade.Controls.Add(this.checkBoxUnidade);
            this.gbUnidade.Controls.Add(this.tbQtdComodo);
            this.gbUnidade.Controls.Add(this.tbAndar);
            this.gbUnidade.Controls.Add(this.tbQtdApartamento);
            this.gbUnidade.Controls.Add(this.btCadastrarUnidade);
            this.gbUnidade.Controls.Add(this.metroLabel1);
            this.gbUnidade.Controls.Add(this.cbTipoImovel);
            this.gbUnidade.Controls.Add(this.metroLabel2);
            this.gbUnidade.Controls.Add(this.tbDescricao);
            this.gbUnidade.Controls.Add(this.metroLabel3);
            this.gbUnidade.Controls.Add(this.metroLabel4);
            this.gbUnidade.Controls.Add(this.metroLabel5);
            this.gbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUnidade.Location = new System.Drawing.Point(32, 37);
            this.gbUnidade.Name = "gbUnidade";
            this.gbUnidade.Size = new System.Drawing.Size(617, 212);
            this.gbUnidade.TabIndex = 1;
            this.gbUnidade.TabStop = false;
            this.gbUnidade.Text = "Cadastro Unidade";
            this.gbUnidade.Enter += new System.EventHandler(this.gbUnidade_Enter);
            // 
            // checkBoxUnidade
            // 
            this.checkBoxUnidade.AutoSize = true;
            this.checkBoxUnidade.Location = new System.Drawing.Point(478, 74);
            this.checkBoxUnidade.Name = "checkBoxUnidade";
            this.checkBoxUnidade.Size = new System.Drawing.Size(92, 21);
            this.checkBoxUnidade.TabIndex = 26;
            this.checkBoxUnidade.Text = "Disponível";
            this.checkBoxUnidade.UseVisualStyleBackColor = true;
            // 
            // tbQtdComodo
            // 
            this.tbQtdComodo.Location = new System.Drawing.Point(493, 32);
            this.tbQtdComodo.Name = "tbQtdComodo";
            this.tbQtdComodo.Size = new System.Drawing.Size(77, 23);
            this.tbQtdComodo.TabIndex = 25;
            this.tbQtdComodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdComodo_KeyPress);
            // 
            // tbAndar
            // 
            this.tbAndar.Location = new System.Drawing.Point(294, 76);
            this.tbAndar.Name = "tbAndar";
            this.tbAndar.Size = new System.Drawing.Size(132, 23);
            this.tbAndar.TabIndex = 24;
            // 
            // tbQtdApartamento
            // 
            this.tbQtdApartamento.Location = new System.Drawing.Point(147, 75);
            this.tbQtdApartamento.Name = "tbQtdApartamento";
            this.tbQtdApartamento.Size = new System.Drawing.Size(77, 23);
            this.tbQtdApartamento.TabIndex = 3;
            // 
            // btCadastrarUnidade
            // 
            this.btCadastrarUnidade.Image = null;
            this.btCadastrarUnidade.Location = new System.Drawing.Point(444, 176);
            this.btCadastrarUnidade.Name = "btCadastrarUnidade";
            this.btCadastrarUnidade.Size = new System.Drawing.Size(114, 23);
            this.btCadastrarUnidade.TabIndex = 5;
            this.btCadastrarUnidade.Text = "Salvar";
            this.btCadastrarUnidade.UseSelectable = true;
            this.btCadastrarUnidade.UseVisualStyleBackColor = true;
            this.btCadastrarUnidade.Click += new System.EventHandler(this.btCadastrarUnidade_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Tipo de Imóvel:";
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
            this.cbTipoImovel.Location = new System.Drawing.Point(147, 34);
            this.cbTipoImovel.Name = "cbTipoImovel";
            this.cbTipoImovel.Size = new System.Drawing.Size(224, 23);
            this.cbTipoImovel.TabIndex = 23;
            this.cbTipoImovel.SelectedIndexChanged += new System.EventHandler(this.cbTipoImovel_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Qtd. Apartamento:";
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
            this.tbDescricao.Location = new System.Drawing.Point(147, 110);
            this.tbDescricao.MaxLength = 32767;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.PasswordChar = '\0';
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescricao.SelectedText = "";
            this.tbDescricao.SelectionLength = 0;
            this.tbDescricao.SelectionStart = 0;
            this.tbDescricao.Size = new System.Drawing.Size(423, 51);
            this.tbDescricao.TabIndex = 22;
            this.tbDescricao.UseSelectable = true;
            this.tbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(388, 36);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Qtd. Comodo: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(235, 76);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Andar: ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 110);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Descrição: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(678, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Veículos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(678, 531);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Administração";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(678, 531);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Funcionários";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(315, 48);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(20, 12);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.htmlLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.htmlLabel1.Size = new System.Drawing.Size(315, 48);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "Sistema Condominio";
            this.htmlLabel1.Click += new System.EventHandler(this.htmlLabel1_Click);
            // 
            // metroTextButtonAlterarMorador
            // 
            this.metroTextButtonAlterarMorador.Image = null;
            this.metroTextButtonAlterarMorador.Location = new System.Drawing.Point(211, 258);
            this.metroTextButtonAlterarMorador.Name = "metroTextButtonAlterarMorador";
            this.metroTextButtonAlterarMorador.Size = new System.Drawing.Size(75, 23);
            this.metroTextButtonAlterarMorador.TabIndex = 8;
            this.metroTextButtonAlterarMorador.Text = "Alterar";
            this.metroTextButtonAlterarMorador.UseSelectable = true;
            this.metroTextButtonAlterarMorador.UseVisualStyleBackColor = true;
            this.metroTextButtonAlterarMorador.Click += new System.EventHandler(this.metroTextButtonAlterarMorador_Click_1);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 712);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMorador)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbUnidade.ResumeLayout(false);
            this.gbUnidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btPesquisar;
        private MetroFramework.Controls.MetroTextBox textFieldPesquisarMorador;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btCadastrarUnidade;
        private System.Windows.Forms.GroupBox gbUnidade;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cbTipoImovel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox tbQtdComodo;
        private System.Windows.Forms.TextBox tbAndar;
        private System.Windows.Forms.TextBox tbQtdApartamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private System.Windows.Forms.CheckBox checkBoxUnidade;
        private System.Windows.Forms.TabPage tabPage5;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonCadastrar;
        private System.Windows.Forms.DataGridView dataGridMorador;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonExcluirMorador;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAlterarMorador;
    }
}