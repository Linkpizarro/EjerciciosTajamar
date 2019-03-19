using ClientePracticaMonedas.Models;
using ClientePracticaMonedas.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientePracticaMonedas.Repositories
{
    public class MonedasRepository
    {
        //Obtenemos todas las Monedas.
        public async Task<List<Moneda>> GetMonedas()
        {
            List<Moneda> monedas = await Api.CallApi<List<Moneda>>("api/Monedas/",null);
            return monedas;
        }

        //Obtenemos una Moneda concreta.
        public async Task<Moneda> GetMoneda(int id)
        {
            Moneda moneda = await Api.CallApi<Moneda>("api/Monedas/" + id, null);
            return moneda;
        }

    }
}
