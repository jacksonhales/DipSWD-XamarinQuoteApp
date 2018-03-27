using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuoteApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{

        int i;
        double stepValue = 1.0;
        string[] quotes = new string[4]
        {
            "Weather forecast for tonight: Dark.",
            "Don't sweat the petty things and don't pet the sweaty things.",
            "Not only do I not know what's going on, I wouldn't know what to do about it if I did.",
            "When you step on the brakes, your life is in foot's hands."
        };

        public QuotesPage ()
		{
			InitializeComponent ();

            i = 0;
            sdrFontSize.Value = 16;
            lblQuote.Text = quotes[i];      

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (i < 3)
            {
                i++;
                lblQuote.Text = quotes[i];
            }
            else
            {
                i = 0;
                lblQuote.Text = quotes[i];
            }
        }

        void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / stepValue);

            sdrFontSize.Value = newStep * stepValue;
        }

    }
}