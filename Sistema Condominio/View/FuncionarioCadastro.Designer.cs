﻿namespace Sistema_Condominio.View
{
    partial class FuncionarioCadastro
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.btCadastrarUnidade = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btPesquisar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbPessoa = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 70);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Nome: ";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 124);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Atividades: ";
            // 
            // tbDescricao
            // 
            // 
            // 
            // 
            this.tbDescricao.CustomButton.Image = null;
            this.tbDescricao.CustomButton.Location = new System.Drawing.Point(329, 2);
            this.tbDescricao.CustomButton.Name = "";
            this.tbDescricao.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.tbDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescricao.CustomButton.TabIndex = 1;
            this.tbDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescricao.CustomButton.UseSelectable = true;
            this.tbDescricao.CustomButton.Visible = false;
            this.tbDescricao.Lines = new string[0];
            this.tbDescricao.Location = new System.Drawing.Point(105, 124);
            this.tbDescricao.MaxLength = 32767;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.PasswordChar = '\0';
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescricao.SelectedText = "";
            this.tbDescricao.SelectionLength = 0;
            this.tbDescricao.SelectionStart = 0;
            this.tbDescricao.Size = new System.Drawing.Size(387, 60);
            this.tbDescricao.TabIndex = 35;
            this.tbDescricao.UseSelectable = true;
            this.tbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btCadastrarUnidade
            // 
            this.btCadastrarUnidade.Image = null;
            this.btCadastrarUnidade.Location = new System.Drawing.Point(378, 190);
            this.btCadastrarUnidade.Name = "btCadastrarUnidade";
            this.btCadastrarUnidade.Size = new System.Drawing.Size(114, 23);
            this.btCadastrarUnidade.TabIndex = 36;
            this.btCadastrarUnidade.Text = "Salvar";
            this.btCadastrarUnidade.UseSelectable = true;
            this.btCadastrarUnidade.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = null;
            this.btPesquisar.Location = new System.Drawing.Point(414, 70);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 38;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseSelectable = true;
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // tbPessoa
            // 
            // 
            // 
            // 
            this.tbPessoa.CustomButton.Image = null;
            this.tbPessoa.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.tbPessoa.CustomButton.Name = "";
            this.tbPessoa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPessoa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPessoa.CustomButton.TabIndex = 1;
            this.tbPessoa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPessoa.CustomButton.UseSelectable = true;
            this.tbPessoa.CustomButton.Visible = false;
            this.tbPessoa.Enabled = false;
            this.tbPessoa.Lines = new string[0];
            this.tbPessoa.Location = new System.Drawing.Point(105, 70);
            this.tbPessoa.MaxLength = 32767;
            this.tbPessoa.Name = "tbPessoa";
            this.tbPessoa.PasswordChar = '\0';
            this.tbPessoa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPessoa.SelectedText = "";
            this.tbPessoa.SelectionLength = 0;
            this.tbPessoa.SelectionStart = 0;
            this.tbPessoa.Size = new System.Drawing.Size(303, 23);
            this.tbPessoa.TabIndex = 37;
            this.tbPessoa.UseSelectable = true;
            this.tbPessoa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPessoa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FuncionarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 255);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbPessoa);
            this.Controls.Add(this.btCadastrarUnidade);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel6);
            this.Name = "FuncionarioCadastro";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.FuncionarioCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btCadastrarUnidade;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btPesquisar;
        private MetroFramework.Controls.MetroTextBox tbPessoa;
    }
}