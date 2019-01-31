using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Routing.Handlers
{
    public class HandlerWiki : IHttpHandler
    {
        private List<String> provinces;
        private RequestContext requestcontext;
 
        public HandlerWiki(List<String>provinces, RequestContext requestcontext)
        {
            this.provinces = provinces;
            this.requestcontext = requestcontext;
        }

        public bool IsReusable { get; set; }

        public void ProcessRequest(HttpContext context)
        {
            RouteValueDictionary rutes = this.requestcontext.RouteData.Values;
            String province = rutes["ProvinceName"].ToString();
            if (this.provinces.Contains(province))
            {
                context.AddError(new Exception("La provincia de"+ province +",está protegida por el Gobierno de los Estados Unidos de América"));
            }
            else
            {
                String wiki = "https://es.wikipedia.org/wiki/" + province;
                context.Response.Redirect(wiki, true);
            }
           
        }
    }
}