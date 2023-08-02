using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerMecanico.views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            RequestHTTPUserModel registro = new RequestHTTPUserModel();
            if (registro.RegistrarCuenta(new RegistroModel
            {
                Apellidos = txtApellidos.Text,
                Correo = txtEmail.Text,
                Contrasena = txtPassword.Text,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text
            }) == "true")
            {
                inicio modal = new inicio();
                Navigation.PushAsync(modal);
                //Navigation.PushModalAsync(modal);
            }
            else
            {
                DisplayAlert("Error", "No se pudo registrar el usuario", "OK");
            }
        }
    }
}