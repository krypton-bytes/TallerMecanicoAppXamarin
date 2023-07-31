using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace TallerMecanico.views.Mecanica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalQR : ContentPage
    {
        private ZXingBarcodeImageView qrCodeImageView;

        public ModalQR()
        {
            InitializeComponent();

            qrCodeImageView = new ZXingBarcodeImageView
            {
                BarcodeOptions = new ZXing.Common.EncodingOptions
                {
                    Width = 800,
                    Height = 800,
                },
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            qrCodeImageContainer.Content = qrCodeImageView;
        }

        public void UpdateQRCode(string content)
        {
            qrCodeImageView.BarcodeValue = content;
        }

        private async void OnCloseButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }

}