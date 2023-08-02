using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerMecanico.views.Mecanica
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InicioMecanica : ContentPage
	{
		public InicioMecanica ()
		{
			InitializeComponent ();
		}

        private void CodigoQR_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GenerarCodigosQR());
        }

        private void Citas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaCitas());
        }
    }
}