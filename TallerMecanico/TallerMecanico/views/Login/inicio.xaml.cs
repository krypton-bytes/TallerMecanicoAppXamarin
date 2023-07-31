using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.views.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerMecanico.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (sender, e) =>
            {
                // Realizar la navegación a la página "Registro"
                Navigation.PushAsync(new Registro());
            };

            lblRegistro.GestureRecognizers.Add(tapGestureRecognizer);
        }

        
    }
}