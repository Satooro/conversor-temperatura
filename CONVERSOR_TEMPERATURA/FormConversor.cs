using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVERSOR_TEMPERATURA
{
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void BTConverter_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(TBTemperatura.Text);
            ConverterCK(temp);
            ConverterFC(temp);
            ConverterKF(temp);
            ConversaoInvalida();
        }


        private void ConversaoInvalida()
        {
            if (RBCelcius.Checked && RBToC.Checked || RBFahre.Checked && RBToF.Checked || RBKelvin.Checked && RBToK.Checked)
            {
                TBResposta.Text = "Conversão inválida";

            }

        }

        private void ConverterCK(double temp)
        {
            if(RBCelcius.Checked && RBToK.Checked)
            {
                double k = temp + 273.15;
                TBResposta.Text = $"{k:N2}";
            }
            if (RBKelvin.Checked && RBToC.Checked)
            {
                double k = temp - 273.15;
                TBResposta.Text = $"{k:N2}";
            }
            
        }
        private void ConverterFC(double temp)
        {

            if (RBCelcius.Checked && RBToF.Checked)
            {
                double f = (temp * 1.8) + 32;
                TBResposta.Text = $"{f:N2}";
            }
            if(RBFahre.Checked && RBToC.Checked)
            {
                double f = (temp - 32) / 1.8;
                TBResposta.Text = $"{temp:N2}Fº = {f:N2}ºC";
            }
        }
        private void ConverterKF(double temp)
        {
            if (RBKelvin.Checked && RBToF.Checked)
            {
                double k = ((temp - 273.15) * 1.8) + 32;
                TBResposta.Text = $"{temp:N2}K = {k:N2}Fº";
            }
            if (RBFahre.Checked && RBToK.Checked)
            {
                double k = 273.15 + (temp - 32.0) / 1.8 + 273.15;
                TBResposta.Text = $"${temp:N2}Fº = ${k:N2}";
            }
        }

        private void TBTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
