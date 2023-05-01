using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Web;
using Google.Apis.Http;

namespace gogo_v0._3.api.v1
{
    public class test
    {

        public HttpResponseMessage Get()
        {
            // קוד לטיפול בבקשה
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent("זו התגובה הראשונה מנקודת הכניסה של ה-API שלי!");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
            return response;
        }
        
 


    }
}