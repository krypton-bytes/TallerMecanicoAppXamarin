using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerMecanico.views.Mecanica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaCitas : ContentPage
    {
        public ListaCitas()
        {
            InitializeComponent();
            obtenerCitas();
        }
        public void obtenerCitas()
        {
            RequestHTTPCitaModel citasModel = new RequestHTTPCitaModel();
            List<CitaModel> citas = citasModel.MostrarCitas();
            citasListView.ItemsSource = citas;
        }
    }
}