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
    public class PedidosRepository
    {

        //Obtenemos los Pedidos de un Cliente concreto.
        public async Task<List<Pedido>> GetPedidos(int cliente_id,String token)
        {
            List<Pedido> pedidos = await Api.CallApi<List<Pedido>>("api/Pedidos/" + cliente_id,token);
            return pedidos;
        }

        //Inserta un Pedido.
        public async Task PostPedido (Pedido pedido,String token)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Pedidos";
                client.BaseAddress = new Uri(Api.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Api.headerjson);
                String json = JsonConvert.SerializeObject(pedido);
                StringContent content = new StringContent(json,System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(peticion, content);
            }
        }

        //Eliminamos un Pedido.
        public async Task DeletePedido(int id,String token)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Pedidos/" + id;
                client.BaseAddress = new Uri(Api.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Api.headerjson);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);
                await client.DeleteAsync(peticion);
            }
        }

    }
}
