using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Forms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerMecanico.views.Mecanica
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetallesCita : ContentPage
	{
		ZXingBarcodeImageView QR;
		public DetallesCita ()
		{
			InitializeComponent ();
		}
    }
}