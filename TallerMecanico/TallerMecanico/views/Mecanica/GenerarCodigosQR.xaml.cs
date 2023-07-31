using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace TallerMecanico.views.Mecanica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenerarCodigosQR : ContentPage
    {
        ZXingBarcodeImageView QR;
        ModalQR modalPage;
        public GenerarCodigosQR()
        {
            InitializeComponent();
            modalPage = new ModalQR();
        }

        private async void btnGeneraCodigo_Clicked(object sender, EventArgs e)
        {
            await MostrarModal("Estado1");
        }

        private async void btnGeneraCodigo2_Clicked(object sender, EventArgs e)
        {
            await MostrarModal("Estado2");
        }
        private async void btnGeneraCodigo3_Clicked(object sender, EventArgs e)
        {
            await MostrarModal("Estado3");
        }
        private async void btnGeneraCodigo4_Clicked(object sender, EventArgs e)
        {
            await MostrarModal("Estado4");
        }
        private async void btnGeneraCodigo5_Clicked(object sender, EventArgs e)
        {
            await MostrarModal("Estado5");
        }
        private async Task MostrarModal(string content)
        {
            modalPage.UpdateQRCode(content); // Actualizamos el contenido del QR en el modal
            await Navigation.PushModalAsync(modalPage);
        }
    }
}