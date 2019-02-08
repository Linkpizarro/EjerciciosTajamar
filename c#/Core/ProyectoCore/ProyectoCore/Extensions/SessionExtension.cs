using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCore.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject<T>(this ISession session,String key,Object value)
        {
            String json = JsonConvert.SerializeObject(value);
            session.SetString(key,json);
        }
        public static T GetObject<T>(this ISession session,String key)
        {
            String json = session.GetString(key);
            if (json is null)
            {
                return default(T);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            
        }
        
    }
}
