namespace AppCalculaMedia
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.DtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.TxtNota4 = new System.Windows.Forms.TextBox();
            this.BtnExecutar = new System.Windows.Forms.Button();
            this.LblMedia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblNome.Location = new System.Drawing.Point(185, 53);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(44, 16);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome";
            // 
            // DtData
            // 
            this.DtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtData.Location = new System.Drawing.Point(430, 53);
            this.DtData.Name = "DtData";
            this.DtData.Size = new System.Drawing.Size(103, 20);
            this.DtData.TabIndex = 2;
            this.DtData.Value = new System.DateTime(2019, 4, 24, 11, 4, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nota 4";
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(178, 123);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(100, 20);
            this.TxtNota1.TabIndex = 7;
            this.TxtNota1.Text = "0";
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(178, 179);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(100, 20);
            this.TxtNota2.TabIndex = 8;
            this.TxtNota2.Text = "0";
            // 
            // TxtNota3
            // 
            this.TxtNota3.Location = new System.Drawing.Point(178, 235);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(100, 20);
            this.TxtNota3.TabIndex = 9;
            this.TxtNota3.Text = "0";
            // 
            // TxtNota4
            // 
            this.TxtNota4.Location = new System.Drawing.Point(178, 287);
            this.TxtNota4.Name = "TxtNota4";
            this.TxtNota4.Size = new System.Drawing.Size(100, 20);
            this.TxtNota4.TabIndex = 10;
            this.TxtNota4.Text = "0";
            // 
            // BtnExecutar
            // 
            this.BtnExecutar.Location = new System.Drawing.Point(178, 339);
            this.BtnExecutar.Name = "BtnExecutar";
            this.BtnExecutar.Size = new System.Drawing.Size(100, 23);
            this.BtnExecutar.TabIndex = 11;
            this.BtnExecutar.Text = "Executar";
            this.BtnExecutar.UseVisualStyleBackColor = true;
            this.BtnExecutar.Click += new System.EventHandler(this.BtnExecutar_Click);
            // 
            // LblMedia
            // 
            this.LblMedia.AutoSize = true;
            this.LblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblMedia.Location = new System.Drawing.Point(185, 387);
            this.LblMedia.Name = "LblMedia";
            this.LblMedia.Size = new System.Drawing.Size(14, 16);
            this.LblMedia.TabIndex = 14;
            this.LblMedia.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Média:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Situação:";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblStatus.Location = new System.Drawing.Point(185, 422);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(16, 16);
            this.LblStatus.TabIndex = 16;
            this.LblStatus.Text = "...";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 468);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblMedia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnExecutar);
            this.Controls.Add(this.TxtNota4);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtData);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EAD CSharp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DateTimePicker DtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.TextBox TxtNota4;
        private System.Windows.Forms.Button BtnExecutar;
        private System.Windows.Forms.Label LblMedia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblStatus;
    }
}

