using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_de_propinas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void calcular_Clicked(object sender, EventArgs e)
        {
           var total = decimal.Parse(txtTotal.Text);
            var propina= decimal.Parse(txtPropina.Text);
            var nDePersonas = decimal.Parse(txtNumero_personas.Text);

            decimal totalPropina = total * (propina / 100);

            lblpropina.Text = totalPropina.ToString("C");

            decimal granTotal = total + totalPropina;

            lbltotal.Text = granTotal.ToString("C");

            decimal propina_persona = totalPropina / nDePersonas;

            lblpropina_persona.Text = propina_persona.ToString("C");

            decimal totalpersona = granTotal / nDePersonas;

            lbltotal_porpersona.Text = totalpersona.ToString("C");
        }
    }
}
