using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using HTTPupt;
using Newtonsoft.Json;
using TallerMecanico.Models;
using Xamarin.Forms;

namespace TallerMecanico.Models
{
    class RequestHTTPUserModel
    {
        PeticionHTTP peticionHttp = new PeticionHTTP("https://webservicetallermecanico20230731022439.azurewebsites.net");

        #region MetodosRegistro
        /// <summary>
        /// Metodo para poder obtener la lista de registros
        /// </summary>
        /// <returns>Retorna la respuesta una lista del RegistroModel</returns>
        public List<RegistroModel> RegistrosList()
        {
            peticionHttp.PedirComunicacion("Registros/MostrarUsuarios", MetodoHTTP.GET,TipoContenido.JSON);
            string respuesta = peticionHttp.ObtenerJson();
            if(respuesta == null)
                return null;
            List<RegistroModel> registros = JsonConvertidor.Json_ListaObjeto<RegistroModel>(respuesta);
            return registros;
        }
        /// <summary>
        /// Metodo para poder registrar un usuario
        /// </summary>
        /// <param name="request">Recibe un objeto de la clase RegistroModel</param>
        /// <returns>Retorna un bool "true" o "false"</returns>

        public string RegistrarCuenta(RegistroModel request)
        {
            string enviarJson= JsonConvertidor.Objeto_Json(request);
            peticionHttp.PedirComunicacion("Registros/RegistroUsuario", MetodoHTTP.POST, TipoContenido.JSON);
            peticionHttp.enviarDatos(enviarJson);
            string data = peticionHttp.ObtenerJson();
            return data;
        }
        /// <summary>
        /// Metodo para verificar la cuenta de un usuario
        /// </summary>
        /// <param name="user">Recibe un objeto de la clase RegistroModel</param>
        /// <returns>Retorna un bool "true" o "false"</returns>
        public RegistroModel VerficarCuenta(RegistroModel user)
        {
            string enviarJson = JsonConvertidor.Objeto_Json(user);
            peticionHttp.PedirComunicacion("Registros/VerficarCuenta", MetodoHTTP.POST, TipoContenido.JSON);
            peticionHttp.enviarDatos(enviarJson);
            string data = peticionHttp.ObtenerJson();
            Debug.WriteLine($"JSON enviado:{data}");
            if (data == null)
            {
                return null;

            }
            RegistroModel registros = JsonConvertidor.Json_Objeto<RegistroModel>(data);
            return registros;
        }
        #endregion

    }
}
