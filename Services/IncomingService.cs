using MongoDB.Driver;
using SiennaAidHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiennaAidHub.Services
{
    public class IncomingService
    {
	private readonly IMongoCollection<Incoming> _incoming;

	public IncomingService(ISiennaDatabaseSettings settings)
	{
	    var client = new MongoClient(settings.ConnectionString);
	    var database = client.GetDatabase(settings.DatabaseName);

	    _incoming = database.GetCollection<Incoming>(settings.SiennaCollectionName);
	}

	public Incoming Create(Incoming incoming)
	{
	    _incoming.InsertOne(incoming);
	    return incoming;
	}
    }
}
