namespace Sistema_Condominio.View
{
    partial class VisitaLista
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
            this.dataGridRelacaoVisita = new System.Windows.Forms.DataGridView();
            this.textButtonExcluir = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonCadastrar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelacaoVisita)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRelacaoVisita
            // 
            this.dataGridRelacaoVisita.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridRelacaoVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelacaoVisita.Location = new System.Drawing.Point(13, 63);
            this.dataGridRelacaoVisita.Name = "dataGridRelacaoVisita";
            this.dataGridRelacaoVisita.ReadOnly = true;
            this.dataGridRelacaoVisita.Size = new System.Drawing.Size(636, 212);
            this.dataGridRelacaoVisita.TabIndex = 11;
            // 
            // textButtonExcluir
            // 
            this.textButtonExcluir.Image = null;
            this.textButtonExcluir.Location = new System.Drawing.Point(114, 281);
            this.textButtonExcluir.Name = "textButtonExcluir";
            this.textButtonExcluir.Size = new System.Drawing.Size(75, 23);
            this.textButtonExcluir.TabIndex = 15;
            this.textButtonExcluir.Text = "Excluir";
            this.textButtonExcluir.UseSelectable = true;
            this.textButtonExcluir.UseVisualStyleBackColor = true;
            this.textButtonExcluir.Click += new System.EventHandler(this.textButtonExcluir_Click);
            // 
            // metroTextButtonCadastrar
            // 
            this.metroTextButtonCadastrar.Image = null;
            this.metroTextButtonCadastrar.Location = new System.Drawing.Point(13, 281);
            this.metroTextButtonCadastrar.Name = "metroTextButtonCadastrar";
            this.metroTextButtonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.metroTextButtonCadastrar.TabIndex = 14;
            this.metroTextButtonCadastrar.Text = "Cadastrar";
            this.metroTextButtonCadastrar.UseSelectable = true;
            this.metroTextButtonCadastrar.UseVisualStyleBackColor = true;
            this.metroTextButtonCadastrar.Click += new System.EventHandler(this.metroTextButtonCadastrar_Click);
            // 
            // VisitaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 312);
            this.Controls.Add(this.textButtonExcluir);
            this.Controls.Add(this.metroTextButtonCadastrar);
            this.Controls.Add(this.dataGridRelacaoVisita);
            this.Name = "VisitaLista";
            this.Text = "Listas de Visitantes do Morador";
            this.Load += new System.EventHandler(this.VisitaLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelacaoVisita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRelacaoVisita;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton textButtonExcluir;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonCadastrar;
    }
}