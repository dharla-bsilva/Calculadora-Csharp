namespace Calculadora
{
    partial class frmCalculadoraGorjeta
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
            this.lblConta = new System.Windows.Forms.Label();
            this.txtValorConta = new System.Windows.Forms.TextBox();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.cbbQualidade = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblGorjeta = new System.Windows.Forms.Label();
            this.txtGorjeta = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblCalculadoraDeGorjeta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(134, 58);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(124, 20);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "Valor  da conta :";
            // 
            // txtValorConta
            // 
            this.txtValorConta.Location = new System.Drawing.Point(160, 99);
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(379, 20);
            this.txtValorConta.TabIndex = 1;
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidade.Location = new System.Drawing.Point(134, 136);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(167, 20);
            this.lblQualidade.TabIndex = 2;
            this.lblQualidade.Text = "Qualidade do Serviço :";
            // 
            // cbbQualidade
            // 
            this.cbbQualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQualidade.FormattingEnabled = true;
            this.cbbQualidade.Items.AddRange(new object[] {
            "Excelente - 10%",
            "Ótimo - 8%",
            "Bom - 5%",
            "Ruim - 2%"});
            this.cbbQualidade.Location = new System.Drawing.Point(160, 178);
            this.cbbQualidade.Name = "cbbQualidade";
            this.cbbQualidade.Size = new System.Drawing.Size(379, 28);
            this.cbbQualidade.TabIndex = 3;
           
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(78, 247);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(239, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Gorjeta";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblGorjeta
            // 
            this.lblGorjeta.AutoSize = true;
            this.lblGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGorjeta.Location = new System.Drawing.Point(134, 298);
            this.lblGorjeta.Name = "lblGorjeta";
            this.lblGorjeta.Size = new System.Drawing.Size(70, 20);
            this.lblGorjeta.TabIndex = 5;
            this.lblGorjeta.Text = "Gorjeta :";
            // 
            // txtGorjeta
            // 
            this.txtGorjeta.Location = new System.Drawing.Point(160, 332);
            this.txtGorjeta.Name = "txtGorjeta";
            this.txtGorjeta.Size = new System.Drawing.Size(379, 20);
            this.txtGorjeta.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(134, 368);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Valor Total :";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(160, 405);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(379, 20);
            this.txtValorTotal.TabIndex = 8;
            // 
            // lblCalculadoraDeGorjeta
            // 
            this.lblCalculadoraDeGorjeta.AutoSize = true;
            this.lblCalculadoraDeGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadoraDeGorjeta.Location = new System.Drawing.Point(302, 9);
            this.lblCalculadoraDeGorjeta.Name = "lblCalculadoraDeGorjeta";
            this.lblCalculadoraDeGorjeta.Size = new System.Drawing.Size(194, 20);
            this.lblCalculadoraDeGorjeta.TabIndex = 9;
            this.lblCalculadoraDeGorjeta.Text = "Calculadora de Gorjeta";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(460, 247);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(203, 30);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // frmCalculadoraGorjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblCalculadoraDeGorjeta);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtGorjeta);
            this.Controls.Add(this.lblGorjeta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbbQualidade);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.txtValorConta);
            this.Controls.Add(this.lblConta);
            this.Name = "frmCalculadoraGorjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtValorConta;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.ComboBox cbbQualidade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblGorjeta;
        private System.Windows.Forms.TextBox txtGorjeta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblCalculadoraDeGorjeta;
        private System.Windows.Forms.Button btnLimpar;
    }
}