using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BarberShop
{
    public partial class MainPage : ContentPage
    {
        int cortes = 100;
        int cejas = 20;
        int barba = 40;
        int mascarillas = 50;

        public MainPage()
        {
            InitializeComponent();
        }

        
        private void B1_Clicked(object sender, EventArgs e)
        {
            int totalCortes = Convert.ToInt32(cortes) * Convert.ToInt32(txt1.Text);
            int totalCejas = Convert.ToInt32(cejas) * Convert.ToInt32(txt2.Text);
            int totalBarba = Convert.ToInt32(barba) * Convert.ToInt32(txt3.Text);
            int totalMascarillas = Convert.ToInt32(mascarillas) * Convert.ToInt32(txt4.Text);

            int totalPago = totalCortes + totalCejas + totalBarba + totalMascarillas;

            txtTotal.Text += totalPago.ToString();
        }
    }
}
