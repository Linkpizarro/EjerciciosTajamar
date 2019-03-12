using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using ClienteApiDepartamentos.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace ClienteApiDepartamentos.Repositories
{
    public class RepositoryApiDepartamentos
    {
        private String uriapi;
        private MediaTypeWithQualityHeaderValue headerjson;
        public RepositoryApiDepartamentos()
        {
            this.uriapi = "https://apidepartamentosdpc.azurewebsites.net/";
            this.headerjson = new
                MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Departamento> departamentos =
                    await response.Content.ReadAsAsync<List<Departamento>>();
                    return departamentos;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<Departamento> 
            BuscarDepartamentoAsync(int deptno)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos/" + deptno;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Departamento departamento =
                    await response.Content.ReadAsAsync<Departamento>();
                    return departamento;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task InsertarDepartamentoAsync(int num
            , String nom, String loc)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Departamento dept = new Departamento();
                dept.Numero = num;
                dept.Nombre = nom;
                dept.Localidad = loc;
                String json = JsonConvert.SerializeObject(dept);
                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }

        public async Task ModificarDepartamentoAsync(int num
    , String nom, String loc)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos/" + num;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Departamento dept = new Departamento();
                dept.Numero = num;
                dept.Nombre = nom;
                dept.Localidad = loc;
                String json = JsonConvert.SerializeObject(dept);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);
            }
        }

        public async Task EliminarDepartamentoAsync(int num)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Departamentos/" + num;
                //String peticion = "api/EliminarDatos/14/AAA";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);
            }
        }

        public async Task<List<Empleado>> GetEmpleadosDepartamentoAsync(List<int> dept_no)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EmpleadosDept?";
                String datos = "";
                foreach (int item in dept_no)
                {
                    datos += "dept_no=" + item + "&";
                }
                datos = datos.Trim('&');
                peticion += datos;

                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Empleado> empleados =
                    await response.Content.ReadAsAsync<List<Empleado>>();
                    return empleados;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
