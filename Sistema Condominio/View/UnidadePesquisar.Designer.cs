namespace Sistema_Condominio.View
{
    partial class UnidadePesquisar
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
            this.metroTextButtonSelecionar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.dataGridUnidade = new System.Windows.Forms.DataGridView();
            this.textFieldPesquisarUnidade = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnidade)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextButtonSelecionar
            // 
            this.metroTextButtonSelecionar.Image = null;
            this.metroTextButtonSelecionar.Location = new System.Drawing.Point(31, 314);
            this.metroTextButtonSelecionar.Name = "metroTextButtonSelecionar";
            this.metroTextButtonSelecionar.Size = new System.Drawing.Size(75, 23);
            this.metroTextButtonSelecionar.TabIndex = 14;
            this.metroTextButtonSelecionar.Text = "Selecionar";
            this.metroTextButtonSelecionar.UseSelectable = true;
            this.metroTextButtonSelecionar.UseVisualStyleBackColor = true;
            this.metroTextButtonSelecionar.Click += new System.EventHandler(this.metroTextButtonSelecionar_Click_1);
            // 
            // dataGridUnidade
            // 
            this.dataGridUnidade.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUnidade.Location = new System.Drawing.Point(31, 93);
            this.dataGridUnidade.Name = "dataGridUnidade";
            this.dataGridUnidade.ReadOnly = true;
            this.dataGridUnidade.Size = new System.Drawing.Size(636, 212);
            this.dataGridUnidade.TabIndex = 13;
            // 
            // textFieldPesquisarUnidade
            // 
            // 
            // 
            // 
            this.textFieldPesquisarUnidade.CustomButton.Image = null;
            this.textFieldPesquisarUnidade.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.textFieldPesquisarUnidade.CustomButton.Name = "";
            this.textFieldPesquisarUnidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textFieldPesquisarUnidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textFieldPesquisarUnidade.CustomButton.TabIndex = 1;
            this.textFieldPesquisarUnidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textFieldPesquisarUnidade.CustomButton.UseSelectable = true;
            this.textFieldPesquisarUnidade.CustomButton.Visible = false;
            this.textFieldPesquisarUnidade.Lines = new string[0];
            this.textFieldPesquisarUnidade.Location = new System.Drawing.Point(31, 64);
            this.textFieldPesquisarUnidade.MaxLength = 32767;
            this.textFieldPesquisarUnidade.Name = "textFieldPesquisarUnidade";
            this.textFieldPesquisarUnidade.PasswordChar = '\0';
            this.textFieldPesquisarUnidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textFieldPesquisarUnidade.SelectedText = "";
            this.textFieldPesquisarUnidade.SelectionLength = 0;
            this.textFieldPesquisarUnidade.SelectionStart = 0;
            this.textFieldPesquisarUnidade.Size = new System.Drawing.Size(323, 23);
            this.textFieldPesquisarUnidade.TabIndex = 12;
            this.textFieldPesquisarUnidade.UseSelectable = true;
            this.textFieldPesquisarUnidade.WaterMark = "Pesquise aqui...";
            this.textFieldPesquisarUnidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textFieldPesquisarUnidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = null;
            this.btPesquisar.Location = new System.Drawing.Point(360, 64);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 11;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseSelectable = true;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click_1);
            // 
            // UnidadePesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 367);
            this.Controls.Add(this.metroTextButtonSelecionar);
            this.Controls.Add(this.dataGridUnidade);
            this.Controls.Add(this.textFieldPesquisarUnidade);
            this.Controls.Add(this.btPesquisar);
            this.Name = "UnidadePesquisar";
            this.Text = "Pesquisar Unidade";
            this.Load += new System.EventHandler(this.UnidadePesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonSelecionar;
        private System.Windows.Forms.DataGridView dataGridUnidade;
        private MetroFramework.Controls.MetroTextBox textFieldPesquisarUnidade;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btPesquisar;
    }
}