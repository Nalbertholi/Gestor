﻿namespace WindowsFormsAppPrincipal
{
    partial class FormConsultaCliente
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
            this.components = new System.ComponentModel.Container();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(0, 121);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.RowHeadersWidth = 51;
            this.clienteDataGridView.RowTemplate.Height = 24;
            this.clienteDataGridView.Size = new System.Drawing.Size(833, 288);
            this.clienteDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RG";
            this.dataGridViewTextBoxColumn4.HeaderText = "RG";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(846, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(132, 83);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(377, 22);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar por";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(515, 83);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(596, 415);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(108, 23);
            this.buttonSelecionar.TabIndex = 6;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(726, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(677, 83);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 8;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(758, 82);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(596, 83);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "CPF",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(8, 81);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(118, 24);
            this.comboBoxBuscarPor.TabIndex = 11;
            // 
            // FormConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteDataGridView);
            this.Name = "FormConsultaCliente";
            this.Text = "FormConsultaCliente";
            this.Load += new System.EventHandler(this.FormConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
    }
}