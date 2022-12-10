
namespace PIM_4_sem
{
    partial class FormFuncMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncMenu));
            this.btnPesqFunc = new System.Windows.Forms.Button();
            this.btnAlterFunc = new System.Windows.Forms.Button();
            this.btnCadFunc = new System.Windows.Forms.Button();
            this.btnDelFunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPesqFunc
            // 
            this.btnPesqFunc.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPesqFunc.Image = global::PIM_4_sem.Properties.Resources.variante_de_pesquisa_de_lista;
            this.btnPesqFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesqFunc.Location = new System.Drawing.Point(590, 141);
            this.btnPesqFunc.Name = "btnPesqFunc";
            this.btnPesqFunc.Size = new System.Drawing.Size(160, 72);
            this.btnPesqFunc.TabIndex = 37;
            this.btnPesqFunc.Text = "Pesquisar";
            this.btnPesqFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesqFunc.UseVisualStyleBackColor = true;
            this.btnPesqFunc.Click += new System.EventHandler(this.btnPesqFunc_Click);
            // 
            // btnAlterFunc
            // 
            this.btnAlterFunc.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlterFunc.Image = global::PIM_4_sem.Properties.Resources.alterar;
            this.btnAlterFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterFunc.Location = new System.Drawing.Point(306, 270);
            this.btnAlterFunc.Name = "btnAlterFunc";
            this.btnAlterFunc.Size = new System.Drawing.Size(160, 72);
            this.btnAlterFunc.TabIndex = 38;
            this.btnAlterFunc.Text = "Alterar";
            this.btnAlterFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterFunc.UseVisualStyleBackColor = true;
            this.btnAlterFunc.Click += new System.EventHandler(this.btnAlterFunc_Click);
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.Font = new System.Drawing.Font("Freestyle Script", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadFunc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnCadFunc.Image")));
            this.btnCadFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadFunc.Location = new System.Drawing.Point(306, 141);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(160, 72);
            this.btnCadFunc.TabIndex = 36;
            this.btnCadFunc.Text = "Cadastrar";
            this.btnCadFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadFunc.UseVisualStyleBackColor = true;
            this.btnCadFunc.Click += new System.EventHandler(this.btnCadFunc_Click);
            // 
            // btnDelFunc
            // 
            this.btnDelFunc.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelFunc.Image = global::PIM_4_sem.Properties.Resources.deletar_usuario;
            this.btnDelFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelFunc.Location = new System.Drawing.Point(590, 270);
            this.btnDelFunc.Name = "btnDelFunc";
            this.btnDelFunc.Size = new System.Drawing.Size(160, 72);
            this.btnDelFunc.TabIndex = 39;
            this.btnDelFunc.Text = "Deletar";
            this.btnDelFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelFunc.UseVisualStyleBackColor = true;
            this.btnDelFunc.Click += new System.EventHandler(this.btnDelFunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "Menu Funcionário";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(160, 63);
            this.btnVoltar.TabIndex = 41;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormFuncMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1043, 547);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelFunc);
            this.Controls.Add(this.btnCadFunc);
            this.Controls.Add(this.btnAlterFunc);
            this.Controls.Add(this.btnPesqFunc);
            this.Name = "FormFuncMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFuncMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesqFunc;
        private System.Windows.Forms.Button btnAlterFunc;
        private System.Windows.Forms.Button btnCadFunc;
        private System.Windows.Forms.Button btnDelFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}