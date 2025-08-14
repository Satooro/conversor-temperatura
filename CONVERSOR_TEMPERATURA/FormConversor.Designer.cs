namespace CONVERSOR_TEMPERATURA
{
    partial class FormConversor
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
            this.GBPara = new System.Windows.Forms.GroupBox();
            this.RBKelvin = new System.Windows.Forms.RadioButton();
            this.RBFahre = new System.Windows.Forms.RadioButton();
            this.RBCelcius = new System.Windows.Forms.RadioButton();
            this.RBToK = new System.Windows.Forms.RadioButton();
            this.RBToF = new System.Windows.Forms.RadioButton();
            this.RBToC = new System.Windows.Forms.RadioButton();
            this.GBDestino = new System.Windows.Forms.GroupBox();
            this.GBTemperatura = new System.Windows.Forms.GroupBox();
            this.TBTemperatura = new System.Windows.Forms.TextBox();
            this.LBTextoTemp = new System.Windows.Forms.Label();
            this.GBResultado = new System.Windows.Forms.GroupBox();
            this.TBResposta = new System.Windows.Forms.Label();
            this.BTConverter = new System.Windows.Forms.Button();
            this.GBPara.SuspendLayout();
            this.GBDestino.SuspendLayout();
            this.GBTemperatura.SuspendLayout();
            this.GBResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBPara
            // 
            this.GBPara.Controls.Add(this.RBKelvin);
            this.GBPara.Controls.Add(this.RBFahre);
            this.GBPara.Controls.Add(this.RBCelcius);
            this.GBPara.Location = new System.Drawing.Point(22, 28);
            this.GBPara.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GBPara.Name = "GBPara";
            this.GBPara.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GBPara.Size = new System.Drawing.Size(233, 100);
            this.GBPara.TabIndex = 0;
            this.GBPara.TabStop = false;
            this.GBPara.Text = "Converter de:";
            // 
            // RBKelvin
            // 
            this.RBKelvin.AutoSize = true;
            this.RBKelvin.Location = new System.Drawing.Point(8, 68);
            this.RBKelvin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBKelvin.Name = "RBKelvin";
            this.RBKelvin.Size = new System.Drawing.Size(69, 17);
            this.RBKelvin.TabIndex = 2;
            this.RBKelvin.Text = "KELVIN";
            this.RBKelvin.UseVisualStyleBackColor = true;
            // 
            // RBFahre
            // 
            this.RBFahre.AutoSize = true;
            this.RBFahre.Location = new System.Drawing.Point(8, 44);
            this.RBFahre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBFahre.Name = "RBFahre";
            this.RBFahre.Size = new System.Drawing.Size(104, 17);
            this.RBFahre.TabIndex = 1;
            this.RBFahre.Text = "FAHRENHEIT";
            this.RBFahre.UseVisualStyleBackColor = true;
            // 
            // RBCelcius
            // 
            this.RBCelcius.AutoSize = true;
            this.RBCelcius.Location = new System.Drawing.Point(8, 20);
            this.RBCelcius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBCelcius.Name = "RBCelcius";
            this.RBCelcius.Size = new System.Drawing.Size(77, 17);
            this.RBCelcius.TabIndex = 0;
            this.RBCelcius.Text = "CELSIUS";
            this.RBCelcius.UseVisualStyleBackColor = true;
            // 
            // RBToK
            // 
            this.RBToK.AutoSize = true;
            this.RBToK.Location = new System.Drawing.Point(8, 68);
            this.RBToK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBToK.Name = "RBToK";
            this.RBToK.Size = new System.Drawing.Size(69, 17);
            this.RBToK.TabIndex = 2;
            this.RBToK.Text = "KELVIN";
            this.RBToK.UseVisualStyleBackColor = true;
            // 
            // RBToF
            // 
            this.RBToF.AutoSize = true;
            this.RBToF.Location = new System.Drawing.Point(8, 44);
            this.RBToF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBToF.Name = "RBToF";
            this.RBToF.Size = new System.Drawing.Size(104, 17);
            this.RBToF.TabIndex = 1;
            this.RBToF.Text = "FAHRENHEIT";
            this.RBToF.UseVisualStyleBackColor = true;
            // 
            // RBToC
            // 
            this.RBToC.AutoSize = true;
            this.RBToC.Location = new System.Drawing.Point(8, 20);
            this.RBToC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBToC.Name = "RBToC";
            this.RBToC.Size = new System.Drawing.Size(77, 17);
            this.RBToC.TabIndex = 0;
            this.RBToC.Text = "CELSIUS";
            this.RBToC.UseVisualStyleBackColor = true;
            // 
            // GBDestino
            // 
            this.GBDestino.Controls.Add(this.RBToK);
            this.GBDestino.Controls.Add(this.RBToF);
            this.GBDestino.Controls.Add(this.RBToC);
            this.GBDestino.Location = new System.Drawing.Point(297, 28);
            this.GBDestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GBDestino.Name = "GBDestino";
            this.GBDestino.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GBDestino.Size = new System.Drawing.Size(233, 100);
            this.GBDestino.TabIndex = 3;
            this.GBDestino.TabStop = false;
            this.GBDestino.Text = "Converter PARA:";
            // 
            // GBTemperatura
            // 
            this.GBTemperatura.Controls.Add(this.TBTemperatura);
            this.GBTemperatura.Controls.Add(this.LBTextoTemp);
            this.GBTemperatura.Location = new System.Drawing.Point(22, 152);
            this.GBTemperatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GBTemperatura.Name = "GBTemperatura";
            this.GBTemperatura.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GBTemperatura.Size = new System.Drawing.Size(233, 95);
            this.GBTemperatura.TabIndex = 4;
            this.GBTemperatura.TabStop = false;
            this.GBTemperatura.Text = "Temperatura ";
            // 
            // TBTemperatura
            // 
            this.TBTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTemperatura.Location = new System.Drawing.Point(8, 36);
            this.TBTemperatura.MaxLength = 12;
            this.TBTemperatura.Name = "TBTemperatura";
            this.TBTemperatura.Size = new System.Drawing.Size(213, 38);
            this.TBTemperatura.TabIndex = 2;
            this.TBTemperatura.Text = "0";
            this.TBTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTemperatura_KeyPress);
            // 
            // LBTextoTemp
            // 
            this.LBTextoTemp.AutoSize = true;
            this.LBTextoTemp.Location = new System.Drawing.Point(27, 20);
            this.LBTextoTemp.Name = "LBTextoTemp";
            this.LBTextoTemp.Size = new System.Drawing.Size(158, 13);
            this.LBTextoTemp.TabIndex = 1;
            this.LBTextoTemp.Text = "INSIRA A TEMPERATURA";
            this.LBTextoTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GBResultado
            // 
            this.GBResultado.Controls.Add(this.TBResposta);
            this.GBResultado.Location = new System.Drawing.Point(297, 152);
            this.GBResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GBResultado.Name = "GBResultado";
            this.GBResultado.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GBResultado.Size = new System.Drawing.Size(233, 95);
            this.GBResultado.TabIndex = 5;
            this.GBResultado.TabStop = false;
            this.GBResultado.Text = "Temperatura Convertida";
            // 
            // TBResposta
            // 
            this.TBResposta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBResposta.ForeColor = System.Drawing.Color.Black;
            this.TBResposta.Location = new System.Drawing.Point(8, 36);
            this.TBResposta.Name = "TBResposta";
            this.TBResposta.Size = new System.Drawing.Size(218, 38);
            this.TBResposta.TabIndex = 0;
            this.TBResposta.Text = "RESPOSTA";
            this.TBResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTConverter
            // 
            this.BTConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConverter.Location = new System.Drawing.Point(127, 267);
            this.BTConverter.Name = "BTConverter";
            this.BTConverter.Size = new System.Drawing.Size(293, 44);
            this.BTConverter.TabIndex = 6;
            this.BTConverter.Text = "Converter";
            this.BTConverter.UseVisualStyleBackColor = true;
            this.BTConverter.Click += new System.EventHandler(this.BTConverter_Click);
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(556, 336);
            this.Controls.Add(this.BTConverter);
            this.Controls.Add(this.GBResultado);
            this.Controls.Add(this.GBTemperatura);
            this.Controls.Add(this.GBDestino);
            this.Controls.Add(this.GBPara);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormConversor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Temperatura";
            this.GBPara.ResumeLayout(false);
            this.GBPara.PerformLayout();
            this.GBDestino.ResumeLayout(false);
            this.GBDestino.PerformLayout();
            this.GBTemperatura.ResumeLayout(false);
            this.GBTemperatura.PerformLayout();
            this.GBResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBPara;
        private System.Windows.Forms.RadioButton RBKelvin;
        private System.Windows.Forms.RadioButton RBFahre;
        private System.Windows.Forms.RadioButton RBCelcius;
        private System.Windows.Forms.RadioButton RBToK;
        private System.Windows.Forms.RadioButton RBToF;
        private System.Windows.Forms.RadioButton RBToC;
        private System.Windows.Forms.GroupBox GBDestino;
        private System.Windows.Forms.GroupBox GBTemperatura;
        private System.Windows.Forms.Label LBTextoTemp;
        private System.Windows.Forms.GroupBox GBResultado;
        private System.Windows.Forms.Button BTConverter;
        private System.Windows.Forms.TextBox TBTemperatura;
        private System.Windows.Forms.Label TBResposta;
    }
}

