﻿namespace Portaria.Locais
{
    partial class TabReservarLocais
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpLocais = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsReservas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // flpLocais
            // 
            this.flpLocais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLocais.Location = new System.Drawing.Point(3, 3);
            this.flpLocais.Name = "flpLocais";
            this.flpLocais.Size = new System.Drawing.Size(635, 230);
            this.flpLocais.TabIndex = 0;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservas.AutoGenerateColumns = false;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.dataHoraDataGridViewTextBoxColumn,
            this.dataHoraInicioDataGridViewTextBoxColumn,
            this.dataHoraFimDataGridViewTextBoxColumn,
            this.pessoaDataGridViewTextBoxColumn,
            this.sessaoDataGridViewTextBoxColumn});
            this.dgvReservas.DataSource = this.bsReservas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.Location = new System.Drawing.Point(3, 271);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(635, 143);
            this.dgvReservas.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "Data Reserva";
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            this.dataHoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataHoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataHoraInicioDataGridViewTextBoxColumn
            // 
            this.dataHoraInicioDataGridViewTextBoxColumn.DataPropertyName = "DataHoraInicio";
            this.dataHoraInicioDataGridViewTextBoxColumn.HeaderText = "Inicio reserva";
            this.dataHoraInicioDataGridViewTextBoxColumn.Name = "dataHoraInicioDataGridViewTextBoxColumn";
            this.dataHoraInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraFimDataGridViewTextBoxColumn
            // 
            this.dataHoraFimDataGridViewTextBoxColumn.DataPropertyName = "DataHoraFim";
            this.dataHoraFimDataGridViewTextBoxColumn.HeaderText = "Final reserva";
            this.dataHoraFimDataGridViewTextBoxColumn.Name = "dataHoraFimDataGridViewTextBoxColumn";
            this.dataHoraFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pessoaDataGridViewTextBoxColumn
            // 
            this.pessoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pessoaDataGridViewTextBoxColumn.DataPropertyName = "Pessoa";
            this.pessoaDataGridViewTextBoxColumn.HeaderText = "Pessoa";
            this.pessoaDataGridViewTextBoxColumn.Name = "pessoaDataGridViewTextBoxColumn";
            this.pessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessaoDataGridViewTextBoxColumn
            // 
            this.sessaoDataGridViewTextBoxColumn.DataPropertyName = "Sessao";
            this.sessaoDataGridViewTextBoxColumn.HeaderText = "Sessao";
            this.sessaoDataGridViewTextBoxColumn.Name = "sessaoDataGridViewTextBoxColumn";
            this.sessaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sessaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsReservas
            // 
            this.bsReservas.DataSource = typeof(Portaria.Core.Model.Reserva);
            // 
            // TabReservarLocais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.flpLocais);
            this.Name = "TabReservarLocais";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLocais;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.BindingSource bsReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessaoDataGridViewTextBoxColumn;
    }
}
