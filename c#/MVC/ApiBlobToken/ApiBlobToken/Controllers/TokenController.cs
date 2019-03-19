using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;

namespace ApiBlobToken.Controllers
{
    public class TokenController : ApiController
    {
        public CloudBlobContainer RecuperarContenedor()
        {
            String keys = CloudConfigurationManager.GetSetting("StorageConnectionString");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudBlobClient client = account.CreateCloudBlobClient();
            CloudBlobContainer container = client.GetContainerReference("contenedorseguro");
            container.CreateIfNotExists();
            return container;
        }
        public String Get()
        {
            CloudBlobContainer container = RecuperarContenedor();
            SharedAccessBlobPolicy permissions = new SharedAccessBlobPolicy();
            permissions.SharedAccessExpiryTime = DateTime.Now.AddMinutes(10);
            permissions.Permissions =
                  SharedAccessBlobPermissions.Create
                | SharedAccessBlobPermissions.List
                | SharedAccessBlobPermissions.Read
                | SharedAccessBlobPermissions.Write
                | SharedAccessBlobPermissions.Delete;
            String token = container.GetSharedAccessSignature(permissions);
            return container.Uri + token;
        }
    }
}
