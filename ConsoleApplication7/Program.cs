using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Elena");
            var collection = db.GetCollection<BsonDocument>("User");

            for (int i = 0; i < 1000; i++)
            {
                var document = new BsonDocument
                {
                    { "type" , "MyPups"},
                    { "userId", i.ToString() },
                };
                collection.InsertOneAsync(document);
            }
        }
    }
}
