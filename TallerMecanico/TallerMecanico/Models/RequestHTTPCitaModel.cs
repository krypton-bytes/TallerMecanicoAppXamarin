using HTTPupt;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanico.Models
{
    class RequestHTTPCitaModel
    {
        PeticionHTTP peticionHttp = new PeticionHTTP("https://webservicetallermecanico20230731022439.azurewebsites.net");
        
        #region MetodosCita
        /// <summary>
        /// Metodo para poder agendar una cita de un registro
        /// </summary>
        /// <param name="request"> Recibe un objeto del modelo CitaModel"</param>
        /// <returns>Retorna la respuesta en bool</returns>
        public string AgendarCita(CitaModel request)
        {
            string enviarJson = JsonConvertidor.Objeto_Json(request);
            peticionHttp.PedirComunicacion("Citas/AgendarCita", MetodoHTTP.POST, TipoContenido.JSON);
            peticionHttp.enviarDatos(enviarJson);
            string data = peticionHttp.ObtenerJson();
            return data;
        }
        /// <summary>
        /// Metodo para actualizar cita
        /// </summary>
        /// <param name="request">Recibe un objeto del modelo CitaModel</param>
        /// <returns>Retorna un bool "true" o "false"</returns>
        public string ActualizarCita(CitaModel request)
        {
            string enviarJson = JsonConvertidor.Objeto_Json(request);
            peticionHttp.PedirComunicacion("Citas/ActualizarCita", MetodoHTTP.POST, TipoContenido.JSON);
            peticionHttp.enviarDatos(enviarJson);
            string data = peticionHttp.ObtenerJson();
            return data;
        }
        /// <summary>
        /// Metodo para mostrar las citas
        /// </summary>
        /// <returns>Retorna una lista de objetos del modelo CitaModel</returns>
        public List<CitaModel> MostrarCitas()
        {
            peticionHttp.PedirComunicacion("Citas/MostrarCitas", MetodoHTTP.GET, TipoContenido.JSON);
            string respuesta = peticionHttp.ObtenerJson();
            if (respuesta == null)
                return null;
            List<CitaModel> citas = JsonConvertidor.Json_ListaObjeto<CitaModel>(respuesta);
            return citas;
        }
        #endregion

    }
}
