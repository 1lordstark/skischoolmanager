using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace SkiSchool.Web.RestHelpers
{
    public class Invoke
    {
        public static T Get<T>(Uri uri, out HttpStatusCode httpStatusCode)
        {
            T t;

            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                
                Task<HttpResponseMessage> task = client.GetAsync(uri);

                task.Wait();

                var httpResponseMessage = task.Result;

                t = httpResponseMessage.Content.ReadAsAsync<T>().Result;

                httpStatusCode = httpResponseMessage.StatusCode;
            }

            return t;
        }
    }
}