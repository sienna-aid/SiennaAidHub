using SiennaAidHub.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace SiennaAidHub.Services
{
    public class DataService
    {
        private readonly IMongoCollection<IncomingData> _data;

        public DataService(ISiennaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _data = database.GetCollection<IncomingData>(settings.CollectionName);
        }

        public List<IncomingData> Get() =>
            _data.Find(data => true).ToList();

        public IncomingData Get(string id) =>
            _data.Find<IncomingData>(data => data.Id == id).FirstOrDefault();

        public IncomingData Create(IncomingData data)
        {
            _data.InsertOne(data);
            return data;
        }

        public void Update(string id, IncomingData dataIn) =>
            _data.ReplaceOne(data => data.Id == id, dataIn);

        public void Remove(IncomingData dataIn) =>
            _data.DeleteOne(data => data.Id == dataIn.Id);

        public void Remove(string id) => 
            _data.DeleteOne(data => data.Id == id);
    }
}