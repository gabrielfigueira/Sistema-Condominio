namespace Sistema_Condominio.View
{
    partial class MoradorUnidadeLista
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
            this.btExcluir = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btCadastrar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.dataGridMoradorUnidade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoradorUnidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.Image = null;
            this.btExcluir.Location = new System.Drawing.Point(124, 281);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 18;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseSelectable = true;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Image = null;
            this.btCadastrar.Location = new System.Drawing.Point(23, 281);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 17;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseSelectable = true;
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // dataGridMoradorUnidade
            // 
            this.dataGridMoradorUnidade.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridMoradorUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMoradorUnidade.Location = new System.Drawing.Point(23, 63);
            this.dataGridMoradorUnidade.Name = "dataGridMoradorUnidade";
            this.dataGridMoradorUnidade.ReadOnly = true;
            this.dataGridMoradorUnidade.Size = new System.Drawing.Size(550, 212);
            this.dataGridMoradorUnidade.TabIndex = 16;
            // 
            // MoradorUnidadeLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 333);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dataGridMoradorUnidade);
            this.Name = "MoradorUnidadeLista";
            this.Text = "Unidades do Morador";
            this.Load += new System.EventHandler(this.MoradorUnidadeLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoradorUnidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btExcluir;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btCadastrar;
        private System.Windows.Forms.DataGridView dataGridMoradorUnidade;
    }
}