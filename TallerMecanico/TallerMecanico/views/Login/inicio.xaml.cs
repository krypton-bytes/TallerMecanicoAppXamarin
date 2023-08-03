using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.views.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TallerMecanico.Models;

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
                Navigation.PushAsync(new Register());
            };

            lblRegistro.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            RequestHTTPUserModel usuario = new RequestHTTPUserModel();
            // Obtener los valores de correo y contraseña desde las cajas de texto (txtEmail y txtPassword)
            string correo = txtEmail.Text;
            string contrasena = txtPassword.Text;

            // Crear un objeto de RegistroModel para enviar al método VerificarCuenta
            var registroModel = new RegistroModel
            {
                Correo = correo,
                Contrasena = contrasena
            };
            
            // Llamar al método VerificarCuenta del modelo de usuario
            RegistroModel resultado = usuario.VerficarCuenta(registroModel);

            if (resultado.Contrasena == contrasena && resultado.Correo == correo && resultado.Permiso == false)
            {
                 Navigation.PushAsync(new Cliente.InicioCliente());
            }
            else if (resultado.Contrasena == contrasena && resultado.Correo == correo && resultado.Permiso == true)
            {
                 Navigation.PushAsync(new Mecanica.InicioMecanica());
            }
            else if(resultado == null)
            {
                // Si el resultado no es "true" ni "permisoConcedido", mostrar un mensaje de error
                 DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
            }
        }
    }
}