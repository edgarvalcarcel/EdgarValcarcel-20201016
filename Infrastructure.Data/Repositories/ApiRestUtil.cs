using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public static class ApiRestUtil
    {
        public static T MyRequest<T>(string resource,int id) where T : new()
        {
            string newRequest = "";
            var client = new RestClient("https://localhost:44309/");
            if (id > 0)
                newRequest = resource + id.ToString();
            else
                newRequest = resource;
           var request = new RestRequest(newRequest, Method.GET);
            var response = client.Execute(request);

            JsonDeserializer jsonDeserializer = new JsonDeserializer();
            return jsonDeserializer.Deserialize<T>(response);
         }
    }
}
