namespace Sistema_Condominio.View
{
    partial class MoradorPesquisar
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
            this.dataGridMorador = new System.Windows.Forms.DataGridView();
            this.textFieldPesquisarMorador = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonSelecionar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMorador)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMorador
            // 
            this.dataGridMorador.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridMorador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMorador.Location = new System.Drawing.Point(23, 90);
            this.dataGridMorador.Name = "dataGridMorador";
            this.dataGridMorador.ReadOnly = true;
            this.dataGridMorador.Size = new System.Drawing.Size(636, 212);
            this.dataGridMorador.TabIndex = 9;
            this.dataGridMorador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMorador_CellContentClick);
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
            this.textFieldPesquisarMorador.Location = new System.Drawing.Point(23, 61);
            this.textFieldPesquisarMorador.MaxLength = 32767;
            this.textFieldPesquisarMorador.Name = "textFieldPesquisarMorador";
            this.textFieldPesquisarMorador.PasswordChar = '\0';
            this.textFieldPesquisarMorador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textFieldPesquisarMorador.SelectedText = "";
            this.textFieldPesquisarMorador.SelectionLength = 0;
            this.textFieldPesquisarMorador.SelectionStart = 0;
            this.textFieldPesquisarMorador.Size = new System.Drawing.Size(323, 23);
            this.textFieldPesquisarMorador.TabIndex = 8;
            this.textFieldPesquisarMorador.UseSelectable = true;
            this.textFieldPesquisarMorador.WaterMark = "Pesquise aqui...";
            this.textFieldPesquisarMorador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textFieldPesquisarMorador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textFieldPesquisarMorador.Click += new System.EventHandler(this.textFieldPesquisarMorador_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = null;
            this.btPesquisar.Location = new System.Drawing.Point(352, 61);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 7;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseSelectable = true;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // metroTextButtonSelecionar
            // 
            this.metroTextButtonSelecionar.Image = null;
            this.metroTextButtonSelecionar.Location = new System.Drawing.Point(23, 311);
            this.metroTextButtonSelecionar.Name = "metroTextButtonSelecionar";
            this.metroTextButtonSelecionar.Size = new System.Drawing.Size(75, 23);
            this.metroTextButtonSelecionar.TabIndex = 10;
            this.metroTextButtonSelecionar.Text = "Selecionar";
            this.metroTextButtonSelecionar.UseSelectable = true;
            this.metroTextButtonSelecionar.UseVisualStyleBackColor = true;
            this.metroTextButtonSelecionar.Click += new System.EventHandler(this.metroTextButtonSelecionar_Click);
            // 
            // MoradorPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 357);
            this.Controls.Add(this.metroTextButtonSelecionar);
            this.Controls.Add(this.dataGridMorador);
            this.Controls.Add(this.textFieldPesquisarMorador);
            this.Controls.Add(this.btPesquisar);
            this.Name = "MoradorPesquisar";
            this.Text = "Pesquisar Morador";
            this.Load += new System.EventHandler(this.MoradorPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMorador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMorador;
        private MetroFramework.Controls.MetroTextBox textFieldPesquisarMorador;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btPesquisar;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonSelecionar;
    }
}