using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace ApiPersonasPuro.App_Start
{
    public class AccessPolicyCors : Attribute, ICorsPolicyProvider
    {
        public async Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var corsRequestContext = request.GetCorsRequestContext();
            var originRequested = corsRequestContext.Origin;

            if (await IsOriginFromAPaidCustomer(originRequested))
            {
                //HABILITAMOS PETICIONES CORS
                var policy = new CorsPolicy
                {
                    AllowAnyHeader = true,
                    AllowAnyMethod = true
                };
                System.Diagnostics.Debug.WriteLine(originRequested);
                //ACCESO A TODAS LAS PETICIONES
                policy.Origins.Add(originRequested);
                //SI SOLAMENTE DESEAMOS UNA PETICION DE UN
                //CLIENTE, PUES LO INCLUIMOS
                //policy.Origins.Add("https://mvcapipersonasdpc.azurewebsites.net");
                return policy;
            }
            return null;
        }

        private async Task<bool> IsOriginFromAPaidCustomer(string originRequested)
        {
            return true;
        }

    }
}