using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OMDBClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var httprequest = WebRequest.Create("http://www.omdbapi.com/?t=Fly");
            var response = httprequest.GetResponse();
            var stream = response.GetResponseStream();
            var readStream = new StreamReader(stream);
            var str = readStream.ReadToEnd();


            var client = new WebClient();
            var str2 = client.DownloadString("http://www.omdbapi.com/?t=Frozen");



            dynamic deserialized = JsonConvert.DeserializeObject(str2);
 

            string title = deserialized.Title;
            int year = deserialized.Year;
            string runtime = deserialized.Runtime;
            string poster = deserialized.Poster;

            str2 = client.DownloadString(poster);


            var json = client.DownloadString("http://www.omdbapi.com/?s=House%20MD");
           

            dynamic deserializedJson = JsonConvert.DeserializeObject(json);

            JArray search = deserializedJson.Search;
            foreach (dynamic elem in search)
            {
                Console.WriteLine(elem.Title);
            }


                //string title = deserialized.Title;
                //int year = deserialized.Year;
                //string runtime = deserialized.Runtime;
                //string poster = deserialized.Poster;

            //str2 = client.DownloadString(poster);
        }
    }
}
