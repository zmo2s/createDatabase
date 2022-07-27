using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDatabase.Model
{
    public class ConfigSensor
    {
        public ObjectId Id { get; set; }
        public bool dureeAiTotOut { get; set; }
        public bool modeMag { get; set; }
        public bool sesibilitePir { get; set; }
    }
}
