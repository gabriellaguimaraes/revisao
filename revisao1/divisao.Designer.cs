﻿namespace revisao1
{
    partial class divisao
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
            this.tx_valor1 = new System.Windows.Forms.TextBox();
            this.tx_valor2 = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_valor1
            // 
            this.tx_valor1.Location = new System.Drawing.Point(85, 46);
            this.tx_valor1.Name = "tx_valor1";
            this.tx_valor1.Size = new System.Drawing.Size(80, 20);
            this.tx_valor1.TabIndex = 0;
            // 
            // tx_valor2
            // 
            this.tx_valor2.Location = new System.Drawing.Point(85, 96);
            this.tx_valor2.Name = "tx_valor2";
            this.tx_valor2.Size = new System.Drawing.Size(80, 20);
            this.tx_valor2.TabIndex = 1;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(70, 154);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(115, 40);
            this.bt_calcular.TabIndex = 2;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(67, 122);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 13);
            this.lb_resultado.TabIndex = 3;
            this.lb_resultado.Click += new System.EventHandler(this.lb_resultado_Click);
            // 
            // divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 243);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.tx_valor2);
            this.Controls.Add(this.tx_valor1);
            this.Name = "divisao";
            this.Text = "divisao";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_valor1;
        private System.Windows.Forms.TextBox tx_valor2;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label lb_resultado;
    }
}