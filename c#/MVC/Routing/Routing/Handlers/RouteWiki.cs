using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Routing.Handlers
{
    public class RouteWiki : IRouteHandler
    {
        private List<String> provinces;
        public RouteWiki(List<String> provinces)
        {
            this.provinces = provinces;
        }
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new HandlerWiki(provinces,requestContext);
        }
    }
}