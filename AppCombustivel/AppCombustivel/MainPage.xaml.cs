using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double preco_etanol = Convert.ToDouble(txt_etanol.Text);
            double preco_gasolina = Convert.ToDouble(txt_gasolina.Text);

            if(preco_etanol > (preco_gasolina * 0.7))
            {
                DisplayAlert("Compensa", "Gasolina", "OK");
            } else
            {
                DisplayAlert("Compensa", "Etanol", "OK");
            }
        }
    }
}
