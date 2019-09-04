using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace SiennaAidHub.Models
{
    public class IncomingData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

	public string EventType { get; set; }

	public IEnumerable<Accelerometer> Accelerometer { get; set; }
	public IEnumerable<Gyroscope> Gyroscope { get; set; }
	public IEnumerable<Pedometer> Pedometer { get; set; }
	    
	public DateTime Start { get; set; }
	public DateTime End { get; set; }

	public string DeviceId { get; set; }
    }

    public class Accelerometer
    {
	public float x { get; set; }
	public float y { get; set; }
	public float z { get; set; }
    }

    public class Gyroscope
    {
	public float x { get; set; }
	public float y { get; set; }
	public float z { get; set; }
    }

    public class Pedometer
    {
	public int StepCount { get; set; }
    }
}