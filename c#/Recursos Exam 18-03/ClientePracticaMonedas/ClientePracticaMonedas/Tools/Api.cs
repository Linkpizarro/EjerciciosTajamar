using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientePracticaMonedas.Tools
{
    public class Api
    {
        public static String uriapi = "https://apipracticamonedascmc.azurewebsites.net/";
        public static MediaTypeWithQualityHeaderValue headerjson = new MediaTypeWithQualityHeaderValue("application/json");

        public static async Task<T> CallApi<T>(String peticion, String token)
        {
            using (HttpClient cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(uriapi);
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(headerjson);
                if (token != null)
                {
                    cliente.DefaultRequestHeaders.Add("Authorization", "bearer " + token);
                }
                HttpResponseMessage response = await cliente.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    T datos = await response.Content.ReadAsAsync<T>();
                    return (T)Convert.ChangeType(datos, typeof(T));
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}
