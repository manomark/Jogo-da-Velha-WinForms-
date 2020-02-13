namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnb1 = new System.Windows.Forms.Button();
            this.btnc1 = new System.Windows.Forms.Button();
            this.btna1 = new System.Windows.Forms.Button();
            this.btna2 = new System.Windows.Forms.Button();
            this.btnc2 = new System.Windows.Forms.Button();
            this.btnb2 = new System.Windows.Forms.Button();
            this.btna3 = new System.Windows.Forms.Button();
            this.btnc3 = new System.Windows.Forms.Button();
            this.btnb3 = new System.Windows.Forms.Button();
            this.msg_Winner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnb1
            // 
            this.btnb1.Location = new System.Drawing.Point(292, 173);
            this.btnb1.Name = "btnb1";
            this.btnb1.Size = new System.Drawing.Size(45, 47);
            this.btnb1.TabIndex = 1;
            this.btnb1.UseVisualStyleBackColor = true;
            this.btnb1.Click += new System.EventHandler(this.btnb1_Click);
            // 
            // btnc1
            // 
            this.btnc1.Location = new System.Drawing.Point(292, 226);
            this.btnc1.Name = "btnc1";
            this.btnc1.Size = new System.Drawing.Size(45, 47);
            this.btnc1.TabIndex = 8;
            this.btnc1.UseVisualStyleBackColor = true;
            this.btnc1.Click += new System.EventHandler(this.btnc1_Click);
            // 
            // btna1
            // 
            this.btna1.Location = new System.Drawing.Point(292, 120);
            this.btna1.Name = "btna1";
            this.btna1.Size = new System.Drawing.Size(45, 47);
            this.btna1.TabIndex = 9;
            this.btna1.UseVisualStyleBackColor = true;
            this.btna1.Click += new System.EventHandler(this.btna1_Click);
            // 
            // btna2
            // 
            this.btna2.Location = new System.Drawing.Point(343, 120);
            this.btna2.Name = "btna2";
            this.btna2.Size = new System.Drawing.Size(45, 47);
            this.btna2.TabIndex = 12;
            this.btna2.UseVisualStyleBackColor = true;
            this.btna2.Click += new System.EventHandler(this.btna2_Click);
            // 
            // btnc2
            // 
            this.btnc2.Location = new System.Drawing.Point(343, 226);
            this.btnc2.Name = "btnc2";
            this.btnc2.Size = new System.Drawing.Size(45, 47);
            this.btnc2.TabIndex = 11;
            this.btnc2.UseVisualStyleBackColor = true;
            this.btnc2.Click += new System.EventHandler(this.btnc2_Click);
            // 
            // btnb2
            // 
            this.btnb2.Location = new System.Drawing.Point(343, 173);
            this.btnb2.Name = "btnb2";
            this.btnb2.Size = new System.Drawing.Size(45, 47);
            this.btnb2.TabIndex = 10;
            this.btnb2.UseVisualStyleBackColor = true;
            this.btnb2.Click += new System.EventHandler(this.btnb2_Click);
            // 
            // btna3
            // 
            this.btna3.Location = new System.Drawing.Point(394, 120);
            this.btna3.Name = "btna3";
            this.btna3.Size = new System.Drawing.Size(45, 47);
            this.btna3.TabIndex = 15;
            this.btna3.UseVisualStyleBackColor = true;
            this.btna3.Click += new System.EventHandler(this.btna3_Click);
            // 
            // btnc3
            // 
            this.btnc3.Location = new System.Drawing.Point(394, 226);
            this.btnc3.Name = "btnc3";
            this.btnc3.Size = new System.Drawing.Size(45, 47);
            this.btnc3.TabIndex = 14;
            this.btnc3.UseVisualStyleBackColor = true;
            this.btnc3.Click += new System.EventHandler(this.btnc3_Click);
            // 
            // btnb3
            // 
            this.btnb3.Location = new System.Drawing.Point(394, 173);
            this.btnb3.Name = "btnb3";
            this.btnb3.Size = new System.Drawing.Size(45, 47);
            this.btnb3.TabIndex = 13;
            this.btnb3.UseVisualStyleBackColor = true;
            this.btnb3.Click += new System.EventHandler(this.btnb3_Click);
            // 
            // msg_Winner
            // 
            this.msg_Winner.AutoSize = true;
            this.msg_Winner.Location = new System.Drawing.Point(330, 294);
            this.msg_Winner.Name = "msg_Winner";
            this.msg_Winner.Size = new System.Drawing.Size(67, 13);
            this.msg_Winner.TabIndex = 16;
            this.msg_Winner.Text = "VENCEDOR";
            this.msg_Winner.Click += new System.EventHandler(this.msg_Winner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msg_Winner);
            this.Controls.Add(this.btna3);
            this.Controls.Add(this.btnc3);
            this.Controls.Add(this.btnb3);
            this.Controls.Add(this.btna2);
            this.Controls.Add(this.btnc2);
            this.Controls.Add(this.btnb2);
            this.Controls.Add(this.btna1);
            this.Controls.Add(this.btnc1);
            this.Controls.Add(this.btnb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnb1;
        private System.Windows.Forms.Button btnc1;
        private System.Windows.Forms.Button btna1;
        private System.Windows.Forms.Button btna2;
        private System.Windows.Forms.Button btnc2;
        private System.Windows.Forms.Button btnb2;
        private System.Windows.Forms.Button btna3;
        private System.Windows.Forms.Button btnc3;
        private System.Windows.Forms.Button btnb3;
        private System.Windows.Forms.Label msg_Winner;
    }
}

