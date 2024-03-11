namespace calc2._0
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
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.buttonlimparc = new System.Windows.Forms.Button();
            this.btnadicao = new System.Windows.Forms.Button();
            this.btnsubtracao = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.btnmultiplicacao = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnvirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(12, 12);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(279, 78);
            this.txtresultado.TabIndex = 35;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtresultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonlimparc
            // 
            this.buttonlimparc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlimparc.Location = new System.Drawing.Point(297, 12);
            this.buttonlimparc.Name = "buttonlimparc";
            this.buttonlimparc.Size = new System.Drawing.Size(89, 80);
            this.buttonlimparc.TabIndex = 34;
            this.buttonlimparc.Text = "C";
            this.buttonlimparc.UseVisualStyleBackColor = true;
            this.buttonlimparc.Click += new System.EventHandler(this.buttonlimparc_Click);
            // 
            // btnadicao
            // 
            this.btnadicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicao.Location = new System.Drawing.Point(297, 365);
            this.btnadicao.Name = "btnadicao";
            this.btnadicao.Size = new System.Drawing.Size(89, 83);
            this.btnadicao.TabIndex = 33;
            this.btnadicao.Text = "+";
            this.btnadicao.UseVisualStyleBackColor = true;
            this.btnadicao.Click += new System.EventHandler(this.btnadicao_Click);
            // 
            // btnsubtracao
            // 
            this.btnsubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtracao.Location = new System.Drawing.Point(297, 276);
            this.btnsubtracao.Name = "btnsubtracao";
            this.btnsubtracao.Size = new System.Drawing.Size(89, 83);
            this.btnsubtracao.TabIndex = 32;
            this.btnsubtracao.Text = "-";
            this.btnsubtracao.UseVisualStyleBackColor = true;
            this.btnsubtracao.Click += new System.EventHandler(this.btnsubtracao_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivisao.Location = new System.Drawing.Point(297, 187);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(89, 83);
            this.btndivisao.TabIndex = 31;
            this.btndivisao.Text = "/";
            this.btndivisao.UseVisualStyleBackColor = true;
            this.btndivisao.Click += new System.EventHandler(this.btndivisao_Click);
            // 
            // btnmultiplicacao
            // 
            this.btnmultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacao.Location = new System.Drawing.Point(297, 98);
            this.btnmultiplicacao.Name = "btnmultiplicacao";
            this.btnmultiplicacao.Size = new System.Drawing.Size(89, 83);
            this.btnmultiplicacao.TabIndex = 30;
            this.btnmultiplicacao.Text = "x";
            this.btnmultiplicacao.UseVisualStyleBackColor = true;
            this.btnmultiplicacao.Click += new System.EventHandler(this.btnmultiplicacao_Click);
            // 
            // btnigual
            // 
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(202, 365);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(89, 83);
            this.btnigual.TabIndex = 29;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnvirgula
            // 
            this.btnvirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvirgula.Location = new System.Drawing.Point(12, 365);
            this.btnvirgula.Name = "btnvirgula";
            this.btnvirgula.Size = new System.Drawing.Size(89, 83);
            this.btnvirgula.TabIndex = 28;
            this.btnvirgula.Text = ",";
            this.btnvirgula.UseVisualStyleBackColor = true;
            this.btnvirgula.Click += new System.EventHandler(this.btnvirgula_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(107, 365);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(89, 83);
            this.btn0.TabIndex = 27;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(202, 276);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(89, 83);
            this.btn3.TabIndex = 26;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(107, 276);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(89, 83);
            this.btn2.TabIndex = 25;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 276);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(89, 83);
            this.btn1.TabIndex = 24;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(202, 187);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(89, 83);
            this.btn6.TabIndex = 23;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(107, 187);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(89, 83);
            this.btn5.TabIndex = 22;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 187);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(89, 83);
            this.btn4.TabIndex = 21;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(202, 98);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(89, 83);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(107, 98);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(89, 83);
            this.btn8.TabIndex = 19;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 98);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(89, 83);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacao.Location = new System.Drawing.Point(15, 15);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(0, 72);
            this.lbloperacao.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 456);
            this.Controls.Add(this.lbloperacao);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.buttonlimparc);
            this.Controls.Add(this.btnadicao);
            this.Controls.Add(this.btnsubtracao);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btnmultiplicacao);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnvirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button buttonlimparc;
        private System.Windows.Forms.Button btnadicao;
        private System.Windows.Forms.Button btnsubtracao;
        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.Button btnmultiplicacao;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnvirgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label lbloperacao;
    }
}

