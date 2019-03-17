using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using ClienteApiSeguridad.Models;

namespace ClienteApiSeguridad.Repositories
{
    public class RepositoryApiEmpleados
    {
        private String uriapi;
        private MediaTypeWithQualityHeaderValue headerjson;

        public RepositoryApiEmpleados()
        {
            this.uriapi = "http://localhost:59466/";
            this.headerjson =
new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<String> GetToken(String usuario
            , String password)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "login";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                FormUrlEncodedContent content =
                    new FormUrlEncodedContent(new[]
                    {
new KeyValuePair<string, string>("grant_type", "password")
,new KeyValuePair<string, string>("username", usuario)
,new KeyValuePair<string, string>("password", password)
                    });
                HttpResponseMessage response = await
client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {
                    String contenido = await
    response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(contenido);
                    String token = json.GetValue("access_token").ToString();
                    return token;
                }
                else
                {
                    return null;
                }
            }
        }

        private async Task<T> CallApi<T>(String peticion
            , String token)
        {
            using (HttpClient cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(this.uriapi);
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(headerjson);
                if (token != null)
                {
cliente.DefaultRequestHeaders.Add("Authorization", "bearer "
    + token);
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

        public async Task<List<Empleado>> 
            GetSubordinados(String token)
        {
            List<Empleado> empleados = await
                this.CallApi<List<Empleado>>("api/Subordinados"
                , token);
            return empleados;
        }

        public async Task<Empleado> BuscarEmpleado(int empno)
        {
            Empleado empleado = await
                this.CallApi<Empleado>("api/Empleados/" + empno
                , null);
            return empleado;
        }
    }
}
