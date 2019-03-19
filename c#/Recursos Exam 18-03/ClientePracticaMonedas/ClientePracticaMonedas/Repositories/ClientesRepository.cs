using ClientePracticaMonedas.Models;
using ClientePracticaMonedas.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientePracticaMonedas.Repositories
{
    public class ClientesRepository
    {
        //Obtenemos el Perfil de un Cliente.
        public async Task<Cliente> GetCliente(int id,String token){
            Cliente cliente = await Api.CallApi<Cliente>("api/Cliente/" + id, token);
            return cliente;
        }

        //Insertamos un Cliente.
        public async Task PostCliente(Cliente cliente)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Cliente";
                client.BaseAddress = new Uri(Api.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Api.headerjson);
                String json = JsonConvert.SerializeObject(cliente);
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(peticion, content);
            }
        }

        //Obtenemos los datos de un Cliente.
        public async Task<Cliente> GetPerfil(String token)
        {
            Cliente cliente = await Api.CallApi<Cliente>("api/PerfilCliente", token);
            return cliente;
        }
    }
}
