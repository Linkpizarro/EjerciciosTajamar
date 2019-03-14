using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using ClienteApiSeguridadCore.Models;

namespace ClienteApiSeguridadCore.Repositories
{
    public class EmpleadosRepository 
    {
        private String uri;
        private MediaTypeWithQualityHeaderValue header;

        public EmpleadosRepository()
        {
            this.uri = "";
            this.header = new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<String> GetToken(String usuario,String password)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "login";
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                FormUrlEncodedContent content = new FormUrlEncodedContent(new[] {
                    new KeyValuePair<String,String>("grand_type","password"),
                    new KeyValuePair<String,String>("username",usuario),
                    new KeyValuePair<String,String>("password",password)
                });
                HttpResponseMessage response = await client.PostAsync(peticion, content);
                String json = await response.Content.ReadAsStringAsync();
                JObject obj = JObject.Parse(json);
                String token = obj.GetValue("access_token").ToString();
                return token;
            }
        }

        private async Task<T> CallApi<T>(String peticion,String token)
        {
            using (HttpClient cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(uri);
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (token != null)
                {
                    cliente.DefaultRequestHeaders.Add("Authotization","bearer " +token);
                }
                HttpResponseMessage response =
                    await cliente.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    T datos =
                        await response.Content.ReadAsAsync<T>();
                    return (T)Convert.ChangeType(datos, typeof(T));
                }
                else
                {
                    return default(T);
                }
            }
        }

        public async Task<List<Empleado>> GetSubs(String token)
        {
            List<Empleado> minions = await CallApi<List<Empleado>>("api/minions", token);
            return minions;
        }
    }
}
