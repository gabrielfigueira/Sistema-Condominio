namespace Sistema_Condominio.View
{
    partial class RelacaoMoradorLista
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
            this.dataGridRelacaoMorador = new System.Windows.Forms.DataGridView();
            this.metroTextButtonCadastrar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelacaoMorador)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRelacaoMorador
            // 
            this.dataGridRelacaoMorador.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridRelacaoMorador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelacaoMorador.Location = new System.Drawing.Point(12, 64);
            this.dataGridRelacaoMorador.Name = "dataGridRelacaoMorador";
            this.dataGridRelacaoMorador.ReadOnly = true;
            this.dataGridRelacaoMorador.Size = new System.Drawing.Size(636, 212);
            this.dataGridRelacaoMorador.TabIndex = 10;
            // 
            // metroTextButtonCadastrar
            // 
            this.metroTextButtonCadastrar.Image = null;
            this.metroTextButtonCadastrar.Location = new System.Drawing.Point(12, 282);
            this.metroTextButtonCadastrar.Name = "metroTextButtonCadastrar";
            this.metroTextButtonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.metroTextButtonCadastrar.TabIndex = 11;
            this.metroTextButtonCadastrar.Text = "Cadastrar";
            this.metroTextButtonCadastrar.UseSelectable = true;
            this.metroTextButtonCadastrar.UseVisualStyleBackColor = true;
            // 
            // RelacaoMoradorLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 322);
            this.Controls.Add(this.metroTextButtonCadastrar);
            this.Controls.Add(this.dataGridRelacaoMorador);
            this.Name = "RelacaoMoradorLista";
            this.Text = "Parentes para Contato";
            this.Load += new System.EventHandler(this.RelacaoMoradorLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelacaoMorador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRelacaoMorador;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonCadastrar;
    }
}