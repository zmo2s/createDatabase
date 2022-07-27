using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDatabase.Model
{
    public class ConfigBase
    {
        public ObjectId Id { get; set; }
        public bool dureeEvent { get; set; }
        public bool isActivateTag { get; set; }
        public bool isLoggerActivate { get; set; }
        public bool puissanceDbm { get; set; }
        public bool recurrenceAdvertising { get; set; }
        public bool recurrenceEvent { get; set; }
        public bool recurrenceLog { get; set; }
        public bool useBUzzer { get; set; }
        public bool useLED { get; set; }
        public bool useModConnected { get; set; }
        public MongoDBRef config400 { get; set; }
        public MongoDBRef configSensor { get; set; }
    }
}
