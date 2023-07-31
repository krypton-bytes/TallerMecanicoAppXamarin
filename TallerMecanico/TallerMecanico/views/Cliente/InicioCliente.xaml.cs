using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerMecanico.views.Cliente
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InicioCliente : ContentPage
	{
		public InicioCliente ()
		{
			InitializeComponent ();
           
        }

        private void vehiculo_Clicked(object sender, EventArgs e)
        {

        }

        private void agendarCita_Clicked(object sender, EventArgs e)
        {

        }
    }
}