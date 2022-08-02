using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDatabase.Model
{
    public class ConfigSensor
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public bool dureeAiTorOut { get; set; }
        public bool modeMag { get; set; }
        public bool sensibilitePir { get; set; }
    }
}
