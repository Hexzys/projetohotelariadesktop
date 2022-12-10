
namespace PIM_4_sem
{
    partial class cadReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.lblReserva = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.txtHospede = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHospedes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 150;
            this.label1.Text = "Cadastrar Reserva:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 14);
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
            this.button1.Location = new System.Drawing.Point(885, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 149;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(439, 282);
            this.txtData.MaxLength = 60;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(290, 23);
            this.txtData.TabIndex = 143;
            // 
            // txtReserva
            // 
            this.txtReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReserva.Location = new System.Drawing.Point(439, 192);
            this.txtReserva.MaxLength = 20;
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(290, 23);
            this.txtReserva.TabIndex = 138;
            this.txtReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReserva_KeyPress);
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblReserva.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReserva.ForeColor = System.Drawing.Color.White;
            this.lblReserva.Location = new System.Drawing.Point(198, 192);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(185, 37);
            this.lblReserva.TabIndex = 142;
            this.lblReserva.Text = "Número da Reserva:";
            // 
            // txtQuarto
            // 
            this.txtQuarto.Location = new System.Drawing.Point(439, 220);
            this.txtQuarto.MaxLength = 10;
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(290, 23);
            this.txtQuarto.TabIndex = 140;
            this.txtQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuarto_KeyPress);
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQuarto.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuarto.ForeColor = System.Drawing.Color.White;
            this.lblQuarto.Location = new System.Drawing.Point(198, 220);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(173, 37);
            this.lblQuarto.TabIndex = 139;
            this.lblQuarto.Text = "Número do Quarto:";
            // 
            // txtHospede
            // 
            this.txtHospede.Location = new System.Drawing.Point(439, 250);
            this.txtHospede.MaxLength = 60;
            this.txtHospede.Name = "txtHospede";
            this.txtHospede.Size = new System.Drawing.Size(290, 23);
            this.txtHospede.TabIndex = 141;
            this.txtHospede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHospede_KeyPress);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblData.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(198, 283);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(157, 37);
            this.lblData.TabIndex = 133;
            this.lblData.Text = "Data Reservada:";
            // 
            // lblHospedes
            // 
            this.lblHospedes.AutoSize = true;
            this.lblHospedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHospedes.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHospedes.ForeColor = System.Drawing.Color.White;
            this.lblHospedes.Location = new System.Drawing.Point(198, 251);
            this.lblHospedes.Name = "lblHospedes";
            this.lblHospedes.Size = new System.Drawing.Size(215, 37);
            this.lblHospedes.TabIndex = 131;
            this.lblHospedes.Text = "Quantidade de Hóspedes:";
            // 
            // cadReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1043, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.txtHospede);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHospedes);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "cadReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.TextBox txtHospede;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHospedes;
    }
}