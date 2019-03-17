using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ClienteApiSeguridadCore.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClienteApiSeguridadCore.Repositories
{
    public class RepositoryApiEmpleados : IRepositoryApiEmpleados
    {
        private String uriapi;
        private MediaTypeWithQualityHeaderValue headerjson;

        public RepositoryApiEmpleados()
        {
            this.uriapi = "https://localhost:44387/";
            this.headerjson =
new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<String> GetToken(String usuario
            , String password)
        {
            using (HttpClient client = new HttpClient())
            {
                //setup client
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                LoginModel login = new LoginModel();
                login.UserName = usuario;
                login.Password = password;
                String json = JsonConvert.SerializeObject(login);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                String peticion = "Auth/Login";
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {
                    String contenido =
                        await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(contenido);
                    return jObject.GetValue("response").ToString();
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

        //METODO SIN SEGURIDAD
        public async Task<Empleado> BuscarEmpleado(int empno)
        {
            Empleado empleado = await
                this.CallApi<Empleado>("api/Empleados/" + empno, null);
            return empleado;
        }

        public async Task<List<Empleado>> GetEmpleados(String token)
        {
            List<Empleado> empleados = await
                this.CallApi<List<Empleado>>("api/Empleados", token);
            return empleados;
        }

        public async Task<List<Empleado>> GetEmpleadosSubordinados(string token)
        {
            List<Empleado> empleados = await
                this.CallApi<List<Empleado>>("api/Empleados/GetSubordinados", token);
            return empleados;
        }

        public async Task<Empleado> PerfilEmpleado(string token)
        {
            Empleado empleado = await
    this.CallApi<Empleado>("api/Empleados/PerfilEmpleado", token);
            return empleado;
        }
    }
}
