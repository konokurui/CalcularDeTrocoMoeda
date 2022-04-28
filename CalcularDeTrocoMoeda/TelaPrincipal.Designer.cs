
namespace CalcularDeTrocoMoeda
{
    partial class TelaPrincipal
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
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.lblMoeda01 = new System.Windows.Forms.Label();
            this.lblqtdMoeda025 = new System.Windows.Forms.Label();
            this.lblMoeda10 = new System.Windows.Forms.Label();
            this.lblqtdMoeda010 = new System.Windows.Forms.Label();
            this.lblqtdMoeda100 = new System.Windows.Forms.Label();
            this.lblMoeda25 = new System.Windows.Forms.Label();
            this.lblMoeda50 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMoeda05 = new System.Windows.Forms.Label();
            this.lblMoeda100 = new System.Windows.Forms.Label();
            this.lblqtdMoeda050 = new System.Windows.Forms.Label();
            this.lblResultadoTroco = new System.Windows.Forms.Label();
            this.lblqtdMoeda005 = new System.Windows.Forms.Label();
            this.lblqtdMoeda001 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbtValorCompra = new System.Windows.Forms.TextBox();
            this.tbtValorPago = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(33, 56);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(93, 15);
            this.lblCompra.TabIndex = 0;
            this.lblCompra.Text = "Valor da compra";
            this.lblCompra.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(33, 105);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(133, 15);
            this.lblDinheiro.TabIndex = 1;
            this.lblDinheiro.Text = "Valor pado em dinheiro:";
            // 
            // lblMoeda01
            // 
            this.lblMoeda01.AutoSize = true;
            this.lblMoeda01.Location = new System.Drawing.Point(526, 135);
            this.lblMoeda01.Name = "lblMoeda01";
            this.lblMoeda01.Size = new System.Drawing.Size(13, 15);
            this.lblMoeda01.TabIndex = 2;
            this.lblMoeda01.Text = "0";
            // 
            // lblqtdMoeda025
            // 
            this.lblqtdMoeda025.AutoSize = true;
            this.lblqtdMoeda025.Location = new System.Drawing.Point(582, 219);
            this.lblqtdMoeda025.Name = "lblqtdMoeda025";
            this.lblqtdMoeda025.Size = new System.Drawing.Size(105, 15);
            this.lblqtdMoeda025.TabIndex = 3;
            this.lblqtdMoeda025.Text = "moedas de R$ 0,25";
            // 
            // lblMoeda10
            // 
            this.lblMoeda10.AutoSize = true;
            this.lblMoeda10.Location = new System.Drawing.Point(526, 193);
            this.lblMoeda10.Name = "lblMoeda10";
            this.lblMoeda10.Size = new System.Drawing.Size(13, 15);
            this.lblMoeda10.TabIndex = 4;
            this.lblMoeda10.Text = "0";
            // 
            // lblqtdMoeda010
            // 
            this.lblqtdMoeda010.AutoSize = true;
            this.lblqtdMoeda010.Location = new System.Drawing.Point(582, 193);
            this.lblqtdMoeda010.Name = "lblqtdMoeda010";
            this.lblqtdMoeda010.Size = new System.Drawing.Size(105, 15);
            this.lblqtdMoeda010.TabIndex = 5;
            this.lblqtdMoeda010.Text = "moedas de R$ 0,10";
            // 
            // lblqtdMoeda100
            // 
            this.lblqtdMoeda100.AutoSize = true;
            this.lblqtdMoeda100.Location = new System.Drawing.Point(582, 277);
            this.lblqtdMoeda100.Name = "lblqtdMoeda100";
            this.lblqtdMoeda100.Size = new System.Drawing.Size(105, 15);
            this.lblqtdMoeda100.TabIndex = 6;
            this.lblqtdMoeda100.Text = "moedas de R$ 1,00";
            // 
            // lblMoeda25
            // 
            this.lblMoeda25.AutoSize = true;
            this.lblMoeda25.Location = new System.Drawing.Point(526, 219);
            this.lblMoeda25.Name = "lblMoeda25";
            this.lblMoeda25.Size = new System.Drawing.Size(13, 15);
            this.lblMoeda25.TabIndex = 7;
            this.lblMoeda25.Text = "0";
            // 
            // lblMoeda50
            // 
            this.lblMoeda50.AutoSize = true;
            this.lblMoeda50.Location = new System.Drawing.Point(526, 249);
            this.lblMoeda50.Name = "lblMoeda50";
            this.lblMoeda50.Size = new System.Drawing.Size(13, 15);
            this.lblMoeda50.TabIndex = 8;
            this.lblMoeda50.Text = "0";
            this.lblMoeda50.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(444, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(311, 40);
            this.label11.TabIndex = 10;
            this.label11.Text = "MOEDAS PARA TROCO";
            // 
            // lblMoeda05
            // 
            this.lblMoeda05.AutoSize = true;
            this.lblMoeda05.Location = new System.Drawing.Point(526, 167);
            this.lblMoeda05.Name = "lblMoeda05";
            this.lblMoeda05.Size = new System.Drawing.Size(13, 15);
            this.lblMoeda05.TabIndex = 11;
            this.lblMoeda05.Text = "0";
            // 
            // lblMoeda100
            // 
            this.lblMoeda100.AutoSize = true;
            this.lblMoeda100.Location = new System.Drawing.Point(526, 277);
            this.lblMoeda100.Name = "lblMoeda100";
            this.lblMoeda100.Size = new System.Drawing.Size(13, 15);
            this.lblMoeda100.TabIndex = 12;
            this.lblMoeda100.Text = "0";
            // 
            // lblqtdMoeda050
            // 
            this.lblqtdMoeda050.AutoSize = true;
            this.lblqtdMoeda050.Location = new System.Drawing.Point(582, 249);
            this.lblqtdMoeda050.Name = "lblqtdMoeda050";
            this.lblqtdMoeda050.Size = new System.Drawing.Size(105, 15);
            this.lblqtdMoeda050.TabIndex = 13;
            this.lblqtdMoeda050.Text = "moedas de R$ 0,50";
            // 
            // lblResultadoTroco
            // 
            this.lblResultadoTroco.AutoSize = true;
            this.lblResultadoTroco.Location = new System.Drawing.Point(172, 167);
            this.lblResultadoTroco.Name = "lblResultadoTroco";
            this.lblResultadoTroco.Size = new System.Drawing.Size(13, 15);
            this.lblResultadoTroco.TabIndex = 14;
            this.lblResultadoTroco.Text = "0";
            // 
            // lblqtdMoeda005
            // 
            this.lblqtdMoeda005.AutoSize = true;
            this.lblqtdMoeda005.Location = new System.Drawing.Point(582, 167);
            this.lblqtdMoeda005.Name = "lblqtdMoeda005";
            this.lblqtdMoeda005.Size = new System.Drawing.Size(105, 15);
            this.lblqtdMoeda005.TabIndex = 15;
            this.lblqtdMoeda005.Text = "moedas de R$ 0,05";
            // 
            // lblqtdMoeda001
            // 
            this.lblqtdMoeda001.AutoSize = true;
            this.lblqtdMoeda001.Location = new System.Drawing.Point(582, 135);
            this.lblqtdMoeda001.Name = "lblqtdMoeda001";
            this.lblqtdMoeda001.Size = new System.Drawing.Size(105, 15);
            this.lblqtdMoeda001.TabIndex = 16;
            this.lblqtdMoeda001.Text = "moedas de R$ 0,01";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(33, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(286, 181);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbtValorCompra
            // 
            this.tbtValorCompra.Location = new System.Drawing.Point(142, 56);
            this.tbtValorCompra.Name = "tbtValorCompra";
            this.tbtValorCompra.Size = new System.Drawing.Size(100, 23);
            this.tbtValorCompra.TabIndex = 18;
            // 
            // tbtValorPago
            // 
            this.tbtValorPago.Location = new System.Drawing.Point(172, 102);
            this.tbtValorPago.Name = "tbtValorPago";
            this.tbtValorPago.Size = new System.Drawing.Size(100, 23);
            this.tbtValorPago.TabIndex = 19;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(45, 167);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(81, 15);
            this.lblTroco.TabIndex = 20;
            this.lblTroco.Text = "Valor do troco";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.tbtValorPago);
            this.Controls.Add(this.tbtValorCompra);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblqtdMoeda001);
            this.Controls.Add(this.lblqtdMoeda005);
            this.Controls.Add(this.lblResultadoTroco);
            this.Controls.Add(this.lblqtdMoeda050);
            this.Controls.Add(this.lblMoeda100);
            this.Controls.Add(this.lblMoeda05);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMoeda50);
            this.Controls.Add(this.lblMoeda25);
            this.Controls.Add(this.lblqtdMoeda100);
            this.Controls.Add(this.lblqtdMoeda010);
            this.Controls.Add(this.lblMoeda10);
            this.Controls.Add(this.lblqtdMoeda025);
            this.Controls.Add(this.lblMoeda01);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.lblCompra);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblMoeda01;
        private System.Windows.Forms.Label lblqtdMoeda025;
        private System.Windows.Forms.Label lblMoeda10;
        private System.Windows.Forms.Label lblqtdMoeda010;
        private System.Windows.Forms.Label lblqtdMoeda100;
        private System.Windows.Forms.Label lblMoeda25;
        private System.Windows.Forms.Label lblMoeda50;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMoeda05;
        private System.Windows.Forms.Label lblMoeda100;
        private System.Windows.Forms.Label lblqtdMoeda050;
        private System.Windows.Forms.Label lblResultadoTroco;
        private System.Windows.Forms.Label lblqtdMoeda005;
        private System.Windows.Forms.Label lblqtdMoeda001;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbtValorCompra;
        private System.Windows.Forms.TextBox tbtValorPago;
        private System.Windows.Forms.Label lblTroco;
    }
}