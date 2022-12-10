
namespace PIM_4_sem
{
    partial class cadastrarQuarto
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
            this.lblCad = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAndar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioDisponivel = new System.Windows.Forms.RadioButton();
            this.radioOcupado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCad.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCad.ForeColor = System.Drawing.Color.White;
            this.lblCad.Location = new System.Drawing.Point(481, 139);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(164, 37);
            this.lblCad.TabIndex = 147;
            this.lblCad.Text = "Cadastrar Quarto";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(415, 269);
            this.txtPreco.MaxLength = 20;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(290, 23);
            this.txtPreco.TabIndex = 143;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // txtAndar
            // 
            this.txtAndar.Location = new System.Drawing.Point(415, 211);
            this.txtAndar.MaxLength = 5;
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(290, 23);
            this.txtAndar.TabIndex = 141;
            this.txtAndar.TextChanged += new System.EventHandler(this.txtAndar_TextChanged);
            this.txtAndar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAndar_KeyPress);
            // 
            // txtQuarto
            // 
            this.txtQuarto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuarto.Location = new System.Drawing.Point(415, 182);
            this.txtQuarto.MaxLength = 5;
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(290, 23);
            this.txtQuarto.TabIndex = 136;
            this.txtQuarto.TextChanged += new System.EventHandler(this.txtQuarto_TextChanged);
            this.txtQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuarto_KeyPress);
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQuarto.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuarto.ForeColor = System.Drawing.Color.White;
            this.lblQuarto.Location = new System.Drawing.Point(156, 183);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(173, 37);
            this.lblQuarto.TabIndex = 140;
            this.lblQuarto.Text = "Número do Quarto:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPreco.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(156, 270);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(73, 37);
            this.lblPreco.TabIndex = 133;
            this.lblPreco.Text = "Preço:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStatus.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(153, 240);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 37);
            this.lblStatus.TabIndex = 131;
            this.lblStatus.Text = "Status";
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAndar.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAndar.ForeColor = System.Drawing.Color.White;
            this.lblAndar.Location = new System.Drawing.Point(153, 212);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(71, 37);
            this.lblAndar.TabIndex = 130;
            this.lblAndar.Text = "Andar:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 55);
            this.button2.TabIndex = 148;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(872, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 149;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioDisponivel
            // 
            this.radioDisponivel.AutoSize = true;
            this.radioDisponivel.Location = new System.Drawing.Point(415, 243);
            this.radioDisponivel.Name = "radioDisponivel";
            this.radioDisponivel.Size = new System.Drawing.Size(80, 19);
            this.radioDisponivel.TabIndex = 150;
            this.radioDisponivel.TabStop = true;
            this.radioDisponivel.Text = "Disponivel";
            this.radioDisponivel.UseVisualStyleBackColor = true;
            // 
            // radioOcupado
            // 
            this.radioOcupado.AutoSize = true;
            this.radioOcupado.Location = new System.Drawing.Point(558, 244);
            this.radioOcupado.Name = "radioOcupado";
            this.radioOcupado.Size = new System.Drawing.Size(74, 19);
            this.radioOcupado.TabIndex = 151;
            this.radioOcupado.TabStop = true;
            this.radioOcupado.Text = "Ocupado";
            this.radioOcupado.UseVisualStyleBackColor = true;
            // 
            // cadastrarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1043, 547);
            this.Controls.Add(this.radioOcupado);
            this.Controls.Add(this.radioDisponivel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCad);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtAndar);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAndar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "cadastrarQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastrarQuarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioDisponivel;
        private System.Windows.Forms.RadioButton radioOcupado;
    }
}