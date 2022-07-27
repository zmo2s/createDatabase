using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDatabase.Model
{
    public class TagInput
    {
        public ObjectId Id { get; set; }
        public string format { get; set; }
        public string model { get; set; }
        public string version { get; set; }
        public MongoDBRef configBase { get; set; }
    }
}
