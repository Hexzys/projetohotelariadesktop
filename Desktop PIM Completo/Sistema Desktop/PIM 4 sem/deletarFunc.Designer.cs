﻿
namespace PIM_4_sem
{
    partial class deletarFunc
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
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunc
            // 
            this.dgvFunc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(12, 120);
            this.dgvFunc.MultiSelect = false;
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.RowTemplate.Height = 25;
            this.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunc.Size = new System.Drawing.Size(909, 398);
            this.dgvFunc.TabIndex = 48;
            this.dgvFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellContentClick);
            this.dgvFunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFunc_MouseDoubleClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 27);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 42);
            this.btnVoltar.TabIndex = 47;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Deletar Funcionário:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(407, 36);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(319, 23);
            this.txtBusca.TabIndex = 45;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(927, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 53);
            this.button1.TabIndex = 49;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCod.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCod.ForeColor = System.Drawing.Color.White;
            this.lblCod.Location = new System.Drawing.Point(368, 78);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(0, 37);
            this.lblCod.TabIndex = 119;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCodigo.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(282, 76);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 37);
            this.lblCodigo.TabIndex = 118;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // deletarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1043, 530);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Name = "deletarFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deletarFunc";
            this.Load += new System.EventHandler(this.deletarFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblCodigo;
    }
}