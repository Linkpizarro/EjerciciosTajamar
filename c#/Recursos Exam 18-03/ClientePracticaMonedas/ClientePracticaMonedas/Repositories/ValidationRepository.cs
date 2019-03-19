using ClientePracticaMonedas.Tools;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientePracticaMonedas.Repositories
{
    public class ValidationRepository
    {
        //Obtenemos el Token de la Api.
        public async Task<String> GetToken(String usuario,String password)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "login";
                client.BaseAddress = new Uri(Api.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Api.headerjson);
                FormUrlEncodedContent content =
                    new FormUrlEncodedContent(new[]
                    {
                    new KeyValuePair<string, string>("grant_type", "password")
                    ,new KeyValuePair<string, string>("username", usuario)
                    ,new KeyValuePair<string, string>("password", password)
                    });
                HttpResponseMessage response = await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {
                    String contenido = await response.Content.ReadAsStringAsync();
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
    }
}
